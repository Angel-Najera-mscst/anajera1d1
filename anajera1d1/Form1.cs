using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anajera1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.715566";
            txtAmountBhutaese.Text = "0.00";
            txtRateBhutaese.Text = "0.0139087";
            txtAmountCostaRica.Text = "0.00";
            txtRateCostaRica.Text = "0.00172946";
            txtAmountEurope.Text = "0.00";
            txtRateEurope.Text = "1.16302";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            NewMethod1();
        }

        private void NewMethod1() => Close();

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                Convert.ToDecimal(txtAmountAustralia.Text) * Convert.ToDecimal(txtRateAustralia.Text)
                ).ToString("0.00");
        }

        private void bhutaeseTextChanged(object sender, EventArgs e)
        {
            txtUSDBhutaese.Text = (
               Convert.ToDecimal(txtAmountBhutaese.Text) * Convert.ToDecimal(txtRateBhutaese.Text)
               ).ToString("0.00");
        }

        private void costaricaTextChanged(object sender, EventArgs e)
        {
            txtUSDCostaRica.Text = (
               Convert.ToDecimal(txtAmountCostaRica.Text) * Convert.ToDecimal(txtRateCostaRica.Text)
               ).ToString("0.00");
        }

        private void europeTextChanged(object sender, EventArgs e)
        {
            txtUSDEurope.Text = (
                           Convert.ToDecimal(txtAmountEurope.Text) * Convert.ToDecimal(txtRateEurope.Text)
                           ).ToString("0.00");
        }

        private void txtUSDBhutaese_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUSDCostaRica_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUSDEurope_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUSD_TextChanged(object sender, EventArgs e)
        {

        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDAustralia.Text) + Convert.ToDecimal(txtUSDBhutaese.Text) + Convert.ToDecimal(txtUSDCostaRica.Text) + Convert.ToDecimal(txtUSDEurope.Text)
).ToString("0.00");
        }
    }
}
