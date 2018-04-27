namespace TrangTestStub
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbInstructions = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.cbTempType = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbAlerts = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSaveAlert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTempDirection = new System.Windows.Forms.ComboBox();
            this.gbDir = new System.Windows.Forms.GroupBox();
            this.gbFlux = new System.Windows.Forms.GroupBox();
            this.gbNum = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAlertTimes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.cbFlux = new System.Windows.Forms.CheckBox();
            this.cbDir = new System.Windows.Forms.CheckBox();
            this.cbNum = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbAlerts.SuspendLayout();
            this.gbDir.SuspendLayout();
            this.gbFlux.SuspendLayout();
            this.gbNum.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1.5 C",
            "1.0 C",
            "0.5 C",
            "0.0 C",
            "-0.5 C",
            "0.0 C",
            "-0.5 C",
            "0.0 C",
            "0.5 C",
            "0.0 C"});
            this.listBox1.Location = new System.Drawing.Point(33, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(262, 186);
            this.listBox1.TabIndex = 0;
            // 
            // tbInstructions
            // 
            this.tbInstructions.BackColor = System.Drawing.SystemColors.Control;
            this.tbInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInstructions.Location = new System.Drawing.Point(33, 6);
            this.tbInstructions.Multiline = true;
            this.tbInstructions.Name = "tbInstructions";
            this.tbInstructions.Size = new System.Drawing.Size(262, 85);
            this.tbInstructions.TabIndex = 1;
            this.tbInstructions.Text = "Enter your test temperatures below like this-10 C/r/n2 F";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(335, 6);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(262, 277);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "TEST!";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // cbTempType
            // 
            this.cbTempType.FormattingEnabled = true;
            this.cbTempType.Location = new System.Drawing.Point(230, 12);
            this.cbTempType.Name = "cbTempType";
            this.cbTempType.Size = new System.Drawing.Size(42, 21);
            this.cbTempType.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 4;
            // 
            // gbAlerts
            // 
            this.gbAlerts.Controls.Add(this.groupBox4);
            this.gbAlerts.Controls.Add(this.textBox3);
            this.gbAlerts.Controls.Add(this.label2);
            this.gbAlerts.Controls.Add(this.label1);
            this.gbAlerts.Controls.Add(this.textBox2);
            this.gbAlerts.Controls.Add(this.textBox1);
            this.gbAlerts.Controls.Add(this.cbTempType);
            this.gbAlerts.Location = new System.Drawing.Point(29, 21);
            this.gbAlerts.Name = "gbAlerts";
            this.gbAlerts.Size = new System.Drawing.Size(279, 175);
            this.gbAlerts.TabIndex = 5;
            this.gbAlerts.TabStop = false;
            this.gbAlerts.Text = "Alerts";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(5, 62);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(267, 62);
            this.textBox2.TabIndex = 5;
            // 
            // btnSaveAlert
            // 
            this.btnSaveAlert.Location = new System.Drawing.Point(435, 232);
            this.btnSaveAlert.Name = "btnSaveAlert";
            this.btnSaveAlert.Size = new System.Drawing.Size(160, 24);
            this.btnSaveAlert.TabIndex = 6;
            this.btnSaveAlert.Text = "Save";
            this.btnSaveAlert.UseVisualStyleBackColor = true;
            this.btnSaveAlert.Click += new System.EventHandler(this.btnSaveAlert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "When the temperature reaches";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Call this temparature:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alert me only if the temperature fluctuated by more than";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(84, 20);
            this.textBox4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "degrees.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Alert me only if the temperature ";
            // 
            // cbTempDirection
            // 
            this.cbTempDirection.FormattingEnabled = true;
            this.cbTempDirection.Location = new System.Drawing.Point(168, 36);
            this.cbTempDirection.Name = "cbTempDirection";
            this.cbTempDirection.Size = new System.Drawing.Size(97, 21);
            this.cbTempDirection.TabIndex = 14;
            // 
            // gbDir
            // 
            this.gbDir.Controls.Add(this.label8);
            this.gbDir.Controls.Add(this.cbTempDirection);
            this.gbDir.Controls.Add(this.label5);
            this.gbDir.Enabled = false;
            this.gbDir.Location = new System.Drawing.Point(314, 96);
            this.gbDir.Name = "gbDir";
            this.gbDir.Size = new System.Drawing.Size(281, 100);
            this.gbDir.TabIndex = 6;
            this.gbDir.TabStop = false;
            this.gbDir.Text = "Direction";
            // 
            // gbFlux
            // 
            this.gbFlux.Controls.Add(this.label4);
            this.gbFlux.Controls.Add(this.label3);
            this.gbFlux.Controls.Add(this.textBox4);
            this.gbFlux.Enabled = false;
            this.gbFlux.Location = new System.Drawing.Point(314, 21);
            this.gbFlux.Name = "gbFlux";
            this.gbFlux.Size = new System.Drawing.Size(281, 68);
            this.gbFlux.TabIndex = 7;
            this.gbFlux.TabStop = false;
            this.gbFlux.Text = "Fluctuation";
            // 
            // gbNum
            // 
            this.gbNum.Controls.Add(this.label7);
            this.gbNum.Controls.Add(this.cbAlertTimes);
            this.gbNum.Controls.Add(this.label6);
            this.gbNum.Enabled = false;
            this.gbNum.Location = new System.Drawing.Point(29, 202);
            this.gbNum.Name = "gbNum";
            this.gbNum.Size = new System.Drawing.Size(400, 54);
            this.gbNum.TabIndex = 8;
            this.gbNum.TabStop = false;
            this.gbNum.Text = "Number of Alerts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Alert me ";
            // 
            // cbAlertTimes
            // 
            this.cbAlertTimes.FormattingEnabled = true;
            this.cbAlertTimes.Location = new System.Drawing.Point(51, 17);
            this.cbAlertTimes.Name = "cbAlertTimes";
            this.cbAlertTimes.Size = new System.Drawing.Size(118, 21);
            this.cbAlertTimes.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "time the temperature reaches this threshold.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 343);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbInstructions);
            this.tabPage1.Controls.Add(this.btnTest);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TemperatureTest";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbAlerts);
            this.tabPage2.Controls.Add(this.gbNum);
            this.tabPage2.Controls.Add(this.btnSaveAlert);
            this.tabPage2.Controls.Add(this.gbFlux);
            this.tabPage2.Controls.Add(this.gbDir);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alerts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "to the listed temp.";
            // 
            // cbFlux
            // 
            this.cbFlux.AutoSize = true;
            this.cbFlux.Location = new System.Drawing.Point(33, 19);
            this.cbFlux.Name = "cbFlux";
            this.cbFlux.Size = new System.Drawing.Size(78, 17);
            this.cbFlux.TabIndex = 10;
            this.cbFlux.Text = "Fluctuation";
            this.cbFlux.UseVisualStyleBackColor = true;
            this.cbFlux.CheckedChanged += new System.EventHandler(this.cbFlux_CheckedChanged);
            // 
            // cbDir
            // 
            this.cbDir.AutoSize = true;
            this.cbDir.Location = new System.Drawing.Point(117, 19);
            this.cbDir.Name = "cbDir";
            this.cbDir.Size = new System.Drawing.Size(68, 17);
            this.cbDir.TabIndex = 11;
            this.cbDir.Text = "Direction";
            this.cbDir.UseVisualStyleBackColor = true;
            this.cbDir.CheckedChanged += new System.EventHandler(this.cbDir_CheckedChanged);
            // 
            // cbNum
            // 
            this.cbNum.AutoSize = true;
            this.cbNum.Location = new System.Drawing.Point(192, 19);
            this.cbNum.Name = "cbNum";
            this.cbNum.Size = new System.Drawing.Size(63, 17);
            this.cbNum.TabIndex = 12;
            this.cbNum.Text = "Number";
            this.cbNum.UseVisualStyleBackColor = true;
            this.cbNum.CheckedChanged += new System.EventHandler(this.cbNum_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbNum);
            this.groupBox4.Controls.Add(this.cbFlux);
            this.groupBox4.Controls.Add(this.cbDir);
            this.groupBox4.Location = new System.Drawing.Point(6, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 46);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alert Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 343);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TrangTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAlerts.ResumeLayout(false);
            this.gbAlerts.PerformLayout();
            this.gbDir.ResumeLayout(false);
            this.gbDir.PerformLayout();
            this.gbFlux.ResumeLayout(false);
            this.gbFlux.PerformLayout();
            this.gbNum.ResumeLayout(false);
            this.gbNum.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbInstructions;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ComboBox cbTempType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbAlerts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveAlert;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTempDirection;
        private System.Windows.Forms.GroupBox gbDir;
        private System.Windows.Forms.GroupBox gbFlux;
        private System.Windows.Forms.GroupBox gbNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAlertTimes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbNum;
        private System.Windows.Forms.CheckBox cbFlux;
        private System.Windows.Forms.CheckBox cbDir;
    }
}

