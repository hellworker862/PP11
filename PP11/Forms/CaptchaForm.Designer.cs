namespace PP11
{
    partial class CaptchaForm
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
            this.pictureBoxCapcha = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapcha)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCapcha
            // 
            this.pictureBoxCapcha.Location = new System.Drawing.Point(12, 62);
            this.pictureBoxCapcha.Name = "pictureBoxCapcha";
            this.pictureBoxCapcha.Size = new System.Drawing.Size(266, 170);
            this.pictureBoxCapcha.TabIndex = 1;
            this.pictureBoxCapcha.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 35);
            this.textBox1.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(12, 302);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(125, 37);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Location = new System.Drawing.Point(153, 302);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(125, 37);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "Ок";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // CapchaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 356);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxCapcha);
            this.Name = "CapchaForm";
            this.Text = "CapchaForm";
            this.Load += new System.EventHandler(this.CapchaForm_Load);
            this.Controls.SetChildIndex(this.pictureBoxCapcha, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.Controls.SetChildIndex(this.buttonCheck, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCapcha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCheck;
    }
}