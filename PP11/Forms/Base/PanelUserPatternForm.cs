using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PP11.Forms.Base
{
    public partial class PanelUserPatternForm : PatternForm
    {
        private const string imgHref = "..\\..\\imgUser";
        private Timer timerSesstion;
        private int sessionDuration = 600;

        public PanelUserPatternForm()
        {
            InitializeComponent();

            labelFio.Text = CurrentUser.ToString();
            pictureUserImg.ImageLocation = Path.Combine(imgHref, CurrentUser.ImgHref);
            buttonExitUser.BackColor = ColorTwo;
            panelUserInfo.BorderStyle = BorderStyle.FixedSingle;

            timerSesstion = new Timer();
            timerSesstion.Interval = 1000;
            timerSesstion.Tick += timerSesstion_Tick;
            timerSesstion.Start();
        }

        private async void timerSesstion_Tick(object sender, EventArgs e)
        {
            sessionDuration--;
            labelSessionTime.Text = "Сеанс закончится через: " + TimeSpan.FromMinutes(sessionDuration).ToString(@"hh\:mm");

            if (sessionDuration == 300)
            {
                MessageBox.Show("Сеанс закончится через 5 минут", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (sessionDuration < 1)
            {
                if (Owner is AuthorizationForm owner)
                {
                    await owner.BlockApp();
                    owner.Show();
                }

                this.Close();
            }
        }

        private void buttonExitUser_Click(object sender, EventArgs e)
        {
            CurrentUser.Clear();
            Owner.Show();
            this.Close();
        }
    }
}
