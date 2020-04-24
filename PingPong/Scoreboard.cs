using System;
using System.IO;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
        }
        // Scoreboard Dateifile)
        static string filename = "scoreboard_pingpong_v4.txt"; 
        static string path = Application.StartupPath + filename;

        public void SetPoints(int points)
        {
            lblPoints.Text = Convert.ToString(points);
        }

        public void ShowScoreboard()
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "");
            }

            lblScores.Text = File.ReadAllText(Application.StartupPath + filename);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string createText = String.Format("   {0}        {1}        {2}", lblPoints.Text, name,
                                    DateTime.Today.ToString("dd.MM.yyyy")) + Environment.NewLine;
            File.AppendAllText(path, createText);
            lblScores.Text = File.ReadAllText(Application.StartupPath + filename);
            btnEnter.Visible = false;
        }

        private void btnZurück_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}