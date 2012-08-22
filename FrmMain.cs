using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Lucros
{
    public partial class FrmMain : Form
    {
        public FrmMain() {
            InitializeComponent();
        }

//        decimal moneyvalue = 1921.39m;
//string html = String.Format("Order Total: {0:C}", moneyvalue);
//Console.WriteLine(html);

        private void FrmMain_Load(object sender, EventArgs e) {
            lbRendimento.SelectedIndex = 1;
        }

        private void tbNumDays_Validating(object sender, CancelEventArgs e) {
    
            decimal value;
            TextBox tb = (TextBox)sender;

            if (tb.Text == "") {
                tb.Text = "0";
                return;
            }

            if (decimal.TryParse(tb.Text,NumberStyles.Currency, null, out value)) {
            // Do something with the value
            } else {
                MessageBox.Show("Formato inválido");
                e.Cancel = true;
            }
    
        }

        private void calculateNumDays(){

            TimeSpan ts = new TimeSpan();
            ts = (dtpEndDate.Value - dtpStartDate.Value);
            tbNumDays.Text = ts.Days.ToString();
        }

        private void calculateProfit() {
            try {
                txtProfit.Text = Convert.ToString(Convert.ToDouble(tbFinalValue.Text) - Convert.ToDouble(tbInitialValue.Text));
            } catch { };
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e) {
            calculateNumDays();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e) {
            calculateNumDays();
        }

        private void tbFinalValue_TextChanged(object sender, EventArgs e) {
            calculateProfit();
        }

        private void tbInitialValue_TextChanged(object sender, EventArgs e) {
            calculateProfit();
        }

        private void btEvaluate_Click(object sender, EventArgs e) {
            double interest, vi, vf, n;

            vi = Convert.ToDouble(tbInitialValue.Text);
            vf = Convert.ToDouble(tbFinalValue.Text);
            n = Convert.ToDouble(tbNumDays.Text) / 30;
            interest = (Math.Pow(vf / vi, 1 / n) - 1) * 100;
            txtInterest.Text = interest.ToString();
        }


    }
}
