using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrangTestLib.Data;
using TrangTestLib.DataAccess;

namespace TrangTestStub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load all the drop down values for alerts
            TrangTest data = TrangTestLib.Data.XMLOperations.ReadXML();

            var tempTypes = (from tt in data.TemperatureTypes select new TemperatureType(tt.TempType_ID)).ToList();
            cbTempType.DataSource = tempTypes;
            cbTempType.DisplayMember = "Indicator";
            cbTempType.ValueMember = "Id";

            cbTempDirection.Items.Add("rises");
            cbTempDirection.Items.Add("drops");

            cbAlertTimes.Items.Add("one");
            cbAlertTimes.Items.Add("every");
        }

        private void btnSaveAlert_Click(object sender, EventArgs e)
        {

        }

        private void cbNum_CheckedChanged(object sender, EventArgs e)
        {
            gbNum.Enabled = cbNum.Checked;
        }

        private void cbDir_CheckedChanged(object sender, EventArgs e)
        {
            gbDir.Enabled = cbDir.Checked;
        }

        private void cbFlux_CheckedChanged(object sender, EventArgs e)
        {
            gbFlux.Enabled = cbFlux.Checked;
        }
    }
}
