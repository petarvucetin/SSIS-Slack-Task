namespace SSISSlackTaskCSharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.SimpleMessageTextBox = new System.Windows.Forms.TextBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WebHookUrlTextBox = new System.Windows.Forms.TextBox();
            this.TestButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colFieldTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFieldValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShort = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple Message";
            // 
            // SimpleMessageTextBox
            // 
            this.SimpleMessageTextBox.Location = new System.Drawing.Point(13, 82);
            this.SimpleMessageTextBox.Multiline = true;
            this.SimpleMessageTextBox.Name = "SimpleMessageTextBox";
            this.SimpleMessageTextBox.Size = new System.Drawing.Size(641, 66);
            this.SimpleMessageTextBox.TabIndex = 1;
            // 
            // DoneButton
            // 
            this.DoneButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DoneButton.Location = new System.Drawing.Point(580, 616);
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
            this.label2.Location = new System.Drawing.Point(11, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message as JSON";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 169);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(640, 122);
            this.textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 150);
            this.dataGridView1.TabIndex = 5;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Attachements";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Web Hook Url";
            // 
            // WebHookUrlTextBox
            // 
            this.WebHookUrlTextBox.Location = new System.Drawing.Point(13, 25);
            this.WebHookUrlTextBox.Name = "WebHookUrlTextBox";
            this.WebHookUrlTextBox.Size = new System.Drawing.Size(641, 20);
            this.WebHookUrlTextBox.TabIndex = 1;
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(499, 616);
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
            this.label5.Location = new System.Drawing.Point(10, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Attachements Fields";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFieldTitle,
            this.colFieldValue,
            this.colShort});
            this.dataGridView2.Location = new System.Drawing.Point(14, 496);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(640, 94);
            this.dataGridView2.TabIndex = 6;
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
            // SSISTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 646);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.WebHookUrlTextBox);
            this.Controls.Add(this.SimpleMessageTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "SSISTaskForm";
            this.Text = "SSISTaskForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SimpleMessageTextBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WebHookUrlTextBox;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFieldTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFieldValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colShort;
    }
}