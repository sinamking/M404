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
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            //ball movement
            picBall.Location = new Point(picBall.Location.X + directionX, picBall.Location.Y + directionY);
            //ball hits right wall
            if (picBall.Location.X >= pnlSpiel.Width - picBall.Width - picSchlägerRechts.Width
                && picBall.Location.Y + picBall.Height >= picSchlägerRechts.Location.Y
                && picBall.Location.Y <= picSchlägerRechts.Location.Y + picSchlägerRechts.Height)
            {
            
                directionX = -directionX;
            }

            // Ball hits left wall
            if (picBall.Location.X <= 0)
            {
                directionX = -directionX;
            }

            // Ball hits upper wall
            if (picBall.Location.Y >= pnlSpiel.Height - picBall.Height)
            {
                directionY = -directionY;
            }

            // Ball hits bottom wall
            if (picBall.Location.Y < 0)
            {
                directionY = -directionY;
            }

            // Scorecounter
            txtPunkte.Text = Convert.ToString(points);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Schläger ganz rechts ins Panel setzen
            picSchlägerRechts.Location = new Point(pnlSpiel.Width - picSchlägerRechts.Width, pnlSpiel.Height / 2);
            // Scrollbar rechts neben Panel setzen, Maximal und Minimalwert und aktuellen Wert einstellen
            vsbSchlägerRechts.Height = pnlSpiel.Height;
            vsbSchlägerRechts.Location = new Point(pnlSpiel.Location.X + pnlSpiel.Width, pnlSpiel.Location.Y);
            vsbSchlägerRechts.Minimum = 0;
            vsbSchlägerRechts.Maximum = pnlSpiel.Height - picSchlägerRechts.Height + vsbSchlägerRechts.LargeChange;
            vsbSchlägerRechts.Value = picSchlägerRechts.Location.Y;
        }

        private void vsbSchlägerRechts_Scroll(object sender, ScrollEventArgs e)
        {
            picSchlägerRechts.Location = new Point(picSchlägerRechts.Location.X, vsbSchlägerRechts.Value);
            vsbSchlägerRechts.Value = picSchlägerRechts.Location.Y;
        }

        private void rdbBall_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.S:
                    if (directionY > directionX)
                    {
                        directionX = 2;
                        directionY = -1;
                    }
                    else
                    {
                        directionX = -2;
                        directionY = 1;
                    }

                    break;
                case Keys.W:
                    if (directionX > directionY)
                    {
                        directionX = -2;
                        directionY = -1;
                    }
                    else
                    {
                        directionX = 2;
                        directionY = 1;
                    }

                    break;
                case Keys.P:
                    tmrSpiel.Stop();
                    break;
                case Keys.F:
                    tmrSpiel.Start();
                    break;
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
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
    }
}    