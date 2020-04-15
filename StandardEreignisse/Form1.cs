using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardEreignisse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            txtAusgabe.Text += "Klick" + Environment.NewLine;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtAusgabe.Text += "DoppelKlick" + Environment.NewLine;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                    txtAusgabe.Text += "Keytaste Runter" + Environment.NewLine;
            }
            txtAusgabe.Text += "Taste runter" + Environment.NewLine;
        }
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    txtAusgabe.Text += ("linke Maustaste Runter")
                                       + Environment.NewLine;
                    break;
                case MouseButtons.Right:
                    txtAusgabe.Text += ("rechte Maustaste Runter") + Environment.NewLine;
                    break;
                case MouseButtons.Middle:
                    txtAusgabe.Text += ("mittlere Maustaste Runter") + Environment.NewLine;
                    break;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    txtAusgabe.Text += ("linke Maustaste Hoch") + Environment.NewLine;
                    break;
                case MouseButtons.Right:
                    txtAusgabe.Text += ("rechte Maustaste Hoch") + Environment.NewLine;
                    break;
                case MouseButtons.Middle:
                    txtAusgabe.Text += ("mittlere Maustaste Hoch") + Environment.NewLine;
                    break;
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            txtAusgabe.Text += ("Key Hoch gehalten");
        }
    }
}