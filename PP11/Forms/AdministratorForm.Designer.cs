namespace PP11.Forms
{
    partial class AdministratorForm
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
            this.tabPageHistoryLogin = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonApplyFilters = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMenu.SuspendLayout();
            this.tabPageHistoryLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageReports.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPageHistoryLogin);
            this.tabControlMenu.Controls.Add(this.tabPageOrders);
            this.tabControlMenu.Controls.Add(this.tabPageReports);
            this.tabControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMenu.Location = new System.Drawing.Point(0, 100);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(1119, 750);
            this.tabControlMenu.TabIndex = 2;
            // 
            // tabPageHistoryLogin
            // 
            this.tabPageHistoryLogin.Controls.Add(this.dataGridView1);
            this.tabPageHistoryLogin.Location = new System.Drawing.Point(4, 37);
            this.tabPageHistoryLogin.Name = "tabPageHistoryLogin";
            this.tabPageHistoryLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistoryLogin.Size = new System.Drawing.Size(1111, 709);
            this.tabPageHistoryLogin.TabIndex = 0;
            this.tabPageHistoryLogin.Text = "История входа";
            this.tabPageHistoryLogin.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1105, 703);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Controls.Add(this.dataGridView2);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 37);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(1111, 709);
            this.tabPageOrders.TabIndex = 1;
            this.tabPageOrders.Text = "Заказы";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1105, 703);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPageReports
            // 
            this.tabPageReports.Controls.Add(this.panelContainer);
            this.tabPageReports.Controls.Add(this.groupBox1);
            this.tabPageReports.Location = new System.Drawing.Point(4, 37);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReports.Size = new System.Drawing.Size(1111, 709);
            this.tabPageReports.TabIndex = 2;
            this.tabPageReports.Text = "Отчёты";
            this.tabPageReports.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(3, 161);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1105, 545);
            this.panelContainer.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonApplyFilters);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1105, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(849, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Скачать в pdf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonApplyFilters
            // 
            this.buttonApplyFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplyFilters.Location = new System.Drawing.Point(585, 100);
            this.buttonApplyFilters.Name = "buttonApplyFilters";
            this.buttonApplyFilters.Size = new System.Drawing.Size(241, 42);
            this.buttonApplyFilters.TabIndex = 11;
            this.buttonApplyFilters.Text = "Применить фильтры";
            this.buttonApplyFilters.UseVisualStyleBackColor = true;
            this.buttonApplyFilters.Click += new System.EventHandler(this.buttonApplyFilters_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(349, 105);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(210, 32);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.Text = "Таблица и график";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(224, 105);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 32);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "График";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(88, 105);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 32);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Таблица";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Вид:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(827, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "по";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(883, 43);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(207, 35);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(596, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 35);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Период: с";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(383, 36);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип:";
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 850);
            this.Controls.Add(this.tabControlMenu);
            this.Name = "AdministratorForm";
            this.Text = "AdministratorForm";
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.Controls.SetChildIndex(this.tabControlMenu, 0);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageHistoryLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageReports.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageHistoryLogin;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button buttonApplyFilters;
        private System.Windows.Forms.Button button1;
    }
}