using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AB06_Chessboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ZeichenSchachbrett(Convert.ToInt32(nudAnzahlZeilen.Value));
        }

        //Brettformat erstellen 
        private void ZeichenSchachbrett(int anzahl)
        {
            int brettbreite = pnlSchachbrett.Width;
            int bretthoehe = pnlSchachbrett.Height;
            int zellenbreite = brettbreite / anzahl;
            int zellenhoehe = bretthoehe / anzahl;
            bool geradeZeile = true;

            // Spielbrett aktualisieren und wipe
            pnlSchachbrett.Controls.Clear(); 
            for (int y = 0; y + zellenhoehe <= bretthoehe; y = y + zellenhoehe)
            {
                int startpunktX = geradeZeile ? zellenbreite : 0;
                //Auf die nächste seite wechseln
                geradeZeile = !geradeZeile;
                for (int x = startpunktX; x + zellenbreite <= brettbreite; x = x + (2 * zellenbreite))
                {
                    // New label erstellen (zelle)
                    var zelle = new Label
                    {
                        BackColor = Color.Black,
                        Location = new Point(x, y),
                        Width = zellenbreite,
                        Height = zellenhoehe
                    };
                    pnlSchachbrett.Controls.Add(zelle);
                }
            }
        }
    }
}