namespace BulkEmail
{
    partial class BulkEmail
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
            this.LoadData = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.EmailContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ActionToDo = new System.Windows.Forms.CheckedListBox();
            this.Send = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailTemplate = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadData
            // 
            this.LoadData.Location = new System.Drawing.Point(376, 39);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(75, 20);
            this.LoadData.TabIndex = 3;
            this.LoadData.Text = "Initialize";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(42, 79);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(728, 222);
            this.dataGrid.TabIndex = 5;
            // 
            // EmailContent
            // 
            this.EmailContent.Location = new System.Drawing.Point(42, 406);
            this.EmailContent.Name = "EmailContent";
            this.EmailContent.Size = new System.Drawing.Size(728, 252);
            this.EmailContent.TabIndex = 6;
            this.EmailContent.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email Content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 736);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Actions";
            // 
            // ActionToDo
            // 
            this.ActionToDo.FormattingEnabled = true;
            this.ActionToDo.Items.AddRange(new object[] {
            "Send",
            "Preview"});
            this.ActionToDo.Location = new System.Drawing.Point(42, 752);
            this.ActionToDo.Name = "ActionToDo";
            this.ActionToDo.Size = new System.Drawing.Size(66, 34);
            this.ActionToDo.TabIndex = 9;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(594, 758);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(85, 27);
            this.Send.TabIndex = 10;
            this.Send.Text = "Run";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(685, 758);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(85, 27);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 673);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Use Inbuilt Email Templates";
            // 
            // EmailTemplate
            // 
            this.EmailTemplate.FormattingEnabled = true;
            this.EmailTemplate.Items.AddRange(new object[] {
            "Usernames",
            "Passwords"});
            this.EmailTemplate.Location = new System.Drawing.Point(42, 689);
            this.EmailTemplate.Name = "EmailTemplate";
            this.EmailTemplate.Size = new System.Drawing.Size(80, 34);
            this.EmailTemplate.TabIndex = 14;
            this.EmailTemplate.SelectedIndexChanged += new System.EventHandler(this.EmailTemplate_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Subject Line";
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(42, 346);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(728, 20);
            this.Subject.TabIndex = 16;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(376, 307);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 17;
            this.Next.Text = "Load Data";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // BulkEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 820);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailTemplate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.ActionToDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailContent);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.LoadData);
            this.Name = "BulkEmail";
            this.Text = "BULKmail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadData;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.RichTextBox EmailContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox ActionToDo;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox EmailTemplate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Button Next;
    }
}

