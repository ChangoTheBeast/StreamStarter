using System;
using System.IO;
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
    public partial class TwitchForm : Form
    {
        public TwitchForm()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void liveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (liveRadioButton.Checked)
            {
                this.vodSplitContainer.Hide();
            }
        }

        private void vodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (liveRadioButton.Checked)
            {
                this.vodSplitContainer.Show();
            }
        }

        private void watchButton_click(object sender, EventArgs e)
        {
            var username = this.usernameTextBox.Text;
            var quality = this.qualityTextBox.Text;
            var liveOrVod = "";
            try
            {
                if (username.Length > 0 && quality.Length > 0)
                {
                    if (liveRadioButton.Checked)
                    {
                        liveOrVod = "live";

                    }
                    else
                    {
                        if (this.vodTextBox.Text.Length > 0)
                        {
                            liveOrVod = vodTextBox.Text;
                        }
                        else
                        {
                            throw new ArgumentNullException("Missing video id for VOD");
                        }
                    }

                    string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                    dir += "\\batchFiles";
                    Console.WriteLine(dir);
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.StartInfo.FileName = dir + "\\twitch.bat";
                    proc.StartInfo.Arguments = username + " " + quality + " " + liveOrVod;
                    proc.StartInfo.WorkingDirectory = dir;
                    proc.Start();
                    Application.Exit();
                }
                else
                {
                    throw new ArgumentNullException("Missing Username and/or quality");
                }
            }
            catch (ArgumentNullException exception)
            {
                missingVodLabel.Text = exception.Source;
                missingVodLabel.Show();
            }
        }

        private void TwitchForm_Load(object sender, EventArgs e)
        {
            this.liveRadioButton.Checked = true;
            this.vodSplitContainer.Hide();
            this.missingVodLabel.Hide();
        }

        
    }
}
