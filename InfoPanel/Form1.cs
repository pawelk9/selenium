using System;
using System.Windows.Forms;

namespace InfoPanel
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
            TopMost = true;
        }

        public void SetMessageText(string text)
        {
            messageLabel.Text = text;
            Refresh();
            Show();
        }

        private void PlaceLowerRight()
        {
            Screen rightmost = Screen.AllScreens[0];
            Left = rightmost.WorkingArea.Right - this.Width;
            Top = rightmost.WorkingArea.Bottom - this.Height;
        }

        private void InfoPanel_Load(object sender, EventArgs e)
        {
            PlaceLowerRight();
        }
    }
}
