using System;
using System.Windows.Forms;

namespace AB03_Standardevents
{
    public partial class Form1 : Form
    {
        Info information = new Info();
        public Form1()
        {
            InitializeComponent();
        }
        // Alle MouseClick events..
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            txtOutput.Text += "Klick" + Environment.NewLine;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtOutput.Text += "Doppelklick" + Environment.NewLine;
        }
        // Alle Mousebutton Runter events mit txtOutput.text
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    txtOutput.Text += "Linker Mausbutton Runter" + Environment.NewLine;
                    break;
                case MouseButtons.Right:
                    txtOutput.Text += "Rechter Mausbutton Runter" + Environment.NewLine;
                    break;
                case MouseButtons.Middle:
                    txtOutput.Text += "Mittler Mausbutton Runter" + Environment.NewLine;
                    break;
            }
        }
        // Alle Mousebutton Hoch events mit txtOutput.text
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    txtOutput.Text += "Linker Mausbutton Hoch" + Environment.NewLine;
                    break;
                case MouseButtons.Right:
                    txtOutput.Text += "Rechter Mausbutton Hoch" + Environment.NewLine;
                    break;
                case MouseButtons.Middle:
                    txtOutput.Text += "Mittler Mausbutton Hoch" + Environment.NewLine;
                    break;
            }
        }
        // Alle Tasten(keys) Events mit txtOutput.text
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            txtOutput.Text += "Taste Runter" + Environment.NewLine;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            txtOutput.Text += "Taste Hoch" + Environment.NewLine;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtOutput.Text += e.KeyChar + " - Gedrückt" + Environment.NewLine;
        }
        //Klick auf Information für form "Info"
        private void btnInfos_Click(object sender, EventArgs e)
        {
            information.Show();
        }
    }
}