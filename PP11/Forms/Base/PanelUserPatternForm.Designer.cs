namespace PP11.Forms.Base
{
    partial class PanelUserPatternForm
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
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.buttonExitUser = new System.Windows.Forms.Button();
            this.labelSessionTime = new System.Windows.Forms.Label();
            this.labelFio = new System.Windows.Forms.Label();
            this.pictureUserImg = new System.Windows.Forms.PictureBox();
            this.panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUserImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelUserInfo.BackColor = System.Drawing.Color.White;
            this.panelUserInfo.Controls.Add(this.buttonExitUser);
            this.panelUserInfo.Controls.Add(this.labelSessionTime);
            this.panelUserInfo.Controls.Add(this.labelFio);
            this.panelUserInfo.Controls.Add(this.pictureUserImg);
            this.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserInfo.Location = new System.Drawing.Point(0, 40);
            this.panelUserInfo.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Padding = new System.Windows.Forms.Padding(1);
            this.panelUserInfo.Size = new System.Drawing.Size(800, 60);
            this.panelUserInfo.TabIndex = 1;
            // 
            // buttonExitUser
            // 
            this.buttonExitUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitUser.Location = new System.Drawing.Point(12, 10);
            this.buttonExitUser.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buttonExitUser.Name = "buttonExitUser";
            this.buttonExitUser.Size = new System.Drawing.Size(85, 40);
            this.buttonExitUser.TabIndex = 5;
            this.buttonExitUser.Text = "Выйти";
            this.buttonExitUser.UseVisualStyleBackColor = true;
            this.buttonExitUser.Click += new System.EventHandler(this.buttonExitUser_Click);
            // 
            // labelSessionTime
            // 
            this.labelSessionTime.AutoSize = true;
            this.labelSessionTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelSessionTime.Location = new System.Drawing.Point(366, 1);
            this.labelSessionTime.Name = "labelSessionTime";
            this.labelSessionTime.Padding = new System.Windows.Forms.Padding(0, 20, 30, 0);
            this.labelSessionTime.Size = new System.Drawing.Size(329, 48);
            this.labelSessionTime.TabIndex = 4;
            this.labelSessionTime.Text = "Сеанс закончится через: 10:00";
            // 
            // labelFio
            // 
            this.labelFio.AutoSize = true;
            this.labelFio.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelFio.Location = new System.Drawing.Point(695, 1);
            this.labelFio.Name = "labelFio";
            this.labelFio.Padding = new System.Windows.Forms.Padding(0, 20, 5, 0);
            this.labelFio.Size = new System.Drawing.Size(44, 48);
            this.labelFio.TabIndex = 3;
            this.labelFio.Text = "fio";
            // 
            // pictureUserImg
            // 
            this.pictureUserImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureUserImg.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureUserImg.Location = new System.Drawing.Point(739, 1);
            this.pictureUserImg.Name = "pictureUserImg";
            this.pictureUserImg.Size = new System.Drawing.Size(60, 58);
            this.pictureUserImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUserImg.TabIndex = 2;
            this.pictureUserImg.TabStop = false;
            // 
            // PanelUserPatternForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.panelUserInfo);
            this.Name = "PanelUserPatternForm";
            this.Text = "PanelUserPatternForm";
            this.Controls.SetChildIndex(this.panelUserInfo, 0);
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUserImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.PictureBox pictureUserImg;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.Label labelSessionTime;
        private System.Windows.Forms.Button buttonExitUser;
    }
}