using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PP11.Forms.Base;

namespace PP11
{
    public partial class PatternForm : Form
    {
        public readonly Color ColorOne = Color.FromArgb(118, 227, 131);
        public readonly Color ColorTwo = Color.FromArgb(73, 140, 81);

        public PatternForm()
        {
            InitializeComponent();

            panelHeader.BackColor = ColorOne;
        }

        internal virtual void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            panelHeader.Capture = false;
            labelHeader.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void PatternForm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.DarkGray, ButtonBorderStyle.Solid);
        }

        private void PatternForm_Load(object sender, EventArgs e)
        {
            List<Button> buttons = this.FindAllChildrenByType<Button>().ToList();
            buttons.ForEach(x => x.BackColor = ColorTwo);

            buttonMin.FlatAppearance.BorderSize = 0;
            buttonMin.FlatStyle = FlatStyle.Flat;
            buttonMin.BackColor = ColorOne;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.BackColor = Color.Red;
        }
    }
}
