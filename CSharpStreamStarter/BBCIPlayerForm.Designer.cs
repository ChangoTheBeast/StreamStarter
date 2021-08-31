
namespace CSharpStreamStarter
{
    partial class BBCIPlayerForm
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
            this.bbcPanel = new System.Windows.Forms.Panel();
            this.watchButton = new System.Windows.Forms.Button();
            this.bbcTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.urlContainer = new System.Windows.Forms.SplitContainer();
            this.channelLabel = new System.Windows.Forms.Label();
            this.channelTextBox = new System.Windows.Forms.TextBox();
            this.liveOrVodContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.liveRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.qualityTextBox = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.bbcPanel.SuspendLayout();
            this.bbcTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlContainer)).BeginInit();
            this.urlContainer.Panel1.SuspendLayout();
            this.urlContainer.Panel2.SuspendLayout();
            this.urlContainer.SuspendLayout();
            this.liveOrVodContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bbcPanel
            // 
            this.bbcPanel.Controls.Add(this.watchButton);
            this.bbcPanel.Controls.Add(this.bbcTableLayout);
            this.bbcPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bbcPanel.Location = new System.Drawing.Point(0, 0);
            this.bbcPanel.Name = "bbcPanel";
            this.bbcPanel.Size = new System.Drawing.Size(1222, 745);
            this.bbcPanel.TabIndex = 0;
            // 
            // watchButton
            // 
            this.watchButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.watchButton.Location = new System.Drawing.Point(0, 700);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(1222, 45);
            this.watchButton.TabIndex = 6;
            this.watchButton.Text = "Watch";
            this.watchButton.UseVisualStyleBackColor = true;
            this.watchButton.Click += new System.EventHandler(this.watchButton_Click);
            // 
            // bbcTableLayout
            // 
            this.bbcTableLayout.ColumnCount = 1;
            this.bbcTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bbcTableLayout.Controls.Add(this.urlContainer, 0, 1);
            this.bbcTableLayout.Controls.Add(this.liveOrVodContainer, 0, 0);
            this.bbcTableLayout.Controls.Add(this.splitContainer1, 0, 2);
            this.bbcTableLayout.Controls.Add(this.errorLabel, 0, 5);
            this.bbcTableLayout.Controls.Add(this.splitContainer2, 0, 3);
            this.bbcTableLayout.Controls.Add(this.splitContainer3, 0, 4);
            this.bbcTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bbcTableLayout.Location = new System.Drawing.Point(0, 0);
            this.bbcTableLayout.Name = "bbcTableLayout";
            this.bbcTableLayout.RowCount = 6;
            this.bbcTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.bbcTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.bbcTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.bbcTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.bbcTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.bbcTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.bbcTableLayout.Size = new System.Drawing.Size(1222, 745);
            this.bbcTableLayout.TabIndex = 0;
            // 
            // errorLabel
            // 
            this.errorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorLabel.Location = new System.Drawing.Point(3, 445);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(1216, 300);
            this.errorLabel.TabIndex = 19;
            this.errorLabel.Text = "label1";
            // 
            // urlContainer
            // 
            this.urlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlContainer.Location = new System.Drawing.Point(3, 92);
            this.urlContainer.Name = "urlContainer";
            // 
            // urlContainer.Panel1
            // 
            this.urlContainer.Panel1.Controls.Add(this.channelLabel);
            // 
            // urlContainer.Panel2
            // 
            this.urlContainer.Panel2.Controls.Add(this.channelTextBox);
            this.urlContainer.Size = new System.Drawing.Size(1216, 83);
            this.urlContainer.SplitterDistance = 599;
            this.urlContainer.TabIndex = 13;
            // 
            // channelLabel
            // 
            this.channelLabel.AutoSize = true;
            this.channelLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.channelLabel.Location = new System.Drawing.Point(0, 0);
            this.channelLabel.Name = "channelLabel";
            this.channelLabel.Size = new System.Drawing.Size(225, 19);
            this.channelLabel.TabIndex = 0;
            this.channelLabel.Text = "Enter the channel you wish to watch";
            // 
            // channelTextBox
            // 
            this.channelTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.channelTextBox.Location = new System.Drawing.Point(0, 0);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(613, 26);
            this.channelTextBox.TabIndex = 8;
            // 
            // liveOrVodContainer
            // 
            this.liveOrVodContainer.Controls.Add(this.liveRadioButton);
            this.liveOrVodContainer.Controls.Add(this.radioButton2);
            this.liveOrVodContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liveOrVodContainer.Location = new System.Drawing.Point(3, 3);
            this.liveOrVodContainer.Name = "liveOrVodContainer";
            this.liveOrVodContainer.Size = new System.Drawing.Size(1216, 83);
            this.liveOrVodContainer.TabIndex = 14;
            // 
            // liveRadioButton
            // 
            this.liveRadioButton.AutoSize = true;
            this.liveRadioButton.Location = new System.Drawing.Point(3, 3);
            this.liveRadioButton.Name = "liveRadioButton";
            this.liveRadioButton.Size = new System.Drawing.Size(77, 23);
            this.liveRadioButton.TabIndex = 0;
            this.liveRadioButton.TabStop = true;
            this.liveRadioButton.Text = "Live TV";
            this.liveRadioButton.UseVisualStyleBackColor = true;
            this.liveRadioButton.CheckedChanged += new System.EventHandler(this.liveRadioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(86, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Video";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 181);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.qualityLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.qualityTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1216, 83);
            this.splitContainer1.SplitterDistance = 599;
            this.splitContainer1.TabIndex = 15;
            // 
            // qualityLabel
            // 
            this.qualityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Location = new System.Drawing.Point(0, 0);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(55, 19);
            this.qualityLabel.TabIndex = 2;
            this.qualityLabel.Text = "Quality:";
            // 
            // qualityTextBox
            // 
            this.qualityTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.qualityTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.qualityTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.qualityTextBox.Items.AddRange(new object[] {
            "worst",
            "best"});
            this.qualityTextBox.Location = new System.Drawing.Point(0, 0);
            this.qualityTextBox.Name = "qualityTextBox";
            this.qualityTextBox.Size = new System.Drawing.Size(613, 27);
            this.qualityTextBox.TabIndex = 11;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 270);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.usernameLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.usernameTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(1216, 83);
            this.splitContainer2.SplitterDistance = 599;
            this.splitContainer2.TabIndex = 20;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 359);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.passwordLabel);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.passwordTextbox);
            this.splitContainer3.Size = new System.Drawing.Size(1216, 83);
            this.splitContainer3.SplitterDistance = 599;
            this.splitContainer3.TabIndex = 21;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.usernameLabel.Location = new System.Drawing.Point(0, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(108, 19);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "BBC Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.passwordLabel.Location = new System.Drawing.Point(0, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(104, 19);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "BBC Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.usernameTextBox.Location = new System.Drawing.Point(0, 0);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(613, 26);
            this.usernameTextBox.TabIndex = 0;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.passwordTextbox.Location = new System.Drawing.Point(0, 0);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(613, 26);
            this.passwordTextbox.TabIndex = 0;
            // 
            // BBCIPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 745);
            this.Controls.Add(this.bbcPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BBCIPlayerForm";
            this.Text = "BBCIPlayer";
            this.Load += new System.EventHandler(this.BBCIPlayerForm_Load);
            this.bbcPanel.ResumeLayout(false);
            this.bbcTableLayout.ResumeLayout(false);
            this.urlContainer.Panel1.ResumeLayout(false);
            this.urlContainer.Panel1.PerformLayout();
            this.urlContainer.Panel2.ResumeLayout(false);
            this.urlContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlContainer)).EndInit();
            this.urlContainer.ResumeLayout(false);
            this.liveOrVodContainer.ResumeLayout(false);
            this.liveOrVodContainer.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bbcPanel;
        private System.Windows.Forms.TableLayoutPanel bbcTableLayout;
        private System.Windows.Forms.Button watchButton;
        private System.Windows.Forms.SplitContainer urlContainer;
        private System.Windows.Forms.Label channelLabel;
        private System.Windows.Forms.TextBox channelTextBox;
        private System.Windows.Forms.FlowLayoutPanel liveOrVodContainer;
        private System.Windows.Forms.RadioButton liveRadioButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.ComboBox qualityTextBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
    }
}