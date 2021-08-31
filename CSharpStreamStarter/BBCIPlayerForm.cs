using System;
using System.IO;
using System.Windows.Forms;

namespace CSharpStreamStarter
{
    public partial class BBCIPlayerForm : Form
    {
        public BBCIPlayerForm()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void liveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (liveRadioButton.Checked)
            {
                channelLabel.Text = "Enter the channel you wish to watch:";
            } else
            {
                channelLabel.Text = "Supply the url of the BBCIplayer video you want to watch:";
            }
        }

        private void BBCIPlayerForm_Load(object sender, EventArgs e)
        {
            liveRadioButton.Checked = true;
            channelLabel.Text = "Enter the channel you wish to watch:";
            errorLabel.Hide();
        }

        private void watchButton_Click(object sender, EventArgs e)
        {
            var channel = channelTextBox.Text;
            var quality = qualityTextBox.Text;
            var username = usernameTextBox.Text;
            var password = passwordTextbox.Text;
            var liveOrVod = "false";
            try
            {
                if (channel.Length > 0 && quality.Length > 0)
                {
                    if (liveRadioButton.Checked)
                    {
                        liveOrVod = "live";
                    }
                    if (username.Length > 0 && password.Length > 0)
                    {
                        string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                        dir += "\\batchFiles";
                        Console.WriteLine(dir);
                        System.Diagnostics.Process proc = new System.Diagnostics.Process();
                        proc.StartInfo.FileName = dir + "\\bbc.bat";
                        proc.StartInfo.Arguments = channel + " " + quality + " " + liveOrVod + " " + username + " " + password;
                        proc.StartInfo.WorkingDirectory = dir;
                        proc.Start();
                        Application.Exit();
                    } else
                    {
                        throw new ArgumentNullException("Missing username and/or password.");
                    }
                }
            } catch (ArgumentNullException exception)
            {
                errorLabel.Text = exception.Source;
                errorLabel.Show();
            }
        }
    }
}
