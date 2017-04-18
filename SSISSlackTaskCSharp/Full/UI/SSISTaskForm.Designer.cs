namespace SSISSlackTaskCSharp.SSIS.SlackTaskUI
{
    partial class SSISTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSISTaskForm));
            this.label1 = new System.Windows.Forms.Label();
            this.SimpleMessageTextBox = new System.Windows.Forms.TextBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SlackMessageJsonTextBox = new System.Windows.Forms.TextBox();
            this.AttachmentsGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WebHookUrlTextBox = new System.Windows.Forms.TextBox();
            this.TestButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AttachmentFieldsGridView = new System.Windows.Forms.DataGridView();
            this.ChannelTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ResponseTextBox = new System.Windows.Forms.TextBox();
            this.colPreText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitleLinkUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorLing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthorIconUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImageUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThumbUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFooter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFooterUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFieldTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFieldValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShort = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentFieldsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple Message";
            // 
            // SimpleMessageTextBox
            // 
            this.SimpleMessageTextBox.Location = new System.Drawing.Point(18, 121);
            this.SimpleMessageTextBox.Multiline = true;
            this.SimpleMessageTextBox.Name = "SimpleMessageTextBox";
            this.SimpleMessageTextBox.Size = new System.Drawing.Size(641, 66);
            this.SimpleMessageTextBox.TabIndex = 1;
            // 
            // DoneButton
            // 
            this.DoneButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DoneButton.Location = new System.Drawing.Point(500, 673);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 2;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message as JSON";
            // 
            // SlackMessageJsonTextBox
            // 
            this.SlackMessageJsonTextBox.Location = new System.Drawing.Point(19, 208);
            this.SlackMessageJsonTextBox.Multiline = true;
            this.SlackMessageJsonTextBox.Name = "SlackMessageJsonTextBox";
            this.SlackMessageJsonTextBox.Size = new System.Drawing.Size(640, 122);
            this.SlackMessageJsonTextBox.TabIndex = 4;
            // 
            // AttachmentsGridView
            // 
            this.AttachmentsGridView.AllowUserToOrderColumns = true;
            this.AttachmentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.AttachmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttachmentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPreText,
            this.col,
            this.colColor,
            this.coltitle,
            this.colTitleLinkUrl,
            this.colText,
            this.colAuthorName,
            this.colAuthorLing,
            this.colAuthorIconUrl,
            this.colImageUrl,
            this.colThumbUrl,
            this.colFooter,
            this.colFooterUrl,
            this.colTimeStamp});
            this.AttachmentsGridView.Location = new System.Drawing.Point(19, 349);
            this.AttachmentsGridView.MultiSelect = false;
            this.AttachmentsGridView.Name = "AttachmentsGridView";
            this.AttachmentsGridView.Size = new System.Drawing.Size(640, 150);
            this.AttachmentsGridView.TabIndex = 5;
            this.AttachmentsGridView.SelectionChanged += new System.EventHandler(this.AttachmentsGridView_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Attachements";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Web Hook Url";
            // 
            // WebHookUrlTextBox
            // 
            this.WebHookUrlTextBox.Location = new System.Drawing.Point(19, 31);
            this.WebHookUrlTextBox.Name = "WebHookUrlTextBox";
            this.WebHookUrlTextBox.Size = new System.Drawing.Size(641, 20);
            this.WebHookUrlTextBox.TabIndex = 1;
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(419, 673);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 2;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Attachements Fields";
            // 
            // AttachmentFieldsGridView
            // 
            this.AttachmentFieldsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttachmentFieldsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFieldTitle,
            this.colFieldValue,
            this.colShort});
            this.AttachmentFieldsGridView.Location = new System.Drawing.Point(19, 535);
            this.AttachmentFieldsGridView.Name = "AttachmentFieldsGridView";
            this.AttachmentFieldsGridView.Size = new System.Drawing.Size(640, 94);
            this.AttachmentFieldsGridView.TabIndex = 6;
            // 
            // ChannelTextBox
            // 
            this.ChannelTextBox.Location = new System.Drawing.Point(19, 76);
            this.ChannelTextBox.Name = "ChannelTextBox";
            this.ChannelTextBox.Size = new System.Drawing.Size(148, 20);
            this.ChannelTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Channel";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(173, 76);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(148, 20);
            this.UserTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "User";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(581, 673);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ResponseTextBox
            // 
            this.ResponseTextBox.Location = new System.Drawing.Point(20, 635);
            this.ResponseTextBox.Multiline = true;
            this.ResponseTextBox.Name = "ResponseTextBox";
            this.ResponseTextBox.Size = new System.Drawing.Size(641, 32);
            this.ResponseTextBox.TabIndex = 12;
            // 
            // colPreText
            // 
            this.colPreText.DataPropertyName = "PreText";
            this.colPreText.HeaderText = "PreText";
            this.colPreText.Name = "colPreText";
            this.colPreText.Width = 67;
            // 
            // col
            // 
            this.col.DataPropertyName = "Fallaback";
            this.col.HeaderText = "FallBack";
            this.col.Name = "col";
            this.col.Width = 71;
            // 
            // colColor
            // 
            this.colColor.DataPropertyName = "Color";
            this.colColor.HeaderText = "Color";
            this.colColor.Name = "colColor";
            this.colColor.Width = 54;
            // 
            // coltitle
            // 
            this.coltitle.DataPropertyName = "Title";
            this.coltitle.HeaderText = "Title";
            this.coltitle.Name = "coltitle";
            this.coltitle.Width = 50;
            // 
            // colTitleLinkUrl
            // 
            this.colTitleLinkUrl.DataPropertyName = "TitleLinkUrl";
            this.colTitleLinkUrl.HeaderText = "Title Link Url";
            this.colTitleLinkUrl.Name = "colTitleLinkUrl";
            this.colTitleLinkUrl.Width = 89;
            // 
            // colText
            // 
            this.colText.DataPropertyName = "Text";
            this.colText.HeaderText = "Text";
            this.colText.Name = "colText";
            this.colText.Width = 51;
            // 
            // colAuthorName
            // 
            this.colAuthorName.DataPropertyName = "AuthorName";
            this.colAuthorName.HeaderText = "Author Name";
            this.colAuthorName.Name = "colAuthorName";
            this.colAuthorName.Width = 92;
            // 
            // colAuthorLing
            // 
            this.colAuthorLing.DataPropertyName = "AuthorLink";
            this.colAuthorLing.HeaderText = "Author Link";
            this.colAuthorLing.Name = "colAuthorLing";
            this.colAuthorLing.Width = 84;
            // 
            // colAuthorIconUrl
            // 
            this.colAuthorIconUrl.DataPropertyName = "AuthorLinkUrl";
            this.colAuthorIconUrl.HeaderText = "Author Icon Url";
            this.colAuthorIconUrl.Name = "colAuthorIconUrl";
            this.colAuthorIconUrl.Width = 81;
            // 
            // colImageUrl
            // 
            this.colImageUrl.DataPropertyName = "ImageUrl";
            this.colImageUrl.HeaderText = "Image Url";
            this.colImageUrl.Name = "colImageUrl";
            this.colImageUrl.Width = 69;
            // 
            // colThumbUrl
            // 
            this.colThumbUrl.DataPropertyName = "ThumbUrl";
            this.colThumbUrl.HeaderText = "Thumb Url";
            this.colThumbUrl.Name = "colThumbUrl";
            this.colThumbUrl.Width = 73;
            // 
            // colFooter
            // 
            this.colFooter.DataPropertyName = "Footer";
            this.colFooter.HeaderText = "Footer";
            this.colFooter.Name = "colFooter";
            this.colFooter.Width = 60;
            // 
            // colFooterUrl
            // 
            this.colFooterUrl.DataPropertyName = "FooterUrl";
            this.colFooterUrl.HeaderText = "Footer Url";
            this.colFooterUrl.Name = "colFooterUrl";
            this.colFooterUrl.Width = 70;
            // 
            // colTimeStamp
            // 
            this.colTimeStamp.DataPropertyName = "TimeStamp";
            this.colTimeStamp.HeaderText = "Time Stamp";
            this.colTimeStamp.Name = "colTimeStamp";
            this.colTimeStamp.Width = 79;
            // 
            // colFieldTitle
            // 
            this.colFieldTitle.DataPropertyName = "Title";
            this.colFieldTitle.HeaderText = "Title";
            this.colFieldTitle.Name = "colFieldTitle";
            // 
            // colFieldValue
            // 
            this.colFieldValue.DataPropertyName = "Value";
            this.colFieldValue.HeaderText = "Field Value";
            this.colFieldValue.Name = "colFieldValue";
            // 
            // colShort
            // 
            this.colShort.DataPropertyName = "Short";
            this.colShort.HeaderText = "Show in Short";
            this.colShort.Name = "colShort";
            // 
            // SSISTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 735);
            this.Controls.Add(this.ResponseTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ChannelTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AttachmentFieldsGridView);
            this.Controls.Add(this.AttachmentsGridView);
            this.Controls.Add(this.SlackMessageJsonTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.WebHookUrlTextBox);
            this.Controls.Add(this.SimpleMessageTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SSISTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SSISTaskForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentFieldsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SimpleMessageTextBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SlackMessageJsonTextBox;
        private System.Windows.Forms.DataGridView AttachmentsGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WebHookUrlTextBox;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView AttachmentFieldsGridView;
        private System.Windows.Forms.TextBox ChannelTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ResponseTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreText;
        private System.Windows.Forms.DataGridViewTextBoxColumn col;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitleLinkUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorLing;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthorIconUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImageUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThumbUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFooter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFooterUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFieldTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFieldValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colShort;
    }
}