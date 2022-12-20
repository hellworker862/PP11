using PP11.Data;
using PP11.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP11.Forms
{
    public partial class CreateClientForm : PatternForm
    {
        private RepositoryManager repositoryManager;

        public CreateClientForm()
        {
            InitializeComponent();

            labelHeader.Text = "Создание клиента";
            repositoryManager = new RepositoryManager();
        }

        internal override void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxName.Text)
               || String.IsNullOrWhiteSpace(textBoxSurname.Text)
               || String.IsNullOrWhiteSpace(textBoxPatronymic.Text)
               || String.IsNullOrWhiteSpace(textBoxAdress.Text)
               || String.IsNullOrWhiteSpace(textBoxSeriesPassport.Text)
               || String.IsNullOrWhiteSpace(textBoxNumberPassport.Text)
               || String.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            var newClient = new Client()
            {
                Id = 0,
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                Patronymic = textBoxPatronymic.Text,
                Adress = textBoxAdress.Text,
                Email = textBoxEmail.Text,
                SeriesPassport = int.Parse(textBoxSeriesPassport.Text),
                NumberPassport = int.Parse(textBoxNumberPassport.Text),
                BirthOfDate = dateTimePickerDateOfBirth.Value,
            };

            newClient.Id = await repositoryManager.Clients.Create(newClient);

            if (Owner is SalesmanForm)
            {
                ((SalesmanForm)Owner).AddClientList(newClient);
            }
            else
            {
                //((AdministratorForm)Owner).AddClientList(newClient);
            }

            Close();
        }

        private void textBoxNumberPassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
