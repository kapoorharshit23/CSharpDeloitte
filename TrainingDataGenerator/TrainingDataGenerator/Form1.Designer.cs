namespace TrainingDataGenerator
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DestinationFilePath = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.WorkerCount = new System.Windows.Forms.TextBox();
            this.EmpCount = new System.Windows.Forms.TextBox();
            this.ContWorkerCount = new System.Windows.Forms.TextBox();
            this.FemaleCount = new System.Windows.Forms.TextBox();
            this.MaleCount = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.CheckBox();
            this.LastName = new System.Windows.Forms.CheckBox();
            this.Gender = new System.Windows.Forms.CheckBox();
            this.EmployeeType = new System.Windows.Forms.CheckBox();
            this.DummyAppID = new System.Windows.Forms.CheckBox();
            this.DummyEmailID = new System.Windows.Forms.CheckBox();
            this.Browse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Worker Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Male Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Female Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contract Contingent Worker Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fields Required ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Destination File Path";
            // 
            // DestinationFilePath
            // 
            this.DestinationFilePath.Location = new System.Drawing.Point(164, 349);
            this.DestinationFilePath.Name = "DestinationFilePath";
            this.DestinationFilePath.Size = new System.Drawing.Size(356, 20);
            this.DestinationFilePath.TabIndex = 13;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(549, 394);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(101, 29);
            this.Generate.TabIndex = 14;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(656, 394);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(101, 29);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // WorkerCount
            // 
            this.WorkerCount.Location = new System.Drawing.Point(164, 34);
            this.WorkerCount.Name = "WorkerCount";
            this.WorkerCount.Size = new System.Drawing.Size(94, 20);
            this.WorkerCount.TabIndex = 16;
            // 
            // EmpCount
            // 
            this.EmpCount.Location = new System.Drawing.Point(526, 95);
            this.EmpCount.Name = "EmpCount";
            this.EmpCount.Size = new System.Drawing.Size(94, 20);
            this.EmpCount.TabIndex = 17;
            // 
            // ContWorkerCount
            // 
            this.ContWorkerCount.Location = new System.Drawing.Point(526, 126);
            this.ContWorkerCount.Name = "ContWorkerCount";
            this.ContWorkerCount.Size = new System.Drawing.Size(94, 20);
            this.ContWorkerCount.TabIndex = 18;
            // 
            // FemaleCount
            // 
            this.FemaleCount.Location = new System.Drawing.Point(526, 66);
            this.FemaleCount.Name = "FemaleCount";
            this.FemaleCount.Size = new System.Drawing.Size(94, 20);
            this.FemaleCount.TabIndex = 19;
            // 
            // MaleCount
            // 
            this.MaleCount.Location = new System.Drawing.Point(526, 34);
            this.MaleCount.Name = "MaleCount";
            this.MaleCount.Size = new System.Drawing.Size(94, 20);
            this.MaleCount.TabIndex = 20;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(49, 212);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(76, 17);
            this.FirstName.TabIndex = 21;
            this.FirstName.Text = "First Name";
            this.FirstName.UseVisualStyleBackColor = true;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(342, 212);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(77, 17);
            this.LastName.TabIndex = 22;
            this.LastName.Text = "Last Name";
            this.LastName.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(599, 212);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(61, 17);
            this.Gender.TabIndex = 23;
            this.Gender.Text = "Gender";
            this.Gender.UseVisualStyleBackColor = true;
            // 
            // EmployeeType
            // 
            this.EmployeeType.AutoSize = true;
            this.EmployeeType.Location = new System.Drawing.Point(49, 251);
            this.EmployeeType.Name = "EmployeeType";
            this.EmployeeType.Size = new System.Drawing.Size(99, 17);
            this.EmployeeType.TabIndex = 24;
            this.EmployeeType.Text = "Employee Type";
            this.EmployeeType.UseVisualStyleBackColor = true;
            // 
            // DummyAppID
            // 
            this.DummyAppID.AutoSize = true;
            this.DummyAppID.Location = new System.Drawing.Point(342, 251);
            this.DummyAppID.Name = "DummyAppID";
            this.DummyAppID.Size = new System.Drawing.Size(122, 17);
            this.DummyAppID.TabIndex = 25;
            this.DummyAppID.Text = "Dummy Applicant ID";
            this.DummyAppID.UseVisualStyleBackColor = true;
            // 
            // DummyEmailID
            // 
            this.DummyEmailID.AutoSize = true;
            this.DummyEmailID.Location = new System.Drawing.Point(599, 251);
            this.DummyEmailID.Name = "DummyEmailID";
            this.DummyEmailID.Size = new System.Drawing.Size(103, 17);
            this.DummyEmailID.TabIndex = 26;
            this.DummyEmailID.Text = "Dummy Email ID";
            this.DummyEmailID.UseVisualStyleBackColor = true;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(549, 344);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(101, 29);
            this.Browse.TabIndex = 27;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(637, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "_________________________________________________________________________________" +
    "________________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.DummyEmailID);
            this.Controls.Add(this.DummyAppID);
            this.Controls.Add(this.EmployeeType);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.MaleCount);
            this.Controls.Add(this.FemaleCount);
            this.Controls.Add(this.ContWorkerCount);
            this.Controls.Add(this.EmpCount);
            this.Controls.Add(this.WorkerCount);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.DestinationFilePath);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Training Data Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DestinationFilePath;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox WorkerCount;
        private System.Windows.Forms.TextBox EmpCount;
        private System.Windows.Forms.TextBox ContWorkerCount;
        private System.Windows.Forms.TextBox FemaleCount;
        private System.Windows.Forms.TextBox MaleCount;
        private System.Windows.Forms.CheckBox FirstName;
        private System.Windows.Forms.CheckBox LastName;
        private System.Windows.Forms.CheckBox Gender;
        private System.Windows.Forms.CheckBox EmployeeType;
        private System.Windows.Forms.CheckBox DummyAppID;
        private System.Windows.Forms.CheckBox DummyEmailID;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label label7;
    }
}

