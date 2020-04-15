using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ches
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private void InitializeComponent()
        {
            this.lblTitel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblTitel
            //
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(20, 20);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(105, 13);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "GUI Programmierung";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTitel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}