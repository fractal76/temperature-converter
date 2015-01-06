using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TempConverterClient.TempConversionService;

namespace TempConverterClient
{
    public partial class frmTempConverterClient : Form
    {
        public frmTempConverterClient()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTempConverterClient_Load(object sender, EventArgs e)
        {
            cbxFrom.SelectedIndex = 0;
            cbxTo.SelectedIndex = 1;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var client = new WebService1SoapClient();
            string from = cbxFrom.SelectedItem.ToString();
            string to = cbxTo.SelectedItem.ToString();
            float value;
            if (!Single.TryParse(txtValue.Text, out value))
            {
                MessageBox.Show("Please enter a valid temperature.", "Invalid Temperature");
            }
            if (from == "Celsius" && to == "Farenheit")
            {
                txtResult.Text = client.CtoF(value).ToString();
            }
            if (from == "Farenheit" && to == "Celsius")
            {
                txtResult.Text = client.FtoC(value).ToString();
            }
            if (from == "Celsius" && to == "Kelvin")
            {
                txtResult.Text = client.CtoK(value).ToString();
            }
            if (from == "Kelvin" && to == "Celsius")
            {
                txtResult.Text = client.KtoC(value).ToString();
            }
            if (from == "Farenheit" && to == "Kelvin")
            {
                txtResult.Text = client.FtoK(value).ToString();
            }
            if (from == "Kelvin" && to == "Farenheit")
            {
                txtResult.Text = client.KtoF(value).ToString();
            }
            if (from == to)
            {
                txtResult.Text = txtValue.Text;
            }
        }
    }
}
