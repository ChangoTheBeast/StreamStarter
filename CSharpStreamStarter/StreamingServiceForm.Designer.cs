
namespace CSharpStreamStarter
{
    partial class StreamingServiceForm
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
            this.streamingServiceTextBox = new System.Windows.Forms.ComboBox();
            this.streamingServiceLabel = new System.Windows.Forms.Label();
            this.streamingServiceButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // streamingServiceTextBox
            // 
            this.streamingServiceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streamingServiceTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.streamingServiceTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.streamingServiceTextBox.Items.AddRange(new object[] {
            "Twitch",
            "BBCIplayer",
            "YouTube"});
            this.streamingServiceTextBox.Location = new System.Drawing.Point(3, 8);
            this.streamingServiceTextBox.Name = "streamingServiceTextBox";
            this.streamingServiceTextBox.Size = new System.Drawing.Size(326, 27);
            this.streamingServiceTextBox.TabIndex = 0;
            this.streamingServiceTextBox.SelectedIndexChanged += new System.EventHandler(this.streamingServiceTextBox_SelectedIndexChanged);
            // 
            // streamingServiceLabel
            // 
            this.streamingServiceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streamingServiceLabel.AutoSize = true;
            this.streamingServiceLabel.Location = new System.Drawing.Point(3, 11);
            this.streamingServiceLabel.Name = "streamingServiceLabel";
            this.streamingServiceLabel.Size = new System.Drawing.Size(121, 19);
            this.streamingServiceLabel.TabIndex = 1;
            this.streamingServiceLabel.Text = "Streaming Service:";
            // 
            // streamingServiceButton
            // 
            this.streamingServiceButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.streamingServiceButton.Location = new System.Drawing.Point(3, 215);
            this.streamingServiceButton.Name = "streamingServiceButton";
            this.streamingServiceButton.Size = new System.Drawing.Size(648, 31);
            this.streamingServiceButton.TabIndex = 2;
            this.streamingServiceButton.Text = "Next";
            this.streamingServiceButton.UseVisualStyleBackColor = true;
            this.streamingServiceButton.Click += new System.EventHandler(this.streamingServiceButton_click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.streamingServiceButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(292, 232);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 249);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.streamingServiceLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.streamingServiceTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(648, 118);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unknown Streaming Service Entered";
            // 
            // StreamingServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 745);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StreamingServiceForm";
            this.Text = "Stream Starter";
            this.Load += new System.EventHandler(this.StreamingServiceForm_Load);
            this.SizeChanged += new System.EventHandler(this.StreamingServiceForm_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox streamingServiceTextBox;
        private System.Windows.Forms.Label streamingServiceLabel;
        private System.Windows.Forms.Button streamingServiceButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
    }
}

