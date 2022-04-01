
namespace Hospital_Charges
{
    partial class HospitalCharges
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearFormButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.hospitalChargesGroupBox = new System.Windows.Forms.GroupBox();
            this.totalChargesOutputLabel = new System.Windows.Forms.Label();
            this.miscChargesOutputLabel = new System.Windows.Forms.Label();
            this.stayChargesOutputLabel = new System.Windows.Forms.Label();
            this.totalChargesLabel = new System.Windows.Forms.Label();
            this.miscChargesLabel = new System.Windows.Forms.Label();
            this.stayChargesLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surgicalChargesTextBox = new System.Windows.Forms.TextBox();
            this.medChargesTextBox = new System.Windows.Forms.TextBox();
            this.labFeesTextBox = new System.Windows.Forms.TextBox();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.rehabFeeTextBox = new System.Windows.Forms.TextBox();
            this.rehabFeesLabel = new System.Windows.Forms.Label();
            this.labFeesLabel = new System.Windows.Forms.Label();
            this.surgicalChargesLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.byDepartment = new System.Windows.Forms.Label();
            this.medChargesLabel = new System.Windows.Forms.Label();
            this.billingGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.hospitalChargesGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.billingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(307, 467);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearFormButton
            // 
            this.clearFormButton.Location = new System.Drawing.Point(77, 467);
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.Size = new System.Drawing.Size(75, 23);
            this.clearFormButton.TabIndex = 11;
            this.clearFormButton.Text = "Clear Form";
            this.clearFormButton.UseVisualStyleBackColor = true;
            this.clearFormButton.Click += new System.EventHandler(this.clearFormButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(845, 467);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // hospitalChargesGroupBox
            // 
            this.hospitalChargesGroupBox.Controls.Add(this.totalChargesOutputLabel);
            this.hospitalChargesGroupBox.Controls.Add(this.miscChargesOutputLabel);
            this.hospitalChargesGroupBox.Controls.Add(this.stayChargesOutputLabel);
            this.hospitalChargesGroupBox.Controls.Add(this.totalChargesLabel);
            this.hospitalChargesGroupBox.Controls.Add(this.miscChargesLabel);
            this.hospitalChargesGroupBox.Controls.Add(this.stayChargesLabel);
            this.hospitalChargesGroupBox.Location = new System.Drawing.Point(587, 118);
            this.hospitalChargesGroupBox.Name = "hospitalChargesGroupBox";
            this.hospitalChargesGroupBox.Size = new System.Drawing.Size(333, 306);
            this.hospitalChargesGroupBox.TabIndex = 15;
            this.hospitalChargesGroupBox.TabStop = false;
            this.hospitalChargesGroupBox.Text = "Hospital Charges";
            // 
            // totalChargesOutputLabel
            // 
            this.totalChargesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalChargesOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.totalChargesOutputLabel.Location = new System.Drawing.Point(181, 210);
            this.totalChargesOutputLabel.Name = "totalChargesOutputLabel";
            this.totalChargesOutputLabel.Size = new System.Drawing.Size(100, 30);
            this.totalChargesOutputLabel.TabIndex = 5;
            this.totalChargesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // miscChargesOutputLabel
            // 
            this.miscChargesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.miscChargesOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.miscChargesOutputLabel.Location = new System.Drawing.Point(181, 144);
            this.miscChargesOutputLabel.Name = "miscChargesOutputLabel";
            this.miscChargesOutputLabel.Size = new System.Drawing.Size(100, 30);
            this.miscChargesOutputLabel.TabIndex = 4;
            this.miscChargesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stayChargesOutputLabel
            // 
            this.stayChargesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stayChargesOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stayChargesOutputLabel.Location = new System.Drawing.Point(181, 78);
            this.stayChargesOutputLabel.Name = "stayChargesOutputLabel";
            this.stayChargesOutputLabel.Size = new System.Drawing.Size(100, 30);
            this.stayChargesOutputLabel.TabIndex = 3;
            this.stayChargesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalChargesLabel
            // 
            this.totalChargesLabel.AutoSize = true;
            this.totalChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.totalChargesLabel.Location = new System.Drawing.Point(74, 217);
            this.totalChargesLabel.Name = "totalChargesLabel";
            this.totalChargesLabel.Size = new System.Drawing.Size(105, 17);
            this.totalChargesLabel.TabIndex = 2;
            this.totalChargesLabel.Text = "Total Charges :";
            // 
            // miscChargesLabel
            // 
            this.miscChargesLabel.AutoSize = true;
            this.miscChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.miscChargesLabel.Location = new System.Drawing.Point(74, 151);
            this.miscChargesLabel.Name = "miscChargesLabel";
            this.miscChargesLabel.Size = new System.Drawing.Size(101, 17);
            this.miscChargesLabel.TabIndex = 1;
            this.miscChargesLabel.Text = "Misc Charges :";
            // 
            // stayChargesLabel
            // 
            this.stayChargesLabel.AutoSize = true;
            this.stayChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stayChargesLabel.Location = new System.Drawing.Point(74, 85);
            this.stayChargesLabel.Name = "stayChargesLabel";
            this.stayChargesLabel.Size = new System.Drawing.Size(101, 17);
            this.stayChargesLabel.TabIndex = 0;
            this.stayChargesLabel.Text = "Stay Charges :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearFormToolStripMenuItem,
            this.saveToFileMenu,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1017, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // clearFormToolStripMenuItem
            // 
            this.clearFormToolStripMenuItem.Name = "clearFormToolStripMenuItem";
            this.clearFormToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.clearFormToolStripMenuItem.Text = "Clear Form";
            this.clearFormToolStripMenuItem.Click += new System.EventHandler(this.clearFormToolStripMenuItem_Click);
            // 
            // saveToFileMenu
            // 
            this.saveToFileMenu.Name = "saveToFileMenu";
            this.saveToFileMenu.Size = new System.Drawing.Size(78, 20);
            this.saveToFileMenu.Text = "Save to File";
            this.saveToFileMenu.Visible = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // surgicalChargesTextBox
            // 
            this.surgicalChargesTextBox.Location = new System.Drawing.Point(167, 173);
            this.surgicalChargesTextBox.Name = "surgicalChargesTextBox";
            this.surgicalChargesTextBox.Size = new System.Drawing.Size(100, 20);
            this.surgicalChargesTextBox.TabIndex = 7;
            // 
            // medChargesTextBox
            // 
            this.medChargesTextBox.Location = new System.Drawing.Point(167, 136);
            this.medChargesTextBox.Name = "medChargesTextBox";
            this.medChargesTextBox.Size = new System.Drawing.Size(100, 20);
            this.medChargesTextBox.TabIndex = 6;
            // 
            // labFeesTextBox
            // 
            this.labFeesTextBox.Location = new System.Drawing.Point(167, 210);
            this.labFeesTextBox.Name = "labFeesTextBox";
            this.labFeesTextBox.Size = new System.Drawing.Size(100, 20);
            this.labFeesTextBox.TabIndex = 8;
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(167, 99);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(100, 20);
            this.daysTextBox.TabIndex = 5;
            // 
            // rehabFeeTextBox
            // 
            this.rehabFeeTextBox.Location = new System.Drawing.Point(167, 247);
            this.rehabFeeTextBox.Name = "rehabFeeTextBox";
            this.rehabFeeTextBox.Size = new System.Drawing.Size(100, 20);
            this.rehabFeeTextBox.TabIndex = 9;
            // 
            // rehabFeesLabel
            // 
            this.rehabFeesLabel.AutoSize = true;
            this.rehabFeesLabel.Location = new System.Drawing.Point(15, 251);
            this.rehabFeesLabel.Name = "rehabFeesLabel";
            this.rehabFeesLabel.Size = new System.Drawing.Size(145, 13);
            this.rehabFeesLabel.TabIndex = 4;
            this.rehabFeesLabel.Text = "Physical Rehabilitation Fees :";
            // 
            // labFeesLabel
            // 
            this.labFeesLabel.AutoSize = true;
            this.labFeesLabel.Location = new System.Drawing.Point(103, 214);
            this.labFeesLabel.Name = "labFeesLabel";
            this.labFeesLabel.Size = new System.Drawing.Size(57, 13);
            this.labFeesLabel.TabIndex = 3;
            this.labFeesLabel.Text = "Lab Fees :";
            // 
            // surgicalChargesLabel
            // 
            this.surgicalChargesLabel.AutoSize = true;
            this.surgicalChargesLabel.Location = new System.Drawing.Point(67, 177);
            this.surgicalChargesLabel.Name = "surgicalChargesLabel";
            this.surgicalChargesLabel.Size = new System.Drawing.Size(93, 13);
            this.surgicalChargesLabel.TabIndex = 2;
            this.surgicalChargesLabel.Text = "Surgical Charges :";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(47, 103);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(113, 13);
            this.daysLabel.TabIndex = 0;
            this.daysLabel.Text = "Length of stay (Days) :";
            // 
            // byDepartment
            // 
            this.byDepartment.AutoSize = true;
            this.byDepartment.Location = new System.Drawing.Point(103, 56);
            this.byDepartment.Name = "byDepartment";
            this.byDepartment.Size = new System.Drawing.Size(110, 13);
            this.byDepartment.TabIndex = 13;
            this.byDepartment.Text = "Billing info breakdown";
            // 
            // medChargesLabel
            // 
            this.medChargesLabel.AutoSize = true;
            this.medChargesLabel.Location = new System.Drawing.Point(53, 140);
            this.medChargesLabel.Name = "medChargesLabel";
            this.medChargesLabel.Size = new System.Drawing.Size(107, 13);
            this.medChargesLabel.TabIndex = 1;
            this.medChargesLabel.Text = "Medication Charges :";
            // 
            // billingGroupBox
            // 
            this.billingGroupBox.Controls.Add(this.medChargesLabel);
            this.billingGroupBox.Controls.Add(this.byDepartment);
            this.billingGroupBox.Controls.Add(this.daysLabel);
            this.billingGroupBox.Controls.Add(this.surgicalChargesLabel);
            this.billingGroupBox.Controls.Add(this.labFeesLabel);
            this.billingGroupBox.Controls.Add(this.rehabFeesLabel);
            this.billingGroupBox.Controls.Add(this.rehabFeeTextBox);
            this.billingGroupBox.Controls.Add(this.daysTextBox);
            this.billingGroupBox.Controls.Add(this.labFeesTextBox);
            this.billingGroupBox.Controls.Add(this.medChargesTextBox);
            this.billingGroupBox.Controls.Add(this.surgicalChargesTextBox);
            this.billingGroupBox.Location = new System.Drawing.Point(77, 118);
            this.billingGroupBox.Name = "billingGroupBox";
            this.billingGroupBox.Size = new System.Drawing.Size(305, 306);
            this.billingGroupBox.TabIndex = 14;
            this.billingGroupBox.TabStop = false;
            this.billingGroupBox.Text = "Enter billing details in the form below";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(653, 45);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // HospitalCharges
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearFormButton;
            this.ClientSize = new System.Drawing.Size(1017, 576);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.hospitalChargesGroupBox);
            this.Controls.Add(this.billingGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearFormButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HospitalCharges";
            this.Text = "Hospital Charges";
            this.Activated += new System.EventHandler(this.clearFormButton_Click);
            this.hospitalChargesGroupBox.ResumeLayout(false);
            this.hospitalChargesGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.billingGroupBox.ResumeLayout(false);
            this.billingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearFormButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox hospitalChargesGroupBox;
        private System.Windows.Forms.Label totalChargesOutputLabel;
        private System.Windows.Forms.Label miscChargesOutputLabel;
        private System.Windows.Forms.Label stayChargesOutputLabel;
        private System.Windows.Forms.Label totalChargesLabel;
        private System.Windows.Forms.Label miscChargesLabel;
        private System.Windows.Forms.Label stayChargesLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox surgicalChargesTextBox;
        private System.Windows.Forms.TextBox medChargesTextBox;
        private System.Windows.Forms.TextBox labFeesTextBox;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.TextBox rehabFeeTextBox;
        private System.Windows.Forms.Label rehabFeesLabel;
        private System.Windows.Forms.Label labFeesLabel;
        private System.Windows.Forms.Label surgicalChargesLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label byDepartment;
        private System.Windows.Forms.Label medChargesLabel;
        private System.Windows.Forms.GroupBox billingGroupBox;
        private System.Windows.Forms.ToolStripMenuItem saveToFileMenu;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

