using Microsoft.Office.Interop.Word;
using PP11.Data;
using PP11.Forms.Base;
using PP11.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ZXing;
using Task = System.Threading.Tasks.Task;
using Word = Microsoft.Office.Interop.Word;

namespace PP11.Forms
{
    public partial class SalesmanForm : PanelUserPatternForm
    {
        private const int uniqueCode = 123456;
        private const string defaultHrefSave = "..\\..\\Barcode";
        private const string defaultHrefSavePdf = "..\\..\\Pdf";

        private string stringHrefSavePdf = defaultHrefSavePdf;
        private string stringHrefSave = defaultHrefSave;

        int idOrder = -1;
        private decimal sum;
        RepositoryManager repositoryManager;

        BindingList<Service> services;
        BindingList<Client> clients;

        public SalesmanForm()
        {
            InitializeComponent();
            labelHeader.Text = "Панель продавца";
            buttonCreateOrder.Enabled = false;

            repositoryManager = new RepositoryManager();

            textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);

            comboBoxClients.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxClients.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxClients.DropDownHeight = 150;

            comboBoxServices.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxServices.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxServices.DropDownHeight = 150;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private async void SalesmanForm_Load(object sender, EventArgs e)
        {
            idOrder = await repositoryManager.Orders.NewId();

            textBoxId.Text = idOrder.ToString();
            textBoxId.ForeColor = Color.Gray;

            services = new BindingList<Service>((await repositoryManager.Services.GetAll()).ToList());
            clients = new BindingList<Client>((await repositoryManager.Clients.GetAll()).ToList());

            comboBoxServices.DataSource = services;
            comboBoxClients.DataSource = clients;
        }

        private void textBoxId_Leave(object sender, EventArgs e)
        {
            if (textBoxId.Text == String.Empty)
            {
                textBoxId.Text = idOrder.ToString();
                textBoxId.ForeColor = Color.Gray;
            }

            if (int.Parse(textBoxId.Text) < idOrder)
            {
                MessageBox.Show("Номер заказа не может быть меньне " + idOrder);
                labelWarning.ForeColor = Color.Red;
                labelWarning.Text = "Некорректный номер заказа";
                buttonCreateOrder.Enabled = false;
            }
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (int.Parse(textBoxId.Text) >= idOrder)
                {
                    textBoxId.ForeColor = Color.Black;
                    labelWarning.ForeColor = Color.Green;
                    labelWarning.Text = "Номер заказа подтвержден";
                    buttonCreateOrder.Enabled = true;

                    CreateBarcode();
                }
            }
        }

        private void CreateBarcode()
        {
            DateTime dateTime = DateTime.Now;

            string encodeTxt = idOrder.ToString() + dateTime.Year.ToString() + dateTime.Month.ToString() + dateTime.Day.ToString() + dateTime.Hour.ToString() + dateTime.Minute.ToString() + uniqueCode.ToString();
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            pictureBox2.Image = writer.Write(encodeTxt);

            groupBoxBarcode.Enabled = true;
            groupBoxServices.Enabled = true;
            groupBoxClient.Enabled = true;
            textBoxDuration.Enabled = true;
        }

        private async void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedServices.Items.Count < 1)
            {
                MessageBox.Show("Выберите услуги");
                return;
            }

            if (String.IsNullOrWhiteSpace(textBoxDuration.Text))
            {
                MessageBox.Show("Укажите продолжительность аренды");
                return;
            }

            var dateTimeCreate = DateTime.Now;
            int rentalTime = int.Parse(textBoxDuration.Text);

            var newOrder = new Order()
            {
                Id = 0,
                DateTimeCreate = dateTimeCreate,
                ClientId = ((Client)comboBoxClients.SelectedItem).Id,
                StatusId = 1,
                RentalTime = rentalTime,
            };

            int id = await repositoryManager.Orders.Create(newOrder, CurrentUser.Id);
            pictureBox2.Image.Save(Path.Combine(stringHrefSave, $"Заказа №{id}.jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg);
            MessageBox.Show("Заказ создан");

            buttonSaveToPdf.Enabled = true;
            buttonChangeHrefPdf.Enabled = true;
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            var fr = new CreateClientForm();
            fr.Owner = this;
            fr.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            if (comboBoxServices.SelectedIndex == -1) return;

            var selectedService = comboBoxServices.SelectedItem as Service;

            listBoxSelectedServices.Items.Add(selectedService);
            services.Remove(selectedService);

            sum = sum + selectedService.Price;
            labelPrice.Text = "Итог: " + Math.Round(sum, 2);
        }

        private void buttonRemoveService_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedServices.SelectedIndex == -1) return;

            var selectedService = listBoxSelectedServices.SelectedItems[0] as Service;

            listBoxSelectedServices.Items.Remove(selectedService);
            services.Add(selectedService);

            sum = sum - selectedService.Price;
            labelPrice.Text = "Итог: " + Math.Round(sum, 2);
        }

        private void buttonChangeHref_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == DialogResult.OK) stringHrefSave = FBD.SelectedPath;
        }

        internal void AddClientList(Client newClient)
        {
            clients.Add(newClient);
            comboBoxClients.SelectedIndex = clients.Count - 1;
        }

        private async Task UpdateForm()
        {
            var textBoxList = this.FindAllChildrenByType<TextBox>().ToList();
            textBoxList.ForEach(x => x.Text = "");
            pictureBox2.Image = null;
            textBoxDuration.Enabled = false;
            groupBoxBarcode.Enabled = false;
            groupBoxServices.Enabled = false;
            groupBoxClient.Enabled = false;
            buttonCreateOrder.Enabled = false;
            buttonSaveToPdf.Enabled = false;
            buttonChangeHrefPdf.Enabled = false;

            idOrder = await repositoryManager.Orders.NewId();
            textBoxId.Text = idOrder.ToString();
            textBoxId.ForeColor = Color.Gray;
            labelWarning.ForeColor = Color.Red;
            labelWarning.Text = "Подтвердите номер заказа!";
            labelPrice.Text = "Итог:";

            listBoxSelectedServices.Items.Clear();
            services = new BindingList<Service>((await repositoryManager.Services.GetAll()).ToList());
            comboBoxServices.DataSource = services;
        }

        private async void buttonClearForm_Click(object sender, EventArgs e)
        {
            await UpdateForm();
        }

        private void buttonChangeHrefPdf_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == DialogResult.OK) stringHrefSavePdf = FBD.SelectedPath;
        }

        private void buttonSaveToPdf_Click(object sender, EventArgs e)
        {
            Word.Document doc = null;
            Word.Application app = new Word.Application();

            string source = AppDomain.CurrentDomain.BaseDirectory + "pattern.docx";
            doc = app.Documents.Open(source);
            doc.Activate();

            doc.SaveAs2(AppDomain.CurrentDomain.BaseDirectory + @"pattern2.docx");
            doc.Close();
            doc = null;

            doc = app.Documents.Open(AppDomain.CurrentDomain.BaseDirectory + @"pattern2.docx");
            doc.Activate();

            Word.Bookmarks wBookmarks = doc.Bookmarks;
            Word.Range wRange;

            var client = ((Client)comboBoxClients.SelectedItem);

            int i = 0;
            string[] data = new string[4] { $"{idOrder}", $"{DateTime.Now.ToString("f")}", $"{client.Id}", $"{client}" };

            foreach (Word.Bookmark mark in wBookmarks)
            {

                wRange = mark.Range;
                wRange.Text = data[i];
                var d = wRange.InlineShapes;
                i++;
                if (i >= data.Length)
                {
                    break;
                }
            }

            wRange = wBookmarks[5].Range;
            wRange.Text = Math.Round(sum, 2).ToString();

            Word.Range range = app.Selection.Range;
            Object behiavor = Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            Object autoFitBehiavor = Word.WdAutoFitBehavior.wdAutoFitFixed;

            int columns = 2;
            int rows = listBoxSelectedServices.Items.Count;
            doc.Bookmarks.get_Item("s6").Range.Tables.Add(doc.Bookmarks.get_Item("s6").Range, rows + 1, columns, ref behiavor, ref autoFitBehiavor);
            doc.Tables[1].Cell(1, 1).Range.Text = "Наименование";
            doc.Tables[1].Cell(1, 2).Range.Text = "Стоимость";
            for (int j = 0; j < rows; j++)
            {
                doc.Tables[1].Cell(j + 2, 1).Range.Text = ((Service)listBoxSelectedServices.Items[j]).Name;
                doc.Tables[1].Cell(j + 2, 2).Range.Text = Math.Round(((Service)listBoxSelectedServices.Items[j]).Price, 2).ToString();
            }

            doc.SaveAs2(AppDomain.CurrentDomain.BaseDirectory + "test.docx");
            string test = Environment.CurrentDirectory + $"\\Заказ №{idOrder}.pdf";
            doc.SaveAs2(test, WdSaveFormat.wdFormatPDF);
            doc.Close();
            doc = null;

            MessageBox.Show("Чек сохранен");
        }
    }
}
