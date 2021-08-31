using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpStreamStarter
{
    public partial class StreamingServiceForm : Form
    {
        public StreamingServiceForm()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void streamingServiceButton_click(object sender, EventArgs e)
        {
            string streamingService = streamingServiceTextBox.Text.ToLower();
            switch (streamingService)
            {
                case "twitch":
                    this.Hide();
                    TwitchForm twitchForm = new TwitchForm();
                    twitchForm.MdiParent = this.MdiParent;
                    twitchForm.Show();
                    break;
                case "bbciplayer":
                    this.Hide();
                    BBCIPlayerForm bbcIPlayerForm = new BBCIPlayerForm();
                    bbcIPlayerForm.MdiParent = this.MdiParent;
                    bbcIPlayerForm.Show();
                    break;
                default:
                    this.label1.Show();
                    break;
            }
        }
        private void StreamingServiceForm_SizeChanged(object sender, EventArgs e)
        {
            CenterControlInParent(tableLayoutPanel1);
        }
        private void CenterControlInParent(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 2;
        }

        private void streamingServiceTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label1.Hide();
        }

        private void StreamingServiceForm_Load(object sender, EventArgs e)
        {
            this.label1.Hide();
        }
    }
}
