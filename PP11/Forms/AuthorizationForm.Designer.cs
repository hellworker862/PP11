namespace PP11
{
    partial class AuthorizationForm
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonPasswordShow = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(53, 249);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(241, 35);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(53, 128);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(241, 35);
            this.textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Location = new System.Drawing.Point(119, 363);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(116, 39);
            this.buttonSignIn.TabIndex = 5;
            this.buttonSignIn.Text = "Войти";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonPasswordShow
            // 
            this.buttonPasswordShow.BackgroundImage = global::PP11.Properties.Resources.show;
            this.buttonPasswordShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPasswordShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPasswordShow.Location = new System.Drawing.Point(300, 249);
            this.buttonPasswordShow.Name = "buttonPasswordShow";
            this.buttonPasswordShow.Size = new System.Drawing.Size(35, 35);
            this.buttonPasswordShow.TabIndex = 6;
            this.buttonPasswordShow.UseVisualStyleBackColor = true;
            this.buttonPasswordShow.Click += new System.EventHandler(this.buttonPasswordShow_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(23, 311);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(298, 28);
            this.labelTimer.TabIndex = 7;
            this.labelTimer.Text = "Повторите попытку через: 10";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 414);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonPasswordShow);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPassword);
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.Controls.SetChildIndex(this.textBoxPassword, 0);
            this.Controls.SetChildIndex(this.textBoxName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.buttonSignIn, 0);
            this.Controls.SetChildIndex(this.buttonPasswordShow, 0);
            this.Controls.SetChildIndex(this.labelTimer, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonPasswordShow;
        private System.Windows.Forms.Label labelTimer;
    }
}