using PP11.Forms;
using PP11.Properties;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP11
{
    public partial class AuthorizationForm : PatternForm
    {
        private int failSignInCount = 0;
        private int blockingDuration = 180;
        private int countTimer = 10;
        internal bool captchaPassed = false;
        private DataBase dataBase;

        public AuthorizationForm()
        {
            InitializeComponent();

            textBoxName.Text = "";
            textBoxPassword.Text = "";
            textBoxPassword.UseSystemPasswordChar = true;
            labelHeader.Text = "Авторизация";
            labelTimer.Visible = false;
            dataBase = new DataBase();
        }

        private void buttonPasswordShow_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                buttonPasswordShow.BackgroundImage = Resources.blind;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                buttonPasswordShow.BackgroundImage = Resources.show;
            }
        }

        private async void buttonSignIn_Click(object sender, EventArgs e)
        {
            await BlockButton();

            string login = textBoxName.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            if (failSignInCount > 1)
            {
                var capchaForm = new CaptchaForm();
                capchaForm.Owner = this;
                capchaForm.ShowDialog();

                if (captchaPassed == false)
                {
                    var timer = new Timer();
                    timer.Interval = 1000;
                    timer.Tick += timer1_Tick;
                    timer.Start();

                    labelTimer.Visible = true;
                    buttonSignIn.Enabled = false;

                    return;
                }
            }

            string query = query = $"SELECT id FROM Employees WHERE login = '{login}'";

            var result = await dataBase.SelectQuery(query);
            
            if(result.Rows.Count < 1)
            {
                MessageBox.Show("Такого пользователя не существует");
                return;
            }

            int userId = (int)result.Rows[0][0];

            query = $"SELECT id, id_position, surname, name, patronymic, imgHref FROM Employees WHERE login = '{login}' and password = '{password}'";
            result = await dataBase.SelectQuery(query);

            if (result.Rows.Count > 0)
            {
                var userRow = result.Rows[0];

                int id = (int)userRow[0];
                int id_position = (int)userRow[1];
                string surname = (string)userRow[2];
                string name = (string)userRow[3];
                string patronymic = (string)userRow[4];
                string imgHref = (string)userRow [5];

                CurrentUser.Id = id;
                CurrentUser.PositionId = id_position;
                CurrentUser.Name = name;
                CurrentUser.Patronymic = patronymic;
                CurrentUser.Surname = surname;
                CurrentUser.ImgHref = imgHref;


                switch (id_position)
                {
                    case 1:
                        var fr1 = new SalesmanForm();
                        fr1.Owner = this;
                        fr1.Show();
                        break;
                    case 2:
                        var fr2 = new SeniorForm();
                        fr2.Owner = this;
                        fr2.Show();
                        break;
                    case 3:
                        var fr3 = new AdministratorForm();
                        fr3.Owner = this;
                        fr3.Show();
                        break;
                }

                captchaPassed = false;
                failSignInCount = 0;
                textBoxName.Text = String.Empty;
                textBoxPassword.Text = String.Empty;
                this.Hide();

                string querySelect = "SELECT COUNT(id) FROM LoginHistory";
                var result1 = await dataBase.SelectQuery(querySelect);
                int count = (int)result1.Rows[0][0];

                string queryInsert = $"INSERT LoginHistory (id, id_employee, login_date, id_type_login) VALUES({count + 1}, {userId}, GETDATE(), 1)";
                await dataBase.InsertQuery(queryInsert);
            }
            else
            {
                failSignInCount++;
                MessageBox.Show("Неверный пароль");

                string querySelect = "SELECT COUNT(id) FROM LoginHistory";
                var result1 = await dataBase.SelectQuery(querySelect);
                int count = (int)result1.Rows[0][0];

                string queryInsert = $"INSERT LoginHistory (id, id_employee, login_date, id_type_login) VALUES({count + 1}, {userId}, GETDATE(), 2)";
                await dataBase.InsertQuery(queryInsert);
            }
        }
        

        private async Task BlockButton()
        {
            buttonSignIn.Enabled = false;
            await Task.Delay(100);
            buttonSignIn.Enabled = true;
        }

        public async Task BlockApp()
        {
            labelTimer.Text = "Повторите попытку через: 03:00";
            labelTimer.Visible = true;
            buttonSignIn.Enabled = false;

            var timerBlockApp = new Timer();
            timerBlockApp.Interval = 1000;
            timerBlockApp.Tick += timerBlockApp_Tick;
            timerBlockApp.Start();
        }

        private void timerBlockApp_Tick(object sender, EventArgs e)
        {
            blockingDuration--;
            labelTimer.Text = "Повторите попытку через: " + TimeSpan.FromMinutes(blockingDuration).ToString(@"hh\:mm");
            if (blockingDuration < 1)
            {
                labelTimer.Visible = false;
                buttonSignIn.Enabled = true;
                ((Timer)sender).Stop();
                blockingDuration = 180;
                labelTimer.Text = "Повторите попытку через: " + countTimer;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countTimer--;
            labelTimer.Text = "Повторите попытку через: " + countTimer;
            if (countTimer < 1)
            {
                labelTimer.Visible = false;
                buttonSignIn.Enabled = true;
                ((Timer)sender).Stop();
                countTimer = 10;
                labelTimer.Text = "Повторите попытку через: " + countTimer;
            }
        }
    }
}
