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
        Rechenoperator OPrechenoperator = new Rechenoperator();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubtraktion_Click(object sender, EventArgs e)
        {
            OPrechenoperator.Subtraktion(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OPrechenoperator.Addition(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OPrechenoperator.Potenz(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }

        private void btnMultiplikation_Click(object sender, EventArgs e)
        {
            OPrechenoperator.Multiplikation(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }

        private void btnMaximum_Click(object sender, EventArgs e)
        {
            OPrechenoperator.Maximum(txtOperand1, txtOperand2, lblErgebnis, lblOperator);
        }
    }
}