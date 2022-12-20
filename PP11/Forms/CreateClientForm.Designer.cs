namespace PP11.Forms
{
    partial class CreateClientForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.textBoxSeriesPassport = new System.Windows.Forms.TextBox();
            this.labelSeriesPassport = new System.Windows.Forms.Label();
            this.textBoxNumberPassport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(15, 63);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 28);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(128, 61);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(5, 20, 3, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(220, 35);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(128, 119);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(5, 20, 3, 3);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(220, 35);
            this.textBoxSurname.TabIndex = 4;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(15, 122);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(105, 28);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Фамилия:";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(128, 177);
            this.textBoxPatronymic.Margin = new System.Windows.Forms.Padding(5, 20, 3, 3);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(220, 35);
            this.textBoxPatronymic.TabIndex = 6;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(15, 180);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(106, 28);
            this.labelPatronymic.TabIndex = 5;
            this.labelPatronymic.Text = "Отчество:";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(128, 235);
            this.textBoxAdress.Margin = new System.Windows.Forms.Padding(5, 20, 3, 3);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(220, 35);
            this.textBoxAdress.TabIndex = 8;
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(15, 238);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(76, 28);
            this.labelAdress.TabIndex = 7;
            this.labelAdress.Text = "Адрес:";
            // 
            // textBoxSeriesPassport
            // 
            this.textBoxSeriesPassport.Location = new System.Drawing.Point(564, 60);
            this.textBoxSeriesPassport.Margin = new System.Windows.Forms.Padding(5, 20, 3, 3);
            this.textBoxSeriesPassport.MaxLength = 4;
            this.textBoxSeriesPassport.Name = "textBoxSeriesPassport";
            this.textBoxSeriesPassport.Size = new System.Drawing.Size(220, 35);
            this.textBoxSeriesPassport.TabIndex = 10;
            this.textBoxSeriesPassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberPassport_KeyPress);
            // 
            // labelSeriesPassport
            // 
            this.labelSeriesPassport.AutoSize = true;
            this.labelSeriesPassport.Location = new System.Drawing.Point(380, 63);
            this.labelSeriesPassport.Name = "labelSeriesPassport";
            this.labelSeriesPassport.Size = new System.Drawing.Size(169, 28);
            this.labelSeriesPassport.TabIndex = 9;
            this.labelSeriesPassport.Text = "Серия паспорта:";
            // 
            // textBoxNumberPassport
            // 
            this.textBoxNumberPassport.Location = new System.Drawing.Point(564, 122);
            this.textBoxNumberPassport.Margin = new System.Windows.Forms.Padding(5, 20, 3, 3);
            this.textBoxNumberPassport.MaxLength = 6;
            this.textBoxNumberPassport.Name = "textBoxNumberPassport";
            this.textBoxNumberPassport.Size = new System.Drawing.Size(220, 35);
            this.textBoxNumberPassport.TabIndex = 12;
            this.textBoxNumberPassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberPassport_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Номер паспорта:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Дата рождения:";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(564, 180);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(220, 35);
            this.dateTimePickerDateOfBirth.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(564, 238);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(5, 20, 3, 3);
            this.textBoxEmail.MaxLength = 60;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(220, 35);
            this.textBoxEmail.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Элек. почта:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(336, 318);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 50);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // CreateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumberPassport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSeriesPassport);
            this.Controls.Add(this.labelSeriesPassport);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "CreateClientForm";
            this.Text = "CreateClientForm";
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.textBoxName, 0);
            this.Controls.SetChildIndex(this.labelSurname, 0);
            this.Controls.SetChildIndex(this.textBoxSurname, 0);
            this.Controls.SetChildIndex(this.labelPatronymic, 0);
            this.Controls.SetChildIndex(this.textBoxPatronymic, 0);
            this.Controls.SetChildIndex(this.labelAdress, 0);
            this.Controls.SetChildIndex(this.textBoxAdress, 0);
            this.Controls.SetChildIndex(this.labelSeriesPassport, 0);
            this.Controls.SetChildIndex(this.textBoxSeriesPassport, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBoxNumberPassport, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dateTimePickerDateOfBirth, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBoxEmail, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.TextBox textBoxSeriesPassport;
        private System.Windows.Forms.Label labelSeriesPassport;
        private System.Windows.Forms.TextBox textBoxNumberPassport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
    }
}