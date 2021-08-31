
namespace CSharpStreamStarter
{
    partial class TwitchForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.liveRadioButton = new System.Windows.Forms.RadioButton();
            this.vodRadioButton = new System.Windows.Forms.RadioButton();
            this.watchButton = new System.Windows.Forms.Button();
            this.vodLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.qualityTextBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vodSplitContainer = new System.Windows.Forms.SplitContainer();
            this.vodTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.missingVodLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vodSplitContainer)).BeginInit();
            this.vodSplitContainer.Panel1.SuspendLayout();
            this.vodSplitContainer.Panel2.SuspendLayout();
            this.vodSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(3, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(327, 19);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Enter the username of the channel you wish to watch:";
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qualityLabel.Location = new System.Drawing.Point(0, 0);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(55, 19);
            this.qualityLabel.TabIndex = 1;
            this.qualityLabel.Text = "Quality:";
            // 
            // liveRadioButton
            // 
            this.liveRadioButton.AutoSize = true;
            this.liveRadioButton.Checked = true;
            this.liveRadioButton.Location = new System.Drawing.Point(3, 3);
            this.liveRadioButton.Name = "liveRadioButton";
            this.liveRadioButton.Size = new System.Drawing.Size(53, 23);
            this.liveRadioButton.TabIndex = 3;
            this.liveRadioButton.TabStop = true;
            this.liveRadioButton.Text = "Live";
            this.liveRadioButton.UseVisualStyleBackColor = true;
            this.liveRadioButton.CheckedChanged += new System.EventHandler(this.liveRadioButton_CheckedChanged);
            // 
            // vodRadioButton
            // 
            this.vodRadioButton.AutoSize = true;
            this.vodRadioButton.Location = new System.Drawing.Point(62, 3);
            this.vodRadioButton.Name = "vodRadioButton";
            this.vodRadioButton.Size = new System.Drawing.Size(61, 23);
            this.vodRadioButton.TabIndex = 4;
            this.vodRadioButton.Text = "VOD";
            this.vodRadioButton.UseVisualStyleBackColor = true;
            this.vodRadioButton.CheckedChanged += new System.EventHandler(this.vodRadioButton_CheckedChanged);
            // 
            // watchButton
            // 
            this.watchButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.watchButton.Location = new System.Drawing.Point(0, 700);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(1222, 45);
            this.watchButton.TabIndex = 5;
            this.watchButton.Text = "Watch";
            this.watchButton.UseVisualStyleBackColor = true;
            this.watchButton.Click += new System.EventHandler(this.watchButton_click);
            // 
            // vodLabel
            // 
            this.vodLabel.AutoSize = true;
            this.vodLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vodLabel.Location = new System.Drawing.Point(0, 0);
            this.vodLabel.Name = "vodLabel";
            this.vodLabel.Size = new System.Drawing.Size(68, 19);
            this.vodLabel.TabIndex = 6;
            this.vodLabel.Text = "Video ID:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(3, 6);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(607, 26);
            this.usernameTextBox.TabIndex = 8;
            // 
            // qualityTextBox
            // 
            this.qualityTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.qualityTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.qualityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qualityTextBox.Items.AddRange(new object[] {
            "worst",
            "best"});
            this.qualityTextBox.Location = new System.Drawing.Point(0, 0);
            this.qualityTextBox.Name = "qualityTextBox";
            this.qualityTextBox.Size = new System.Drawing.Size(613, 27);
            this.qualityTextBox.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.watchButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 745);
            this.panel1.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.vodSplitContainer, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.missingVodLabel, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1222, 700);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // vodSplitContainer
            // 
            this.vodSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vodSplitContainer.Location = new System.Drawing.Point(3, 318);
            this.vodSplitContainer.Name = "vodSplitContainer";
            // 
            // vodSplitContainer.Panel1
            // 
            this.vodSplitContainer.Panel1.Controls.Add(this.vodLabel);
            // 
            // vodSplitContainer.Panel2
            // 
            this.vodSplitContainer.Panel2.Controls.Add(this.vodTextBox);
            this.vodSplitContainer.Size = new System.Drawing.Size(1216, 99);
            this.vodSplitContainer.SplitterDistance = 599;
            this.vodSplitContainer.TabIndex = 16;
            // 
            // vodTextBox
            // 
            this.vodTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vodTextBox.Location = new System.Drawing.Point(0, 0);
            this.vodTextBox.Name = "vodTextBox";
            this.vodTextBox.Size = new System.Drawing.Size(613, 26);
            this.vodTextBox.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.usernameLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.usernameTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1216, 99);
            this.splitContainer1.SplitterDistance = 599;
            this.splitContainer1.TabIndex = 12;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 108);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.qualityLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.qualityTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(1216, 99);
            this.splitContainer2.SplitterDistance = 599;
            this.splitContainer2.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.liveRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.vodRadioButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 213);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1216, 99);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // missingVodLabel
            // 
            this.missingVodLabel.AutoSize = true;
            this.missingVodLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.missingVodLabel.Location = new System.Drawing.Point(3, 420);
            this.missingVodLabel.Name = "missingVodLabel";
            this.missingVodLabel.Size = new System.Drawing.Size(1216, 280);
            this.missingVodLabel.TabIndex = 18;
            this.missingVodLabel.Text = "label1";
            // 
            // TwitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 745);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TwitchForm";
            this.Text = "Twitch";
            this.Load += new System.EventHandler(this.TwitchForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.vodSplitContainer.Panel1.ResumeLayout(false);
            this.vodSplitContainer.Panel1.PerformLayout();
            this.vodSplitContainer.Panel2.ResumeLayout(false);
            this.vodSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vodSplitContainer)).EndInit();
            this.vodSplitContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.RadioButton liveRadioButton;
        private System.Windows.Forms.RadioButton vodRadioButton;
        private System.Windows.Forms.Button watchButton;
        private System.Windows.Forms.Label vodLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.ComboBox qualityTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox vodTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer vodSplitContainer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label missingVodLabel;
    }
}