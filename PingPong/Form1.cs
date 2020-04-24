using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        Scoreboard scrboard = new Scoreboard();
        private int directionX = 5;
        private int directionY = 2;
        private int points = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSpiel.Start();
            points = 0;
            txtPunkte.Text = Convert.ToString(points);
            picBall.Location = new Point(250, 64);
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            //ball Bewegung
            picBall.Location = new Point(picBall.Location.X + directionX, picBall.Location.Y + directionY);
            // Wenn 0-407 >= 398) && (0-253 >= 0-223) && (0-238 <= 0-263) wenn die Values alle "true" sind sollte der Ball vom schläger abstossen.
            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width - picSchlägerRechts.Width
                && picBall.Location.Y + picBall.Height >= picSchlägerRechts.Location.Y
                && picBall.Location.Y <= picSchlägerRechts.Location.Y + picSchlägerRechts.Height)
            {
                directionX = -directionX;
                points += 10;
            }

            // Spielvorbei Screen erstellen
            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width)
            {
                tmrSpiel.Stop();
                scrboard.SetPoints(points);

                // Scoreboard anzeigen
                scrboard.ShowScoreboard();
                scrboard.Show();

            }

            // Ball trifft die Linke Wandfläche
            if (picBall.Location.X <= 0)
            {
                directionX = -directionX;
            }

            // Ball trifft die obere Wandfläche
            if (picBall.Location.Y >= pnlSpiel.Height - picBall.Height)
            {
                directionY = -directionY;
            }

            // Ball trifft untere Wandfläche
            if (picBall.Location.Y < 0)
            {
                directionY = -directionY;
            }

            // Punktezähler 
            txtPunkte.Text = Convert.ToString(points);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Schläger ganz rechts ans Panel setzen
            picSchlägerRechts.Location = new Point(pnlSpiel.Width - picSchlägerRechts.Width, pnlSpiel.Height / 2);
            vsbSchlägerRechts.Height = pnlSpiel.Height;
            vsbSchlägerRechts.Location = new Point(pnlSpiel.Location.X + pnlSpiel.Width, pnlSpiel.Location.Y);
            vsbSchlägerRechts.Minimum = 0;
            vsbSchlägerRechts.Maximum = pnlSpiel.Height - picSchlägerRechts.Height + vsbSchlägerRechts.LargeChange;
            vsbSchlägerRechts.Value = picSchlägerRechts.Location.Y;

            picBall.Location = new Point(250, 64);
            KnöpfeSichtbar(true);
        }

        // Scrollbar rechts neben Panel setzen, Maximal und Minimalwert und aktuellen Wert einstellen
        private void vsbSchlägerRechts_Scroll(object sender, ScrollEventArgs e)
        {
            picSchlägerRechts.Location = new Point(picSchlägerRechts.Location.X, vsbSchlägerRechts.Value);
            vsbSchlägerRechts.Value = picSchlägerRechts.Location.Y;
        }


        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (rdbSchläger.Checked)
            {
            }

            switch (keyData)
            {
                case Keys.Up:
                    picBall.Location = new Point(picBall.Location.X + 0, picBall.Location.Y - 25);
                    return true;
                case Keys.Down:
                    picBall.Location = new Point(picBall.Location.X + 0, picBall.Location.Y + 25);
                    return true;
                case Keys.Left:
                    picBall.Location = new Point(picBall.Location.X - 25, picBall.Location.Y + 0);
                    return true;
                case Keys.Right:
                    picBall.Location = new Point(picBall.Location.X + 25, picBall.Location.Y + 0);
                    return true;
                default:
                    return base.ProcessDialogKey(keyData);
            }
        }

        // Ballbewegung via Pfeiltasten
        private void rdbBall_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.H:
                    if (directionY > directionX)
                    {
                        directionX = +directionX;
                        directionY = -directionY;
                    }
                    else
                    {
                        directionX = -directionX;
                        directionY = +directionY;
                    }

                    break;
                case Keys.V:
                    if (directionX > directionY)
                    {
                        directionX = +directionX;
                        directionY = -directionY;
                    }
                    else
                    {
                        directionX = -directionX;
                        directionY = +directionY;
                    }

                    break;
                case Keys.P:
                    tmrSpiel.Stop();
                    break;
                case Keys.S:
                    tmrSpiel.Start();
                    break;
            }
        }

        private void btnHoch_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(picBall.Location.X + 0, picBall.Location.Y - 25);
        }

        private void btnLinks_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(picBall.Location.X - 25, picBall.Location.Y + 0);
        }

        private void btnRechts_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(picBall.Location.X + 25, picBall.Location.Y + 0);
        }

        private void btnRunter_Click(object sender, EventArgs e)
        {
            picBall.Location = new Point(picBall.Location.X + 0, picBall.Location.Y + 25);
        }

        private void rdbSchläger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSchläger.Checked)
            {
                vsbSchlägerRechts.Visible = true;
                KnöpfeSichtbar(false);
            }
        }

        private void rdbBall_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBall.Checked)
            {
                vsbSchlägerRechts.Visible = false;
                KnöpfeSichtbar(true);
            }
        }

        private void KnöpfeSichtbar(bool Sichtbar)
        {
            if (Sichtbar)
            {
                btnHoch.Visible = true;
                btnRunter.Visible = true;
                btnRechts.Visible = true;
                btnLinks.Visible = true;
            }
            else
            {
                btnHoch.Visible = false;
                btnRunter.Visible = false;
                btnRechts.Visible = false;
                btnLinks.Visible = false;
            }
        }
}
}
