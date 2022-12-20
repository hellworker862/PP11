namespace PP11.Forms
{
    partial class SeniorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageNewOrder = new System.Windows.Forms.TabPage();
            this.buttonClearForm = new System.Windows.Forms.Button();
            this.buttonChangeHrefPdf = new System.Windows.Forms.Button();
            this.buttonSaveToPdf = new System.Windows.Forms.Button();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.groupBoxServices = new System.Windows.Forms.GroupBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.listBoxSelectedServices = new System.Windows.Forms.ListBox();
            this.buttonRemoveService = new System.Windows.Forms.Button();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.comboBoxServices = new System.Windows.Forms.ComboBox();
            this.groupBoxBarcode = new System.Windows.Forms.GroupBox();
            this.buttonChangeHref = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelWarning = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAcceptOrder = new System.Windows.Forms.TabPage();
            this.buttonAcceptOrder = new System.Windows.Forms.Button();
            this.buttonSelectImage = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControlMenu.SuspendLayout();
            this.tabPageNewOrder.SuspendLayout();
            this.groupBoxClient.SuspendLayout();
            this.groupBoxServices.SuspendLayout();
            this.groupBoxBarcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPageAcceptOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPageNewOrder);
            this.tabControlMenu.Controls.Add(this.tabPageAcceptOrder);
            this.tabControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMenu.Location = new System.Drawing.Point(0, 100);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(900, 750);
            this.tabControlMenu.TabIndex = 4;
            this.tabControlMenu.TabStop = false;
            // 
            // tabPageNewOrder
            // 
            this.tabPageNewOrder.Controls.Add(this.buttonClearForm);
            this.tabPageNewOrder.Controls.Add(this.buttonChangeHrefPdf);
            this.tabPageNewOrder.Controls.Add(this.buttonSaveToPdf);
            this.tabPageNewOrder.Controls.Add(this.buttonCreateOrder);
            this.tabPageNewOrder.Controls.Add(this.textBoxDuration);
            this.tabPageNewOrder.Controls.Add(this.label2);
            this.tabPageNewOrder.Controls.Add(this.groupBoxClient);
            this.tabPageNewOrder.Controls.Add(this.groupBoxServices);
            this.tabPageNewOrder.Controls.Add(this.groupBoxBarcode);
            this.tabPageNewOrder.Controls.Add(this.labelWarning);
            this.tabPageNewOrder.Controls.Add(this.textBoxId);
            this.tabPageNewOrder.Controls.Add(this.label1);
            this.tabPageNewOrder.Location = new System.Drawing.Point(4, 37);
            this.tabPageNewOrder.Name = "tabPageNewOrder";
            this.tabPageNewOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewOrder.Size = new System.Drawing.Size(892, 709);
            this.tabPageNewOrder.TabIndex = 0;
            this.tabPageNewOrder.Text = "Новый заказ";
            this.tabPageNewOrder.UseVisualStyleBackColor = true;
            // 
            // buttonClearForm
            // 
            this.buttonClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearForm.Location = new System.Drawing.Point(652, 645);
            this.buttonClearForm.Name = "buttonClearForm";
            this.buttonClearForm.Size = new System.Drawing.Size(190, 40);
            this.buttonClearForm.TabIndex = 15;
            this.buttonClearForm.Text = "Очистить форму";
            this.buttonClearForm.UseVisualStyleBackColor = true;
            this.buttonClearForm.Click += new System.EventHandler(this.buttonClearForm_Click);
            // 
            // buttonChangeHrefPdf
            // 
            this.buttonChangeHrefPdf.Enabled = false;
            this.buttonChangeHrefPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeHrefPdf.Location = new System.Drawing.Point(466, 645);
            this.buttonChangeHrefPdf.Name = "buttonChangeHrefPdf";
            this.buttonChangeHrefPdf.Size = new System.Drawing.Size(170, 40);
            this.buttonChangeHrefPdf.TabIndex = 14;
            this.buttonChangeHrefPdf.Text = "Изменить путь";
            this.buttonChangeHrefPdf.UseVisualStyleBackColor = true;
            this.buttonChangeHrefPdf.Click += new System.EventHandler(this.buttonChangeHrefPdf_Click);
            // 
            // buttonSaveToPdf
            // 
            this.buttonSaveToPdf.Enabled = false;
            this.buttonSaveToPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveToPdf.Location = new System.Drawing.Point(260, 645);
            this.buttonSaveToPdf.Name = "buttonSaveToPdf";
            this.buttonSaveToPdf.Size = new System.Drawing.Size(190, 40);
            this.buttonSaveToPdf.TabIndex = 13;
            this.buttonSaveToPdf.Text = "Сохранить в PDF";
            this.buttonSaveToPdf.UseVisualStyleBackColor = true;
            this.buttonSaveToPdf.Click += new System.EventHandler(this.buttonSaveToPdf_Click);
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateOrder.Location = new System.Drawing.Point(54, 645);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(190, 40);
            this.buttonCreateOrder.TabIndex = 12;
            this.buttonCreateOrder.Text = "Оформить заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Enabled = false;
            this.textBoxDuration.Location = new System.Drawing.Point(243, 456);
            this.textBoxDuration.MaxLength = 2;
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 35);
            this.textBoxDuration.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 459);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 30, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Продолжительность:";
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.buttonAddClient);
            this.groupBoxClient.Controls.Add(this.comboBoxClients);
            this.groupBoxClient.Enabled = false;
            this.groupBoxClient.Location = new System.Drawing.Point(20, 538);
            this.groupBoxClient.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(852, 85);
            this.groupBoxClient.TabIndex = 6;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Клиент";
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddClient.Location = new System.Drawing.Point(356, 32);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(200, 40);
            this.buttonAddClient.TabIndex = 7;
            this.buttonAddClient.Text = "Добавить клиента";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(23, 34);
            this.comboBoxClients.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(300, 36);
            this.comboBoxClients.TabIndex = 7;
            // 
            // groupBoxServices
            // 
            this.groupBoxServices.Controls.Add(this.labelPrice);
            this.groupBoxServices.Controls.Add(this.listBoxSelectedServices);
            this.groupBoxServices.Controls.Add(this.buttonRemoveService);
            this.groupBoxServices.Controls.Add(this.buttonAddService);
            this.groupBoxServices.Controls.Add(this.comboBoxServices);
            this.groupBoxServices.Enabled = false;
            this.groupBoxServices.Location = new System.Drawing.Point(412, 78);
            this.groupBoxServices.Margin = new System.Windows.Forms.Padding(7, 10, 15, 5);
            this.groupBoxServices.Name = "groupBoxServices";
            this.groupBoxServices.Size = new System.Drawing.Size(460, 459);
            this.groupBoxServices.TabIndex = 5;
            this.groupBoxServices.TabStop = false;
            this.groupBoxServices.Text = "Услуги";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(8, 414);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(63, 28);
            this.labelPrice.TabIndex = 10;
            this.labelPrice.Text = "Итог:";
            // 
            // listBoxSelectedServices
            // 
            this.listBoxSelectedServices.FormattingEnabled = true;
            this.listBoxSelectedServices.ItemHeight = 28;
            this.listBoxSelectedServices.Location = new System.Drawing.Point(13, 158);
            this.listBoxSelectedServices.Name = "listBoxSelectedServices";
            this.listBoxSelectedServices.Size = new System.Drawing.Size(434, 284);
            this.listBoxSelectedServices.TabIndex = 9;
            // 
            // buttonRemoveService
            // 
            this.buttonRemoveService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveService.Location = new System.Drawing.Point(146, 102);
            this.buttonRemoveService.Name = "buttonRemoveService";
            this.buttonRemoveService.Size = new System.Drawing.Size(115, 40);
            this.buttonRemoveService.TabIndex = 8;
            this.buttonRemoveService.Text = "Удалить";
            this.buttonRemoveService.UseVisualStyleBackColor = true;
            this.buttonRemoveService.Click += new System.EventHandler(this.buttonRemoveService_Click);
            // 
            // buttonAddService
            // 
            this.buttonAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddService.Location = new System.Drawing.Point(13, 102);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(115, 40);
            this.buttonAddService.TabIndex = 7;
            this.buttonAddService.Text = "Добавить";
            this.buttonAddService.UseVisualStyleBackColor = true;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Location = new System.Drawing.Point(13, 49);
            this.comboBoxServices.Margin = new System.Windows.Forms.Padding(10, 20, 3, 3);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(434, 36);
            this.comboBoxServices.TabIndex = 0;
            // 
            // groupBoxBarcode
            // 
            this.groupBoxBarcode.Controls.Add(this.buttonChangeHref);
            this.groupBoxBarcode.Controls.Add(this.pictureBox2);
            this.groupBoxBarcode.Enabled = false;
            this.groupBoxBarcode.Location = new System.Drawing.Point(20, 78);
            this.groupBoxBarcode.Margin = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.groupBoxBarcode.Name = "groupBoxBarcode";
            this.groupBoxBarcode.Size = new System.Drawing.Size(375, 337);
            this.groupBoxBarcode.TabIndex = 4;
            this.groupBoxBarcode.TabStop = false;
            this.groupBoxBarcode.Text = "Штрих-код";
            // 
            // buttonChangeHref
            // 
            this.buttonChangeHref.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeHref.Location = new System.Drawing.Point(31, 274);
            this.buttonChangeHref.Name = "buttonChangeHref";
            this.buttonChangeHref.Size = new System.Drawing.Size(320, 40);
            this.buttonChangeHref.TabIndex = 5;
            this.buttonChangeHref.Text = "Изменить путь";
            this.buttonChangeHref.UseVisualStyleBackColor = true;
            this.buttonChangeHref.Click += new System.EventHandler(this.buttonChangeHref_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(55, 72);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(332, 33);
            this.labelWarning.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(275, 28);
            this.labelWarning.TabIndex = 2;
            this.labelWarning.Text = "Подтвердите номер заказа!";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(169, 30);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(150, 35);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBoxId.Leave += new System.EventHandler(this.textBoxId_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 30, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер заказа:";
            // 
            // tabPageAcceptOrder
            // 
            this.tabPageAcceptOrder.Controls.Add(this.buttonAcceptOrder);
            this.tabPageAcceptOrder.Controls.Add(this.buttonSelectImage);
            this.tabPageAcceptOrder.Controls.Add(this.pictureBox3);
            this.tabPageAcceptOrder.Location = new System.Drawing.Point(4, 37);
            this.tabPageAcceptOrder.Name = "tabPageAcceptOrder";
            this.tabPageAcceptOrder.Size = new System.Drawing.Size(892, 709);
            this.tabPageAcceptOrder.TabIndex = 1;
            this.tabPageAcceptOrder.Text = "Принять заказ";
            this.tabPageAcceptOrder.UseVisualStyleBackColor = true;
            // 
            // buttonAcceptOrder
            // 
            this.buttonAcceptOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcceptOrder.Location = new System.Drawing.Point(537, 181);
            this.buttonAcceptOrder.Name = "buttonAcceptOrder";
            this.buttonAcceptOrder.Size = new System.Drawing.Size(253, 54);
            this.buttonAcceptOrder.TabIndex = 2;
            this.buttonAcceptOrder.Text = "Принять заказ";
            this.buttonAcceptOrder.UseVisualStyleBackColor = true;
            this.buttonAcceptOrder.Click += new System.EventHandler(this.buttonAcceptOrder_Click);
            // 
            // buttonSelectImage
            // 
            this.buttonSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectImage.Location = new System.Drawing.Point(537, 89);
            this.buttonSelectImage.Name = "buttonSelectImage";
            this.buttonSelectImage.Size = new System.Drawing.Size(253, 54);
            this.buttonSelectImage.TabIndex = 1;
            this.buttonSelectImage.Text = "Выбрать изображение";
            this.buttonSelectImage.UseVisualStyleBackColor = true;
            this.buttonSelectImage.Click += new System.EventHandler(this.buttonSelectImage_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(24, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(421, 273);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // SeniorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 850);
            this.Controls.Add(this.tabControlMenu);
            this.Name = "SeniorForm";
            this.Text = "SeniorForm";
            this.Load += new System.EventHandler(this.SalesmanForm_Load);
            this.Controls.SetChildIndex(this.tabControlMenu, 0);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageNewOrder.ResumeLayout(false);
            this.tabPageNewOrder.PerformLayout();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxServices.ResumeLayout(false);
            this.groupBoxServices.PerformLayout();
            this.groupBoxBarcode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPageAcceptOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageNewOrder;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.GroupBox groupBoxServices;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ListBox listBoxSelectedServices;
        private System.Windows.Forms.Button buttonRemoveService;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.ComboBox comboBoxServices;
        private System.Windows.Forms.GroupBox groupBoxBarcode;
        private System.Windows.Forms.Button buttonChangeHref;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageAcceptOrder;
        private System.Windows.Forms.Button buttonAcceptOrder;
        private System.Windows.Forms.Button buttonSelectImage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonClearForm;
        private System.Windows.Forms.Button buttonChangeHrefPdf;
        private System.Windows.Forms.Button buttonSaveToPdf;
        private System.Windows.Forms.Button buttonCreateOrder;
    }
}