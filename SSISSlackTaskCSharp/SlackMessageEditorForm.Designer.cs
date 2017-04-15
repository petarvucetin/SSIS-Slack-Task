namespace SSISSlackTaskCSharp
{
    partial class SlackMessageEditorForm
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
            this.FieldsGrid = new System.Windows.Forms.DataGridView();
            this.colFieldTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFieldValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShort = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AttachmentGrid = new System.Windows.Forms.DataGridView();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.SimpleMessageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FieldsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FieldsGrid
            // 
            this.FieldsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FieldsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFieldTitle,
            this.colFieldValue,
            this.colShort});
            this.FieldsGrid.Location = new System.Drawing.Point(13, 323);
            this.FieldsGrid.Name = "FieldsGrid";
            this.FieldsGrid.Size = new System.Drawing.Size(640, 94);
            this.FieldsGrid.TabIndex = 11;
            // 
            // colFieldTitle
            // 
            this.colFieldTitle.HeaderText = "Title";
            this.colFieldTitle.Name = "colFieldTitle";
            // 
            // colFieldValue
            // 
            this.colFieldValue.HeaderText = "Field Value";
            this.colFieldValue.Name = "colFieldValue";
            // 
            // colShort
            // 
            this.colShort.HeaderText = "Show in Short";
            this.colShort.Name = "colShort";
            // 
            // AttachmentGrid
            // 
            this.AttachmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttachmentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.AttachmentGrid.Location = new System.Drawing.Point(13, 137);
            this.AttachmentGrid.Name = "AttachmentGrid";
            this.AttachmentGrid.Size = new System.Drawing.Size(640, 150);
            this.AttachmentGrid.TabIndex = 10;
            // 
            // colPreText
            // 
            this.colPreText.HeaderText = "PreText";
            this.colPreText.Name = "colPreText";
            // 
            // col
            // 
            this.col.HeaderText = "FallBack";
            this.col.Name = "col";
            // 
            // colColor
            // 
            this.colColor.HeaderText = "Color";
            this.colColor.Name = "colColor";
            // 
            // coltitle
            // 
            this.coltitle.HeaderText = "Title";
            this.coltitle.Name = "coltitle";
            // 
            // colTitleLinkUrl
            // 
            this.colTitleLinkUrl.HeaderText = "Title Link Url";
            this.colTitleLinkUrl.Name = "colTitleLinkUrl";
            // 
            // colText
            // 
            this.colText.HeaderText = "Text";
            this.colText.Name = "colText";
            // 
            // colAuthorName
            // 
            this.colAuthorName.HeaderText = "Author Name";
            this.colAuthorName.Name = "colAuthorName";
            // 
            // colAuthorLing
            // 
            this.colAuthorLing.HeaderText = "Author Link";
            this.colAuthorLing.Name = "colAuthorLing";
            // 
            // colAuthorIconUrl
            // 
            this.colAuthorIconUrl.HeaderText = "Author Icon Url";
            this.colAuthorIconUrl.Name = "colAuthorIconUrl";
            // 
            // colImageUrl
            // 
            this.colImageUrl.HeaderText = "Image Url";
            this.colImageUrl.Name = "colImageUrl";
            // 
            // colThumbUrl
            // 
            this.colThumbUrl.HeaderText = "Thumb Url";
            this.colThumbUrl.Name = "colThumbUrl";
            // 
            // colFooter
            // 
            this.colFooter.HeaderText = "Footer";
            this.colFooter.Name = "colFooter";
            // 
            // colFooterUrl
            // 
            this.colFooterUrl.HeaderText = "Footer Url";
            this.colFooterUrl.Name = "colFooterUrl";
            // 
            // colTimeStamp
            // 
            this.colTimeStamp.HeaderText = "Time Stamp";
            this.colTimeStamp.Name = "colTimeStamp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Attachements Fields";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Attachements";
            // 
            // DoneButton
            // 
            this.DoneButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DoneButton.Location = new System.Drawing.Point(579, 443);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 7;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            // 
            // SimpleMessageTextBox
            // 
            this.SimpleMessageTextBox.Location = new System.Drawing.Point(12, 35);
            this.SimpleMessageTextBox.Multiline = true;
            this.SimpleMessageTextBox.Name = "SimpleMessageTextBox";
            this.SimpleMessageTextBox.Size = new System.Drawing.Size(641, 66);
            this.SimpleMessageTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Text";
            // 
            // SlackMessageEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 483);
            this.Controls.Add(this.SimpleMessageTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FieldsGrid);
            this.Controls.Add(this.AttachmentGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DoneButton);
            this.Name = "SlackMessageEditorForm";
            this.Text = "SlackMessageEditorForm";
            ((System.ComponentModel.ISupportInitialize)(this.FieldsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FieldsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFieldTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFieldValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colShort;
        private System.Windows.Forms.DataGridView AttachmentGrid;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.TextBox SimpleMessageTextBox;
        private System.Windows.Forms.Label label1;
    }
}