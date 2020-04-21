using System.ComponentModel;

namespace AB03_Standardevents
{
    partial class Info
    {
        /// Dispose reinigt alle gebrauchten ressourcen.
        private IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Alle btnSchliessen Events
            // 
            this.btnSchliessen.Location = new System.Drawing.Point(220, 275);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(139, 62);
            this.btnSchliessen.TabIndex = 0;
            this.btnSchliessen.Text = "schliessen";
            this.btnSchliessen.UseVisualStyleBackColor = true;
            this.btnSchliessen.Click += new System.EventHandler(this.btnSchliessen_Click);
            // 
            // Info Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnSchliessen);
            this.Name = "Info";
            this.Text = "Informationen";
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnSchliessen;
    }
}