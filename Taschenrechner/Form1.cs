using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubtraktion_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = zahl1 - zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "-";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = zahl1 + zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "+";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = Math.Pow (zahl1, zahl2);
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "Hoch";
        }

        private void btnMultiplikation_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = zahl1 * zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "";
        }

        private void btnMaximum_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = Math.Max (zahl1, zahl2);
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "";
        }
    }
}