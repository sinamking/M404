using System;
using System.Drawing;
using System.Windows.Forms;

namespace AB03_Standardevents
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            // Erstellt ein neues Label "Information Notiication"
            Label lblAusgabe = new Label();
            
            lblAusgabe.Font = new Font("Arial", 8F, FontStyle.Bold);
            lblAusgabe.Location = new Point(15, 220);
            lblAusgabe.Size = new Size(400, 30);
            lblAusgabe.Text = "Information Notification";

            // Anzeige des Labels im Form
            Controls.Add(lblAusgabe);
            
            // Resize attempt #5
            Control control = (Control) sender;
            if (control.Size.Height != control.Size.Width)
            {
                control.Size = new Size(control.Size.Width, control.Size.Width);
            }
        }
    }
}