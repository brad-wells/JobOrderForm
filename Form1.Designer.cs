namespace Asg10
{
    partial class MainForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.updateJobButton = new System.Windows.Forms.Button();
            this.DeleteJobButton = new System.Windows.Forms.Button();
            this.AddJobButton = new System.Windows.Forms.Button();
            this.ProductionInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.YesPaidCheckBox = new System.Windows.Forms.CheckBox();
            this.PaidLabel = new System.Windows.Forms.Label();
            this.YesCompletedCheckBox = new System.Windows.Forms.CheckBox();
            this.CompletedLabel = new System.Windows.Forms.Label();
            this.CommentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CommentsLabel = new System.Windows.Forms.Label();
            this.ProductGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.ActualComboBox = new System.Windows.Forms.ComboBox();
            this.EstimatedComboBox = new System.Windows.Forms.ComboBox();
            this.YesRushCheckBox = new System.Windows.Forms.CheckBox();
            this.RushLabel = new System.Windows.Forms.Label();
            this.PromisedByDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PromisedByLabel = new System.Windows.Forms.Label();
            this.ActualHoursLabel = new System.Windows.Forms.Label();
            this.EstimatedHoursLabel = new System.Windows.Forms.Label();
            this.ProblemRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TechNameTextBox = new System.Windows.Forms.TextBox();
            this.ProblemLabel = new System.Windows.Forms.Label();
            this.TechNameLabel = new System.Windows.Forms.Label();
            this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.SerialLabel = new System.Windows.Forms.Label();
            this.ProductTypeLabel = new System.Windows.Forms.Label();
            this.AllJobsListBox = new System.Windows.Forms.ListBox();
            this.CustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jobinstlabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.JobNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.JobNumberLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.LookUpJobButton = new System.Windows.Forms.Button();
            this.CreateNewJobButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.ProductionInfoGroupBox.SuspendLayout();
            this.ProductGroupBox.SuspendLayout();
            this.CustomerGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainPanel.Controls.Add(this.TotalLabel);
            this.MainPanel.Controls.Add(this.CostLabel);
            this.MainPanel.Controls.Add(this.updateJobButton);
            this.MainPanel.Controls.Add(this.DeleteJobButton);
            this.MainPanel.Controls.Add(this.AddJobButton);
            this.MainPanel.Controls.Add(this.ProductionInfoGroupBox);
            this.MainPanel.Controls.Add(this.ProductGroupBox);
            this.MainPanel.Controls.Add(this.CustomerGroupBox);
            this.MainPanel.Location = new System.Drawing.Point(12, 109);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(951, 502);
            this.MainPanel.TabIndex = 0;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.Color.Aqua;
            this.TotalLabel.Location = new System.Drawing.Point(418, 450);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(97, 34);
            this.TotalLabel.TabIndex = 14;
            this.TotalLabel.Text = "Total:   $";
            this.TotalLabel.Click += new System.EventHandler(this.TotalLabel_Click);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.ForeColor = System.Drawing.Color.Aqua;
            this.CostLabel.Location = new System.Drawing.Point(508, 450);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(27, 34);
            this.CostLabel.TabIndex = 13;
            this.CostLabel.Text = "-";
            this.CostLabel.Click += new System.EventHandler(this.CostLabel_Click);
            // 
            // updateJobButton
            // 
            this.updateJobButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateJobButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateJobButton.Location = new System.Drawing.Point(699, 457);
            this.updateJobButton.Name = "updateJobButton";
            this.updateJobButton.Size = new System.Drawing.Size(73, 30);
            this.updateJobButton.TabIndex = 12;
            this.updateJobButton.Text = "UPDATE JOB";
            this.updateJobButton.UseVisualStyleBackColor = true;
            this.updateJobButton.Click += new System.EventHandler(this.updateJobButton_Click);
            // 
            // DeleteJobButton
            // 
            this.DeleteJobButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteJobButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteJobButton.Location = new System.Drawing.Point(778, 456);
            this.DeleteJobButton.Name = "DeleteJobButton";
            this.DeleteJobButton.Size = new System.Drawing.Size(77, 32);
            this.DeleteJobButton.TabIndex = 2;
            this.DeleteJobButton.Text = "DELETE JOB";
            this.DeleteJobButton.UseVisualStyleBackColor = true;
            this.DeleteJobButton.Click += new System.EventHandler(this.DeleteJobButton_Click);
            // 
            // AddJobButton
            // 
            this.AddJobButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddJobButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddJobButton.Location = new System.Drawing.Point(861, 456);
            this.AddJobButton.Name = "AddJobButton";
            this.AddJobButton.Size = new System.Drawing.Size(76, 32);
            this.AddJobButton.TabIndex = 11;
            this.AddJobButton.Text = "ADD JOB";
            this.AddJobButton.UseVisualStyleBackColor = true;
            this.AddJobButton.Click += new System.EventHandler(this.AddJobButton_Click);
            // 
            // ProductionInfoGroupBox
            // 
            this.ProductionInfoGroupBox.Controls.Add(this.YesPaidCheckBox);
            this.ProductionInfoGroupBox.Controls.Add(this.PaidLabel);
            this.ProductionInfoGroupBox.Controls.Add(this.YesCompletedCheckBox);
            this.ProductionInfoGroupBox.Controls.Add(this.CompletedLabel);
            this.ProductionInfoGroupBox.Controls.Add(this.CommentsRichTextBox);
            this.ProductionInfoGroupBox.Controls.Add(this.CommentsLabel);
            this.ProductionInfoGroupBox.ForeColor = System.Drawing.Color.White;
            this.ProductionInfoGroupBox.Location = new System.Drawing.Point(20, 338);
            this.ProductionInfoGroupBox.Name = "ProductionInfoGroupBox";
            this.ProductionInfoGroupBox.Size = new System.Drawing.Size(917, 103);
            this.ProductionInfoGroupBox.TabIndex = 9;
            this.ProductionInfoGroupBox.TabStop = false;
            this.ProductionInfoGroupBox.Text = "Production Info";
            this.ProductionInfoGroupBox.Enter += new System.EventHandler(this.ProductionInfoGroupBox_Enter);
            // 
            // YesPaidCheckBox
            // 
            this.YesPaidCheckBox.AutoSize = true;
            this.YesPaidCheckBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesPaidCheckBox.Location = new System.Drawing.Point(748, 60);
            this.YesPaidCheckBox.Name = "YesPaidCheckBox";
            this.YesPaidCheckBox.Size = new System.Drawing.Size(148, 28);
            this.YesPaidCheckBox.TabIndex = 15;
            this.YesPaidCheckBox.Text = "* Yes if checked";
            this.YesPaidCheckBox.UseVisualStyleBackColor = true;
            // 
            // PaidLabel
            // 
            this.PaidLabel.AutoSize = true;
            this.PaidLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidLabel.ForeColor = System.Drawing.Color.White;
            this.PaidLabel.Location = new System.Drawing.Point(690, 61);
            this.PaidLabel.Name = "PaidLabel";
            this.PaidLabel.Size = new System.Drawing.Size(47, 24);
            this.PaidLabel.TabIndex = 16;
            this.PaidLabel.Text = "Paid:";
            // 
            // YesCompletedCheckBox
            // 
            this.YesCompletedCheckBox.AutoSize = true;
            this.YesCompletedCheckBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesCompletedCheckBox.Location = new System.Drawing.Point(748, 29);
            this.YesCompletedCheckBox.Name = "YesCompletedCheckBox";
            this.YesCompletedCheckBox.Size = new System.Drawing.Size(148, 28);
            this.YesCompletedCheckBox.TabIndex = 14;
            this.YesCompletedCheckBox.Text = "* Yes if checked";
            this.YesCompletedCheckBox.UseVisualStyleBackColor = true;
            this.YesCompletedCheckBox.CheckedChanged += new System.EventHandler(this.YesCompletedCheckBox_CheckedChanged);
            // 
            // CompletedLabel
            // 
            this.CompletedLabel.AutoSize = true;
            this.CompletedLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletedLabel.ForeColor = System.Drawing.Color.White;
            this.CompletedLabel.Location = new System.Drawing.Point(642, 30);
            this.CompletedLabel.Name = "CompletedLabel";
            this.CompletedLabel.Size = new System.Drawing.Size(95, 24);
            this.CompletedLabel.TabIndex = 13;
            this.CompletedLabel.Text = "Completed:";
            // 
            // CommentsRichTextBox
            // 
            this.CommentsRichTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsRichTextBox.Location = new System.Drawing.Point(125, 27);
            this.CommentsRichTextBox.Name = "CommentsRichTextBox";
            this.CommentsRichTextBox.Size = new System.Drawing.Size(450, 56);
            this.CommentsRichTextBox.TabIndex = 13;
            this.CommentsRichTextBox.Text = "";
            // 
            // CommentsLabel
            // 
            this.CommentsLabel.AutoSize = true;
            this.CommentsLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsLabel.ForeColor = System.Drawing.Color.White;
            this.CommentsLabel.Location = new System.Drawing.Point(14, 30);
            this.CommentsLabel.Name = "CommentsLabel";
            this.CommentsLabel.Size = new System.Drawing.Size(97, 24);
            this.CommentsLabel.TabIndex = 11;
            this.CommentsLabel.Text = "Comments:";
            // 
            // ProductGroupBox
            // 
            this.ProductGroupBox.Controls.Add(this.SelectLabel);
            this.ProductGroupBox.Controls.Add(this.label2);
            this.ProductGroupBox.Controls.Add(this.productComboBox);
            this.ProductGroupBox.Controls.Add(this.ActualComboBox);
            this.ProductGroupBox.Controls.Add(this.EstimatedComboBox);
            this.ProductGroupBox.Controls.Add(this.YesRushCheckBox);
            this.ProductGroupBox.Controls.Add(this.RushLabel);
            this.ProductGroupBox.Controls.Add(this.PromisedByDateTimePicker);
            this.ProductGroupBox.Controls.Add(this.PromisedByLabel);
            this.ProductGroupBox.Controls.Add(this.ActualHoursLabel);
            this.ProductGroupBox.Controls.Add(this.EstimatedHoursLabel);
            this.ProductGroupBox.Controls.Add(this.ProblemRichTextBox1);
            this.ProductGroupBox.Controls.Add(this.TechNameTextBox);
            this.ProductGroupBox.Controls.Add(this.ProblemLabel);
            this.ProductGroupBox.Controls.Add(this.TechNameLabel);
            this.ProductGroupBox.Controls.Add(this.SerialNumberTextBox);
            this.ProductGroupBox.Controls.Add(this.SerialLabel);
            this.ProductGroupBox.Controls.Add(this.ProductTypeLabel);
            this.ProductGroupBox.Controls.Add(this.AllJobsListBox);
            this.ProductGroupBox.ForeColor = System.Drawing.Color.White;
            this.ProductGroupBox.Location = new System.Drawing.Point(20, 113);
            this.ProductGroupBox.Name = "ProductGroupBox";
            this.ProductGroupBox.Size = new System.Drawing.Size(917, 219);
            this.ProductGroupBox.TabIndex = 8;
            this.ProductGroupBox.TabStop = false;
            this.ProductGroupBox.Text = "Product Info";
            this.ProductGroupBox.Enter += new System.EventHandler(this.ProductGroupBox_Enter);
            // 
            // SelectLabel
            // 
            this.SelectLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLabel.ForeColor = System.Drawing.Color.White;
            this.SelectLabel.Location = new System.Drawing.Point(6, 10);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(892, 24);
            this.SelectLabel.TabIndex = 25;
            this.SelectLabel.Text = "Select a Job to begin";
            this.SelectLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "*5 numeric digits";
            // 
            // productComboBox
            // 
            this.productComboBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Items.AddRange(new object[] {
            "iPhone",
            "Android",
            "Windows",
            "Blackberry",
            "Other"});
            this.productComboBox.Location = new System.Drawing.Point(148, 42);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(177, 32);
            this.productComboBox.TabIndex = 5;
            this.productComboBox.Text = "-select-";
            // 
            // ActualComboBox
            // 
            this.ActualComboBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualComboBox.FormattingEnabled = true;
            this.ActualComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "+10"});
            this.ActualComboBox.Location = new System.Drawing.Point(772, 127);
            this.ActualComboBox.Name = "ActualComboBox";
            this.ActualComboBox.Size = new System.Drawing.Size(125, 32);
            this.ActualComboBox.TabIndex = 10;
            this.ActualComboBox.Text = "-select-";
            // 
            // EstimatedComboBox
            // 
            this.EstimatedComboBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstimatedComboBox.FormattingEnabled = true;
            this.EstimatedComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "+10"});
            this.EstimatedComboBox.Location = new System.Drawing.Point(772, 83);
            this.EstimatedComboBox.Name = "EstimatedComboBox";
            this.EstimatedComboBox.Size = new System.Drawing.Size(125, 32);
            this.EstimatedComboBox.TabIndex = 9;
            this.EstimatedComboBox.Text = "0";
            // 
            // YesRushCheckBox
            // 
            this.YesRushCheckBox.AutoSize = true;
            this.YesRushCheckBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesRushCheckBox.Location = new System.Drawing.Point(125, 183);
            this.YesRushCheckBox.Name = "YesRushCheckBox";
            this.YesRushCheckBox.Size = new System.Drawing.Size(58, 28);
            this.YesRushCheckBox.TabIndex = 11;
            this.YesRushCheckBox.Text = "Yes";
            this.YesRushCheckBox.UseVisualStyleBackColor = true;
            this.YesRushCheckBox.CheckedChanged += new System.EventHandler(this.YesRushCheckBox_CheckedChanged);
            // 
            // RushLabel
            // 
            this.RushLabel.AutoSize = true;
            this.RushLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushLabel.ForeColor = System.Drawing.Color.White;
            this.RushLabel.Location = new System.Drawing.Point(20, 184);
            this.RushLabel.Name = "RushLabel";
            this.RushLabel.Size = new System.Drawing.Size(84, 24);
            this.RushLabel.TabIndex = 19;
            this.RushLabel.Text = "Rush Job:";
            // 
            // PromisedByDateTimePicker
            // 
            this.PromisedByDateTimePicker.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromisedByDateTimePicker.Location = new System.Drawing.Point(606, 178);
            this.PromisedByDateTimePicker.Name = "PromisedByDateTimePicker";
            this.PromisedByDateTimePicker.Size = new System.Drawing.Size(291, 32);
            this.PromisedByDateTimePicker.TabIndex = 12;
            // 
            // PromisedByLabel
            // 
            this.PromisedByLabel.AutoSize = true;
            this.PromisedByLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromisedByLabel.ForeColor = System.Drawing.Color.White;
            this.PromisedByLabel.Location = new System.Drawing.Point(459, 184);
            this.PromisedByLabel.Name = "PromisedByLabel";
            this.PromisedByLabel.Size = new System.Drawing.Size(116, 24);
            this.PromisedByLabel.TabIndex = 15;
            this.PromisedByLabel.Text = "*Promised By:";
            // 
            // ActualHoursLabel
            // 
            this.ActualHoursLabel.AutoSize = true;
            this.ActualHoursLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualHoursLabel.ForeColor = System.Drawing.Color.White;
            this.ActualHoursLabel.Location = new System.Drawing.Point(639, 130);
            this.ActualHoursLabel.Name = "ActualHoursLabel";
            this.ActualHoursLabel.Size = new System.Drawing.Size(113, 24);
            this.ActualHoursLabel.TabIndex = 13;
            this.ActualHoursLabel.Text = "Actual Hours:";
            // 
            // EstimatedHoursLabel
            // 
            this.EstimatedHoursLabel.AutoSize = true;
            this.EstimatedHoursLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstimatedHoursLabel.ForeColor = System.Drawing.Color.White;
            this.EstimatedHoursLabel.Location = new System.Drawing.Point(602, 86);
            this.EstimatedHoursLabel.Name = "EstimatedHoursLabel";
            this.EstimatedHoursLabel.Size = new System.Drawing.Size(150, 24);
            this.EstimatedHoursLabel.TabIndex = 11;
            this.EstimatedHoursLabel.Text = "*Estimated Hours :";
            // 
            // ProblemRichTextBox1
            // 
            this.ProblemRichTextBox1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemRichTextBox1.Location = new System.Drawing.Point(130, 97);
            this.ProblemRichTextBox1.Name = "ProblemRichTextBox1";
            this.ProblemRichTextBox1.Size = new System.Drawing.Size(445, 62);
            this.ProblemRichTextBox1.TabIndex = 8;
            this.ProblemRichTextBox1.Text = "";
            // 
            // TechNameTextBox
            // 
            this.TechNameTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechNameTextBox.Location = new System.Drawing.Point(772, 42);
            this.TechNameTextBox.Name = "TechNameTextBox";
            this.TechNameTextBox.Size = new System.Drawing.Size(125, 32);
            this.TechNameTextBox.TabIndex = 7;
            // 
            // ProblemLabel
            // 
            this.ProblemLabel.AutoSize = true;
            this.ProblemLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemLabel.ForeColor = System.Drawing.Color.White;
            this.ProblemLabel.Location = new System.Drawing.Point(18, 100);
            this.ProblemLabel.Name = "ProblemLabel";
            this.ProblemLabel.Size = new System.Drawing.Size(86, 24);
            this.ProblemLabel.TabIndex = 8;
            this.ProblemLabel.Text = "*Problem:";
            // 
            // TechNameLabel
            // 
            this.TechNameLabel.AutoSize = true;
            this.TechNameLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechNameLabel.ForeColor = System.Drawing.Color.White;
            this.TechNameLabel.Location = new System.Drawing.Point(650, 45);
            this.TechNameLabel.Name = "TechNameLabel";
            this.TechNameLabel.Size = new System.Drawing.Size(99, 24);
            this.TechNameLabel.TabIndex = 6;
            this.TechNameLabel.Text = "Tech Name :";
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumberTextBox.Location = new System.Drawing.Point(475, 42);
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(100, 32);
            this.SerialNumberTextBox.TabIndex = 6;
            this.SerialNumberTextBox.Text = "22222";
            // 
            // SerialLabel
            // 
            this.SerialLabel.AutoSize = true;
            this.SerialLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialLabel.ForeColor = System.Drawing.Color.White;
            this.SerialLabel.Location = new System.Drawing.Point(331, 45);
            this.SerialLabel.Name = "SerialLabel";
            this.SerialLabel.Size = new System.Drawing.Size(128, 24);
            this.SerialLabel.TabIndex = 6;
            this.SerialLabel.Text = "*Serial Number:";
            // 
            // ProductTypeLabel
            // 
            this.ProductTypeLabel.AutoSize = true;
            this.ProductTypeLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTypeLabel.ForeColor = System.Drawing.Color.White;
            this.ProductTypeLabel.Location = new System.Drawing.Point(14, 45);
            this.ProductTypeLabel.Name = "ProductTypeLabel";
            this.ProductTypeLabel.Size = new System.Drawing.Size(122, 24);
            this.ProductTypeLabel.TabIndex = 4;
            this.ProductTypeLabel.Text = "*Product Type :";
            // 
            // AllJobsListBox
            // 
            this.AllJobsListBox.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllJobsListBox.FormattingEnabled = true;
            this.AllJobsListBox.HorizontalScrollbar = true;
            this.AllJobsListBox.ItemHeight = 28;
            this.AllJobsListBox.Location = new System.Drawing.Point(10, 36);
            this.AllJobsListBox.Name = "AllJobsListBox";
            this.AllJobsListBox.Size = new System.Drawing.Size(885, 88);
            this.AllJobsListBox.TabIndex = 22;
            this.AllJobsListBox.SelectedIndexChanged += new System.EventHandler(this.AllJobsListBox_SelectedIndexChanged);
            // 
            // CustomerGroupBox
            // 
            this.CustomerGroupBox.Controls.Add(this.label1);
            this.CustomerGroupBox.Controls.Add(this.jobinstlabel);
            this.CustomerGroupBox.Controls.Add(this.LastNameLabel);
            this.CustomerGroupBox.Controls.Add(this.LastNameTextBox);
            this.CustomerGroupBox.Controls.Add(this.JobNumberTextBox);
            this.CustomerGroupBox.Controls.Add(this.PhoneTextBox);
            this.CustomerGroupBox.Controls.Add(this.JobNumberLabel);
            this.CustomerGroupBox.Controls.Add(this.NameLabel);
            this.CustomerGroupBox.Controls.Add(this.NameTextBox);
            this.CustomerGroupBox.Controls.Add(this.PhoneLabel);
            this.CustomerGroupBox.ForeColor = System.Drawing.Color.White;
            this.CustomerGroupBox.Location = new System.Drawing.Point(20, 15);
            this.CustomerGroupBox.Name = "CustomerGroupBox";
            this.CustomerGroupBox.Size = new System.Drawing.Size(917, 92);
            this.CustomerGroupBox.TabIndex = 10;
            this.CustomerGroupBox.TabStop = false;
            this.CustomerGroupBox.Text = "Customer Info:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(779, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "* Numbers only 10 digits";
            // 
            // jobinstlabel
            // 
            this.jobinstlabel.AutoSize = true;
            this.jobinstlabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobinstlabel.Location = new System.Drawing.Point(106, 63);
            this.jobinstlabel.Name = "jobinstlabel";
            this.jobinstlabel.Size = new System.Drawing.Size(87, 17);
            this.jobinstlabel.TabIndex = 8;
            this.jobinstlabel.Text = "*4 numeric digits";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.White;
            this.LastNameLabel.Location = new System.Drawing.Point(460, 32);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(89, 24);
            this.LastNameLabel.TabIndex = 6;
            this.LastNameLabel.Text = "*Last Name :";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(566, 29);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 32);
            this.LastNameTextBox.TabIndex = 3;
            this.LastNameTextBox.Text = "wells";
            // 
            // JobNumberTextBox
            // 
            this.JobNumberTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobNumberTextBox.Location = new System.Drawing.Point(92, 29);
            this.JobNumberTextBox.Name = "JobNumberTextBox";
            this.JobNumberTextBox.Size = new System.Drawing.Size(100, 32);
            this.JobNumberTextBox.TabIndex = 1;
            this.JobNumberTextBox.Text = "1234";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextBox.Location = new System.Drawing.Point(762, 28);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(134, 32);
            this.PhoneTextBox.TabIndex = 4;
            this.PhoneTextBox.Text = "5555555555";
            // 
            // JobNumberLabel
            // 
            this.JobNumberLabel.AutoSize = true;
            this.JobNumberLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobNumberLabel.ForeColor = System.Drawing.Color.White;
            this.JobNumberLabel.Location = new System.Drawing.Point(14, 32);
            this.JobNumberLabel.Name = "JobNumberLabel";
            this.JobNumberLabel.Size = new System.Drawing.Size(50, 24);
            this.JobNumberLabel.TabIndex = 0;
            this.JobNumberLabel.Text = "*Job #";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(228, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(91, 24);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "*First Name :";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(335, 28);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 32);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.Text = "brad";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.White;
            this.PhoneLabel.Location = new System.Drawing.Point(690, 32);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(62, 24);
            this.PhoneLabel.TabIndex = 4;
            this.PhoneLabel.Text = "*Phone :";
            // 
            // LookUpJobButton
            // 
            this.LookUpJobButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LookUpJobButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookUpJobButton.Location = new System.Drawing.Point(747, 50);
            this.LookUpJobButton.Name = "LookUpJobButton";
            this.LookUpJobButton.Size = new System.Drawing.Size(76, 32);
            this.LookUpJobButton.TabIndex = 1;
            this.LookUpJobButton.Text = "LOOK  UP";
            this.LookUpJobButton.UseVisualStyleBackColor = true;
            this.LookUpJobButton.Click += new System.EventHandler(this.LookUpJobButton_Click);
            // 
            // CreateNewJobButton
            // 
            this.CreateNewJobButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateNewJobButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewJobButton.Location = new System.Drawing.Point(653, 50);
            this.CreateNewJobButton.Name = "CreateNewJobButton";
            this.CreateNewJobButton.Size = new System.Drawing.Size(76, 32);
            this.CreateNewJobButton.TabIndex = 0;
            this.CreateNewJobButton.Text = "NEW JOB";
            this.CreateNewJobButton.UseVisualStyleBackColor = true;
            this.CreateNewJobButton.Click += new System.EventHandler(this.CreateNewJobButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HelpButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Location = new System.Drawing.Point(840, 50);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(76, 32);
            this.HelpButton.TabIndex = 2;
            this.HelpButton.Text = "HELP";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TitleLabel.Location = new System.Drawing.Point(10, 22);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(329, 72);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Job Order Form";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.HelpButton);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Controls.Add(this.LookUpJobButton);
            this.panel1.Controls.Add(this.CreateNewJobButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 106);
            this.panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supreme Phone Repair";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ProductionInfoGroupBox.ResumeLayout(false);
            this.ProductionInfoGroupBox.PerformLayout();
            this.ProductGroupBox.ResumeLayout(false);
            this.ProductGroupBox.PerformLayout();
            this.CustomerGroupBox.ResumeLayout(false);
            this.CustomerGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.GroupBox ProductGroupBox;
        private System.Windows.Forms.Label ProductTypeLabel;
        private System.Windows.Forms.TextBox TechNameTextBox;
        private System.Windows.Forms.Label TechNameLabel;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox JobNumberTextBox;
        private System.Windows.Forms.Label JobNumberLabel;
        private System.Windows.Forms.Button DeleteJobButton;
        private System.Windows.Forms.RichTextBox ProblemRichTextBox1;
        private System.Windows.Forms.Label ProblemLabel;
        private System.Windows.Forms.TextBox SerialNumberTextBox;
        private System.Windows.Forms.Label SerialLabel;
        private System.Windows.Forms.Label PromisedByLabel;
        private System.Windows.Forms.Label ActualHoursLabel;
        private System.Windows.Forms.Label EstimatedHoursLabel;
        private System.Windows.Forms.DateTimePicker PromisedByDateTimePicker;
        private System.Windows.Forms.GroupBox ProductionInfoGroupBox;
        private System.Windows.Forms.RichTextBox CommentsRichTextBox;
        private System.Windows.Forms.Label CommentsLabel;
        private System.Windows.Forms.CheckBox YesPaidCheckBox;
        private System.Windows.Forms.Label PaidLabel;
        private System.Windows.Forms.CheckBox YesCompletedCheckBox;
        private System.Windows.Forms.Label CompletedLabel;
        private System.Windows.Forms.CheckBox YesRushCheckBox;
        private System.Windows.Forms.Label RushLabel;
        private System.Windows.Forms.GroupBox CustomerGroupBox;
        private System.Windows.Forms.Button AddJobButton;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.ComboBox EstimatedComboBox;
        private System.Windows.Forms.ComboBox ActualComboBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label jobinstlabel;
        private System.Windows.Forms.Button updateJobButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button CreateNewJobButton;
        private System.Windows.Forms.Button LookUpJobButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label TotalLabel;
        public System.Windows.Forms.ListBox AllJobsListBox;
    }
}

