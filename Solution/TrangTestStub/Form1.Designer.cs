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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.cboTempType = new System.Windows.Forms.ComboBox();
            this.txtThresholdTemp = new System.Windows.Forms.TextBox();
            this.gbAlerts = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbNum = new System.Windows.Forms.CheckBox();
            this.cbFlux = new System.Windows.Forms.CheckBox();
            this.cbDir = new System.Windows.Forms.CheckBox();
            this.txtThresholdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThresholdMessage = new System.Windows.Forms.TextBox();
            this.btnSaveAlert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThresholdFlux = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTempDirection = new System.Windows.Forms.ComboBox();
            this.gbDir = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbFlux = new System.Windows.Forms.GroupBox();
            this.gbNum = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboAlertTimes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.gbAlert = new System.Windows.Forms.GroupBox();
            this.txtAlertMessage = new System.Windows.Forms.TextBox();
            this.txtTestTemps = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteAlert = new System.Windows.Forms.Button();
            this.btnEditAlert = new System.Windows.Forms.Button();
            this.gbGrid = new System.Windows.Forms.GroupBox();
            this.dgvAlerts = new System.Windows.Forms.DataGridView();
            this.gbAlerts.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbDir.SuspendLayout();
            this.gbFlux.SuspendLayout();
            this.gbNum.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.gbAlert.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.SystemColors.Window;
            this.txtInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInstructions.Location = new System.Drawing.Point(8, 6);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(287, 98);
            this.txtInstructions.TabIndex = 1;
            this.txtInstructions.Text = resources.GetString("txtInstructions.Text");
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(8, 293);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(287, 25);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "TEST!";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cboTempType
            // 
            this.cboTempType.CausesValidation = false;
            this.cboTempType.FormattingEnabled = true;
            this.cboTempType.Location = new System.Drawing.Point(230, 12);
            this.cboTempType.Name = "cboTempType";
            this.cboTempType.Size = new System.Drawing.Size(42, 21);
            this.cboTempType.TabIndex = 1;
            // 
            // txtThresholdTemp
            // 
            this.txtThresholdTemp.CausesValidation = false;
            this.txtThresholdTemp.Location = new System.Drawing.Point(164, 13);
            this.txtThresholdTemp.Name = "txtThresholdTemp";
            this.txtThresholdTemp.Size = new System.Drawing.Size(60, 20);
            this.txtThresholdTemp.TabIndex = 0;
            // 
            // gbAlerts
            // 
            this.gbAlerts.Controls.Add(this.groupBox4);
            this.gbAlerts.Controls.Add(this.txtThresholdName);
            this.gbAlerts.Controls.Add(this.label2);
            this.gbAlerts.Controls.Add(this.label1);
            this.gbAlerts.Controls.Add(this.txtThresholdMessage);
            this.gbAlerts.Controls.Add(this.txtThresholdTemp);
            this.gbAlerts.Controls.Add(this.cboTempType);
            this.gbAlerts.Location = new System.Drawing.Point(8, 6);
            this.gbAlerts.Name = "gbAlerts";
            this.gbAlerts.Size = new System.Drawing.Size(279, 184);
            this.gbAlerts.TabIndex = 5;
            this.gbAlerts.TabStop = false;
            this.gbAlerts.Text = "Alert Info";
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
            // cbNum
            // 
            this.cbNum.AutoSize = true;
            this.cbNum.CausesValidation = false;
            this.cbNum.Location = new System.Drawing.Point(192, 19);
            this.cbNum.Name = "cbNum";
            this.cbNum.Size = new System.Drawing.Size(63, 17);
            this.cbNum.TabIndex = 6;
            this.cbNum.Text = "Number";
            this.cbNum.UseVisualStyleBackColor = true;
            this.cbNum.CheckedChanged += new System.EventHandler(this.cbNum_CheckedChanged);
            // 
            // cbFlux
            // 
            this.cbFlux.AutoSize = true;
            this.cbFlux.CausesValidation = false;
            this.cbFlux.Location = new System.Drawing.Point(33, 19);
            this.cbFlux.Name = "cbFlux";
            this.cbFlux.Size = new System.Drawing.Size(78, 17);
            this.cbFlux.TabIndex = 4;
            this.cbFlux.Text = "Fluctuation";
            this.cbFlux.UseVisualStyleBackColor = true;
            this.cbFlux.CheckedChanged += new System.EventHandler(this.cbFlux_CheckedChanged);
            // 
            // cbDir
            // 
            this.cbDir.AutoSize = true;
            this.cbDir.CausesValidation = false;
            this.cbDir.Location = new System.Drawing.Point(117, 19);
            this.cbDir.Name = "cbDir";
            this.cbDir.Size = new System.Drawing.Size(68, 17);
            this.cbDir.TabIndex = 5;
            this.cbDir.Text = "Direction";
            this.cbDir.UseVisualStyleBackColor = true;
            this.cbDir.CheckedChanged += new System.EventHandler(this.cbDir_CheckedChanged);
            // 
            // txtThresholdName
            // 
            this.txtThresholdName.CausesValidation = false;
            this.txtThresholdName.Location = new System.Drawing.Point(152, 36);
            this.txtThresholdName.Name = "txtThresholdName";
            this.txtThresholdName.Size = new System.Drawing.Size(120, 20);
            this.txtThresholdName.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "When the temperature reaches";
            // 
            // txtThresholdMessage
            // 
            this.txtThresholdMessage.CausesValidation = false;
            this.txtThresholdMessage.Location = new System.Drawing.Point(5, 62);
            this.txtThresholdMessage.Multiline = true;
            this.txtThresholdMessage.Name = "txtThresholdMessage";
            this.txtThresholdMessage.Size = new System.Drawing.Size(267, 62);
            this.txtThresholdMessage.TabIndex = 3;
            // 
            // btnSaveAlert
            // 
            this.btnSaveAlert.Location = new System.Drawing.Point(29, 196);
            this.btnSaveAlert.Name = "btnSaveAlert";
            this.btnSaveAlert.Size = new System.Drawing.Size(200, 24);
            this.btnSaveAlert.TabIndex = 10;
            this.btnSaveAlert.Text = "Save Alert";
            this.btnSaveAlert.UseVisualStyleBackColor = true;
            this.btnSaveAlert.Click += new System.EventHandler(this.btnSaveAlert_Click);
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
            // txtThresholdFlux
            // 
            this.txtThresholdFlux.CausesValidation = false;
            this.txtThresholdFlux.Location = new System.Drawing.Point(233, 32);
            this.txtThresholdFlux.Name = "txtThresholdFlux";
            this.txtThresholdFlux.Size = new System.Drawing.Size(84, 20);
            this.txtThresholdFlux.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "degrees.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Alert me only if the temperature ";
            // 
            // cboTempDirection
            // 
            this.cboTempDirection.CausesValidation = false;
            this.cboTempDirection.FormattingEnabled = true;
            this.cboTempDirection.Location = new System.Drawing.Point(167, 13);
            this.cboTempDirection.Name = "cboTempDirection";
            this.cboTempDirection.Size = new System.Drawing.Size(97, 21);
            this.cboTempDirection.TabIndex = 8;
            // 
            // gbDir
            // 
            this.gbDir.Controls.Add(this.label8);
            this.gbDir.Controls.Add(this.cboTempDirection);
            this.gbDir.Controls.Add(this.label5);
            this.gbDir.Enabled = false;
            this.gbDir.Location = new System.Drawing.Point(293, 80);
            this.gbDir.Name = "gbDir";
            this.gbDir.Size = new System.Drawing.Size(379, 50);
            this.gbDir.TabIndex = 6;
            this.gbDir.TabStop = false;
            this.gbDir.Text = "Direction";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "to the listed temp.";
            // 
            // gbFlux
            // 
            this.gbFlux.Controls.Add(this.label4);
            this.gbFlux.Controls.Add(this.label3);
            this.gbFlux.Controls.Add(this.txtThresholdFlux);
            this.gbFlux.Enabled = false;
            this.gbFlux.Location = new System.Drawing.Point(293, 6);
            this.gbFlux.Name = "gbFlux";
            this.gbFlux.Size = new System.Drawing.Size(377, 68);
            this.gbFlux.TabIndex = 7;
            this.gbFlux.TabStop = false;
            this.gbFlux.Text = "Minimum Fluctuation";
            // 
            // gbNum
            // 
            this.gbNum.Controls.Add(this.label7);
            this.gbNum.Controls.Add(this.cboAlertTimes);
            this.gbNum.Controls.Add(this.label6);
            this.gbNum.Enabled = false;
            this.gbNum.Location = new System.Drawing.Point(293, 136);
            this.gbNum.Name = "gbNum";
            this.gbNum.Size = new System.Drawing.Size(377, 54);
            this.gbNum.TabIndex = 8;
            this.gbNum.TabStop = false;
            this.gbNum.Text = "Number of Alerts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "time the threshold is reached.";
            // 
            // cboAlertTimes
            // 
            this.cboAlertTimes.CausesValidation = false;
            this.cboAlertTimes.FormattingEnabled = true;
            this.cboAlertTimes.Location = new System.Drawing.Point(51, 17);
            this.cboAlertTimes.Name = "cboAlertTimes";
            this.cboAlertTimes.Size = new System.Drawing.Size(118, 21);
            this.cboAlertTimes.TabIndex = 9;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 446);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtDelay);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.gbOutput);
            this.tabPage1.Controls.Add(this.gbAlert);
            this.tabPage1.Controls.Add(this.txtTestTemps);
            this.tabPage1.Controls.Add(this.txtInstructions);
            this.tabPage1.Controls.Add(this.btnTest);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TemperatureTest";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "seconds.";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(152, 147);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(48, 20);
            this.txtDelay.TabIndex = 7;
            this.txtDelay.Text = "5";
            this.txtDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Display each reading for";
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.dgvOutput);
            this.gbOutput.Location = new System.Drawing.Point(302, 7);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(368, 405);
            this.gbOutput.TabIndex = 5;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOutput.Location = new System.Drawing.Point(3, 16);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.Size = new System.Drawing.Size(362, 386);
            this.dgvOutput.TabIndex = 0;
            // 
            // gbAlert
            // 
            this.gbAlert.Controls.Add(this.txtAlertMessage);
            this.gbAlert.Location = new System.Drawing.Point(8, 321);
            this.gbAlert.Name = "gbAlert";
            this.gbAlert.Size = new System.Drawing.Size(287, 91);
            this.gbAlert.TabIndex = 4;
            this.gbAlert.TabStop = false;
            this.gbAlert.Text = "Alert";
            this.gbAlert.Visible = false;
            // 
            // txtAlertMessage
            // 
            this.txtAlertMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAlertMessage.Location = new System.Drawing.Point(3, 16);
            this.txtAlertMessage.Multiline = true;
            this.txtAlertMessage.Name = "txtAlertMessage";
            this.txtAlertMessage.Size = new System.Drawing.Size(281, 72);
            this.txtAlertMessage.TabIndex = 0;
            this.txtAlertMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTestTemps
            // 
            this.txtTestTemps.Location = new System.Drawing.Point(8, 102);
            this.txtTestTemps.Multiline = true;
            this.txtTestTemps.Name = "txtTestTemps";
            this.txtTestTemps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTestTemps.Size = new System.Drawing.Size(104, 186);
            this.txtTestTemps.TabIndex = 3;
            this.txtTestTemps.Text = "1.5 C\r\n1.0 C\r\n0.5 C\r\n0.0 C\r\n-0.5 C\r\n0.0 C\r\n-0.5 C\r\n0.0 C\r\n0.5 C\r\n0.0 C";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeleteAlert);
            this.tabPage2.Controls.Add(this.btnEditAlert);
            this.tabPage2.Controls.Add(this.gbGrid);
            this.tabPage2.Controls.Add(this.gbAlerts);
            this.tabPage2.Controls.Add(this.gbNum);
            this.tabPage2.Controls.Add(this.btnSaveAlert);
            this.tabPage2.Controls.Add(this.gbFlux);
            this.tabPage2.Controls.Add(this.gbDir);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alerts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAlert
            // 
            this.btnDeleteAlert.Location = new System.Drawing.Point(441, 196);
            this.btnDeleteAlert.Name = "btnDeleteAlert";
            this.btnDeleteAlert.Size = new System.Drawing.Size(200, 24);
            this.btnDeleteAlert.TabIndex = 12;
            this.btnDeleteAlert.Text = "Delete Alert";
            this.btnDeleteAlert.UseVisualStyleBackColor = true;
            this.btnDeleteAlert.Click += new System.EventHandler(this.btnDeleteAlert_Click);
            // 
            // btnEditAlert
            // 
            this.btnEditAlert.Location = new System.Drawing.Point(235, 196);
            this.btnEditAlert.Name = "btnEditAlert";
            this.btnEditAlert.Size = new System.Drawing.Size(200, 24);
            this.btnEditAlert.TabIndex = 11;
            this.btnEditAlert.Text = "Edit Alert";
            this.btnEditAlert.UseVisualStyleBackColor = true;
            this.btnEditAlert.Click += new System.EventHandler(this.btnEditAlert_Click);
            // 
            // gbGrid
            // 
            this.gbGrid.Controls.Add(this.dgvAlerts);
            this.gbGrid.Location = new System.Drawing.Point(8, 220);
            this.gbGrid.Name = "gbGrid";
            this.gbGrid.Size = new System.Drawing.Size(662, 192);
            this.gbGrid.TabIndex = 9;
            this.gbGrid.TabStop = false;
            this.gbGrid.Text = "Alerts";
            // 
            // dgvAlerts
            // 
            this.dgvAlerts.AllowUserToAddRows = false;
            this.dgvAlerts.AllowUserToDeleteRows = false;
            this.dgvAlerts.AllowUserToResizeColumns = false;
            this.dgvAlerts.AllowUserToResizeRows = false;
            this.dgvAlerts.CausesValidation = false;
            this.dgvAlerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlerts.Location = new System.Drawing.Point(3, 16);
            this.dgvAlerts.Name = "dgvAlerts";
            this.dgvAlerts.ReadOnly = true;
            this.dgvAlerts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAlerts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlerts.ShowEditingIcon = false;
            this.dgvAlerts.Size = new System.Drawing.Size(656, 173);
            this.dgvAlerts.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 446);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAlerts.ResumeLayout(false);
            this.gbAlerts.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbDir.ResumeLayout(false);
            this.gbDir.PerformLayout();
            this.gbFlux.ResumeLayout(false);
            this.gbFlux.PerformLayout();
            this.gbNum.ResumeLayout(false);
            this.gbNum.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.gbAlert.ResumeLayout(false);
            this.gbAlert.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ComboBox cboTempType;
        private System.Windows.Forms.TextBox txtThresholdTemp;
        private System.Windows.Forms.GroupBox gbAlerts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveAlert;
        private System.Windows.Forms.TextBox txtThresholdMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThresholdFlux;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThresholdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTempDirection;
        private System.Windows.Forms.GroupBox gbDir;
        private System.Windows.Forms.GroupBox gbFlux;
        private System.Windows.Forms.GroupBox gbNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboAlertTimes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbNum;
        private System.Windows.Forms.CheckBox cbFlux;
        private System.Windows.Forms.CheckBox cbDir;
        private System.Windows.Forms.TextBox txtTestTemps;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.GroupBox gbAlert;
        private System.Windows.Forms.GroupBox gbGrid;
        private System.Windows.Forms.Button btnDeleteAlert;
        private System.Windows.Forms.Button btnEditAlert;
        private System.Windows.Forms.DataGridView dgvAlerts;
        private System.Windows.Forms.TextBox txtAlertMessage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label9;
    }
}

