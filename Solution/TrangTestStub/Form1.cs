using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TrangTestLib.Data;
using TrangTestLib.DataAccess;

namespace TrangTestStub
{
    public partial class Form1 : Form
    {
        private string validationMessage = "";
        TemperatureAlert editAlert;
        TrangTestLib.Thermometer thermometer = new TrangTestLib.Thermometer();
        private class DisplayItem
        {
            public string tempC;
            public string tempF;
            public string tempK;
        }

        List<DisplayItem> displayItems = new List<DisplayItem>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// adds custom event handlers
        /// </summary>
        private void AddEventHandlers()
        {
            thermometer.OutputTemps += Thermometer_OutputTemps;
            thermometer.RaiseAlert += Thermometer_RaiseAlert;
        }

        /// <summary>
        /// handles the interfaces part of raising an alert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Thermometer_RaiseAlert(object sender, TrangTestLib.AlertEventArgs e)
        {
            gbAlert.Visible = true;
            gbAlert.Text = "Alert: " + e.AlertName;
            txtAlertMessage.Text = System.Environment.NewLine + e.AlertMessage;
            txtAlertMessage.TextAlign = HorizontalAlignment.Center;
            txtAlertMessage.BackColor = Color.Red;
        }

        /// <summary>
        /// handles the interfaces part of Outputing Temperatures
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Thermometer_OutputTemps(object sender, TrangTestLib.OutputEventArgs e)
        {
            DisplayItem item = new DisplayItem();
            item.tempC = e.InputTemp.ConvertedTemperature("C");
            item.tempF = e.InputTemp.ConvertedTemperature("F");
            item.tempK = e.InputTemp.ConvertedTemperature("K");
            displayItems.Add(item);
            SetupOutputGrid();

        }

        /// <summary>
        /// sets up the output grid ti display converted temperatures
        /// </summary>
        private void SetupOutputGrid()
        {
            dgvOutput.DataSource = (from d in displayItems
                                    select new { d.tempC, d.tempF, d.tempK }).ToList();

            dgvOutput.Columns["tempC"].HeaderText = "Celsius";
            dgvOutput.Columns["tempF"].HeaderText = "Fahrenheit";
            dgvOutput.Columns["tempK"].HeaderText = "Kelvin";

            if(displayItems.Count > 0)
                dgvOutput.FirstDisplayedScrollingRowIndex = displayItems.Count - 1;
        }

        /// <summary>
        /// loads the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // load all the drop down values for alerts
            TrangTest data = TrangTestLib.Data.XMLOperations.ReadXML();

            var tempTypes = (from tt in data.TemperatureTypes select new TemperatureType(tt.TempType_ID)).ToList();
            cboTempType.DataSource = tempTypes;
            cboTempType.DisplayMember = "Indicator";
            cboTempType.ValueMember = "Id";

            cboTempDirection.Items.Add("rises");
            cboTempDirection.Items.Add("drops");

            cboAlertTimes.Items.Add("one");
            cboAlertTimes.Items.Add("every");

            SetupAlertsGrid();

            AddEventHandlers();
        }

        /// <summary>
        /// starts the save function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveAlert_Click(object sender, EventArgs e)
        {
            if(!IsValid)
            {
                ShowError(validationMessage);
                return;
            }
            else
            {
                if(editAlert == null)
                    SaveNewAlert();
                else
                    UpdateAlert();
                ClearForm();
                SetupAlertsGrid();
            }
        }

        /// <summary>
        /// saves an alert that was loaded for editing
        /// </summary>
        private void UpdateAlert()
        {
            // define the temperature threshold values
            editAlert.Threshold.Temperature = Convert.ToDouble(txtThresholdTemp.Text);
            editAlert.Threshold.TypeId = new TemperatureType(Convert.ToInt32(cboTempType.SelectedValue)).Id;
            editAlert.Threshold.Name = txtThresholdName.Text;
            // now define the alert values
            editAlert.Message = txtThresholdMessage.Text;
            if (cbFlux.Checked)
            {
                editAlert.MinimumFlucuation = Convert.ToDouble(txtThresholdFlux.Text);
            }
            else
                editAlert.MinimumFlucuation = 0;
            if (cbDir.Checked)
            {
                editAlert.Direction = cboTempDirection.SelectedItem.ToString().ToUpper().Substring(0, 1);
            }
            else
                editAlert.Direction = "";
            if (cbNum.Checked)
            {
                editAlert.Times = cboAlertTimes.SelectedItem.ToString().ToUpper().Substring(0, 1);
            }
            else
                editAlert.Times = "";
            editAlert.Update();
            editAlert = null;
        }

        /// <summary>
        /// saves a new alert
        /// </summary>
        private void SaveNewAlert()
        {
            // define the temperature threshold values
            TemperatureAlert newAlert = new TemperatureAlert();
            newAlert.Threshold.Temperature = Convert.ToDouble(txtThresholdTemp.Text);
            newAlert.Threshold.TypeId = new TemperatureType(Convert.ToInt32(cboTempType.SelectedValue)).Id;
            newAlert.Threshold.Name = txtThresholdName.Text;
            // now define the alert values
            newAlert.Message = txtThresholdMessage.Text;
            if (cbFlux.Checked)
            {
                newAlert.MinimumFlucuation = Convert.ToDouble(txtThresholdFlux.Text);
            }
            else
                newAlert.MinimumFlucuation = 0;
            if (cbDir.Checked)
            {
                newAlert.Direction = cboTempDirection.SelectedItem.ToString().ToUpper().Substring(0, 1);
            }
            else
                newAlert.Direction = "";
            if (cbNum.Checked)
            {
                newAlert.Times = cboAlertTimes.SelectedItem.ToString().ToUpper().Substring(0, 1);
            }
            else
                newAlert.Times = "";
            newAlert.Save();
        }

        /// <summary>
        /// checks all fields on the alerts infterface for valid data.
        /// </summary>
        private bool IsValid
        {
            get
            {
                // check all the data to make sure it's there and valid.
                // this could be done per field as the user exits, but this is a one-off
                bool valid = true;
                validationMessage = "The following sections have errors;\r\n";
                // first we need the threshold temperature
                if(!IsNumber(txtThresholdTemp.Text))
                {
                    valid = false;
                    validationMessage += "Threshold Temperature\r\n";
                }
                if(cboTempType.Text == "")
                {
                    valid = false;
                    validationMessage += "Threshold Temperature Type\r\n";
                }
                if(cbFlux.Checked)
                {
                    if(!IsNumber(txtThresholdFlux.Text))
                    {
                        valid = false;
                        validationMessage += "Minimum Fluctuation\r\n";
                    }
                }
                if(cbDir.Checked)
                {
                    if(cboTempDirection.Text == "")
                    {
                        valid = false;
                        validationMessage += "Direction\r\n";
                    }
                }
                if(cbNum.Checked)
                {
                    if(cboAlertTimes.Text == "")
                    {
                        valid = false;
                        validationMessage += "Number of Alerts\r\n";
                    }
                }

                return valid;
            }
        }

        /// <summary>
        /// checks if the input string is in fact a number
        /// </summary>
        /// <param name="_inputText">string to parse for a numerical value</param>
        /// <returns></returns>
        private bool IsNumber(string _inputText)
        {
            try
            {
                decimal maybeNumber = Convert.ToDecimal(_inputText);
                return true;
            }
            catch(Exception x)
            {
                return false;
            }
        }

        /// <summary>
        /// enables/disables the groubox associated with number of times alerted data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbNum_CheckedChanged(object sender, EventArgs e)
        {
            gbNum.Enabled = cbNum.Checked;
        }

        /// <summary>
        /// enables/disables the groubox associated with direction data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbDir_CheckedChanged(object sender, EventArgs e)
        {
            gbDir.Enabled = cbDir.Checked;
        }

        /// <summary>
        /// enables/disables the groupbox associated with Fluctuation data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFlux_CheckedChanged(object sender, EventArgs e)
        {
            gbFlux.Enabled = cbFlux.Checked;
        }

        /// <summary>
        /// loads an alert for editing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditAlert_Click(object sender, EventArgs e)
        {
            if (dgvAlerts.SelectedRows.Count == 1)
            {
                try
                {
                    int itemToEdit = Convert.ToInt32(dgvAlerts.SelectedRows[0].Cells["TempAlert_ID"].Value);
                    editAlert = new TemperatureAlert(itemToEdit);
                    TemperatureThreshold alertThreshold = new TemperatureThreshold(editAlert.Threshold.Id);
                    // now load the interface with the values
                    txtThresholdTemp.Text = alertThreshold.Temperature.ToString();
                    TemperatureType t = new TemperatureType(alertThreshold.TypeId);
                    SelectItem(cboTempType, t.Indicator);
                    txtThresholdName.Text = alertThreshold.Name;
                    if (editAlert.MinimumFlucuation > 0)
                    {
                        cbFlux.Checked = true;
                        txtThresholdFlux.Text = editAlert.MinimumFlucuation.ToString();
                    }
                    if (editAlert.Times != "")
                    {
                        cbNum.Checked = true;
                        SelectItem(cboAlertTimes, editAlert.Times);
                    }
                    if (editAlert.Direction != "")
                    {
                        cbDir.Checked = true;
                        SelectItem(cboTempDirection, editAlert.Direction);
                    }
                    txtThresholdMessage.Text = editAlert.Message;
                }
                catch (Exception x)
                {
                    ShowError(x.Message);
                    return;
                }
            }
            else
                ShowError("You must select an alerts row.");
        }

        /// <summary>
        /// finds the passed item in the passed control and selects it.
        /// </summary>
        /// <param name="_control">ComboBox control to search in</param>
        /// <param name="_itemToSelect">single character string to match on the first character of the combobox entry</param>
        private void SelectItem(ComboBox _control, string _itemToSelect)
        {
            foreach (object item in _control.Items)
            {
                if (item.ToString().Substring(0, 1).ToUpper() == _itemToSelect)
                {
                    _control.SelectedItem = item;
                    break;
                }
            }
        }

        /// <summary>
        /// deletes an alert from the dataset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAlert_Click(object sender, EventArgs e)
        {
            if (dgvAlerts.SelectedRows.Count == 1)
            {
                try
                {
                    int itemToDelete = Convert.ToInt32(dgvAlerts.SelectedRows[0].Cells["TempAlert_ID"].Value);
                    TrangTest db = TrangTestLib.Data.XMLOperations.ReadXML();
                    TrangTest.TemperatureAlertsRow rowToDelete = db.TemperatureAlerts.First(ar => ar.TempAlert_ID == itemToDelete);
                    TrangTest.TemperatureThresholdsRow tempToDelete = db.TemperatureThresholds.First(tt => tt.TempThreshold_ID == rowToDelete.TempAlert_ThresholdID);
                    db.TemperatureAlerts.RemoveTemperatureAlertsRow(rowToDelete);
                    db.TemperatureThresholds.RemoveTemperatureThresholdsRow(tempToDelete);
                    db.AcceptChanges();
                    XMLOperations.WriteXML(db);
                    SetupAlertsGrid();
                }
                catch(Exception x)
                {
                    ShowError(x.Message);
                    return;
                }
            }
            else
                ShowError("You must select an alerts row.");
        }

        /// <summary>
        /// displays the alerts in the grid for the user to view
        /// </summary>
        private void SetupAlertsGrid()
        {
            TrangTest data = TrangTestLib.Data.XMLOperations.ReadXML();
            var alerts = (from at in data.TemperatureAlerts
                          join tt in data.TemperatureThresholds on at.TempAlert_ThresholdID equals tt.TempThreshold_ID
                          join t in data.TemperatureTypes on tt.TempThreshold_TypeID equals t.TempType_ID
                          select new {
                              at.TempAlert_ID,
                              tt.TempThreshold_Name,
                              tt.TempThreshold_Value,
                              t.TempType_Indicator,
                              at.TempAlert_MinFluctuation,
                              at.TempAlert_Direction,
                              at.TempAlert_Times
                          }).ToList();
            dgvAlerts.DataSource = alerts;

            dgvAlerts.Columns["TempAlert_ID"].HeaderText = "ID";
            dgvAlerts.Columns["TempThreshold_Name"].HeaderText = "Threshold Name";
            dgvAlerts.Columns["TempThreshold_Value"].HeaderText = "Temp";
            dgvAlerts.Columns["TempType_Indicator"].HeaderText = "Temp Type";
            dgvAlerts.Columns["TempAlert_MinFluctuation"].HeaderText = "Min. Fluc.";
            dgvAlerts.Columns["TempAlert_Direction"].HeaderText = "Dir";
            dgvAlerts.Columns["TempAlert_Times"].HeaderText = "Once/Every";


        }

        /// <summary>
        /// clears the form
        /// </summary>
        private void ClearForm()
        {
            cbNum.Checked = false;
            cbDir.Checked = false;
            cbFlux.Checked = false;
            cboAlertTimes.SelectedItem = null;
            cboTempDirection.SelectedItem = null;
            cboTempType.SelectedValue = 1;
            txtThresholdFlux.Text = "";
            txtThresholdMessage.Text = "";
            txtThresholdName.Text = "";
            txtThresholdTemp.Text = "";
        }

        /// <summary>
        /// this method shows a generic popup error message, with the red circle and X icon
        /// </summary>
        /// <param name="_message">the message to display</param>
        private void ShowError(string _message)
        {
            MessageBox.Show(_message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// this method shows a generic popup message with the information icon
        /// </summary>
        /// <param name="_message">the message to display</param>
        private void ShowMessage(string _message)
        {
            MessageBox.Show(_message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// runs the main purpose of the application, converts and tests the temperatures listed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                DisableInputs();
                if (IsNumber(txtDelay.Text))
                {
                    displayItems.Clear();
                    string[] temps = txtTestTemps.Text.Split(System.Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    foreach (string t in temps)
                    {
                        gbAlert.Visible = false;
                        thermometer.InputTemperature(t.ToUpper());
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(Convert.ToInt32(Math.Round(Convert.ToDecimal(txtDelay.Text) * 1000)));
                    }
                    ShowMessage("Done.");
                }
                else
                {
                    ShowError("You must have a number in the delay field.");
                }
            }
            catch(Exception x)
            {
                ShowError($"Error:{x.Message}");
            }
            finally
            {
                EnableInputs();
            }
        }

        /// <summary>
        /// this method will disable text inputs during execution
        /// </summary>
        private void DisableInputs()
        {

            txtDelay.Enabled = false;
            txtTestTemps.Enabled = false;
        }

        /// <summary>
        /// this method will enable text inputs once exection completes
        /// </summary>
        private void EnableInputs()
        {
            txtDelay.Enabled = true;
            txtTestTemps.Enabled = true;
        }


    }
}
