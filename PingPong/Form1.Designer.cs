namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            this.pnlSpiel = new System.Windows.Forms.Panel();
            this.picSchlägerRechts = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.vsbSchlägerRechts = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPunkte = new System.Windows.Forms.TextBox();
            this.btnHoch = new System.Windows.Forms.Button();
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnRechts = new System.Windows.Forms.Button();
            this.btnRunter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSpiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picSchlägerRechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSpiel
            // 
            this.pnlSpiel.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpiel.Controls.Add(this.picSchlägerRechts);
            this.pnlSpiel.Controls.Add(this.picBall);
            this.pnlSpiel.Location = new System.Drawing.Point(31, 18);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(536, 297);
            this.pnlSpiel.TabIndex = 0;
            // 
            // picSchlägerRechts
            // 
            this.picSchlägerRechts.BackColor = System.Drawing.Color.Black;
            this.picSchlägerRechts.Location = new System.Drawing.Point(497, 28);
            this.picSchlägerRechts.Name = "picSchlägerRechts";
            this.picSchlägerRechts.Size = new System.Drawing.Size(10, 40);
            this.picSchlägerRechts.TabIndex = 1;
            this.picSchlägerRechts.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.OrangeRed;
            this.picBall.Location = new System.Drawing.Point(173, 104);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(33, 32);
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(31, 421);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(211, 66);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Spiel Starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Interval = 5;
            this.tmrSpiel.Tick += new System.EventHandler(this.tmrSpiel_Tick);
            // 
            // vsbSchlägerRechts
            // 
            this.vsbSchlägerRechts.Location = new System.Drawing.Point(594, 27);
            this.vsbSchlägerRechts.Name = "vsbSchlägerRechts";
            this.vsbSchlägerRechts.Size = new System.Drawing.Size(22, 288);
            this.vsbSchlägerRechts.TabIndex = 2;
            this.vsbSchlägerRechts.Value = 50;
            this.vsbSchlägerRechts.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbSchlägerRechts_Scroll);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F);
            this.label1.Location = new System.Drawing.Point(31, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Punkte:";
            // 
            // txtPunkte
            // 
            this.txtPunkte.Location = new System.Drawing.Point(160, 359);
            this.txtPunkte.Name = "txtPunkte";
            this.txtPunkte.Size = new System.Drawing.Size(119, 23);
            this.txtPunkte.TabIndex = 4;
            this.txtPunkte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnHoch
            // 
            this.btnHoch.BackColor = System.Drawing.Color.White;
            this.btnHoch.Location = new System.Drawing.Point(752, 123);
            this.btnHoch.Name = "btnHoch";
            this.btnHoch.Size = new System.Drawing.Size(28, 28);
            this.btnHoch.TabIndex = 5;
            this.btnHoch.Tag = "Ho";
            this.btnHoch.Text = "⬆";
            this.btnHoch.UseVisualStyleBackColor = false;
            // 
            // btnLinks
            // 
            this.btnLinks.BackColor = System.Drawing.Color.White;
            this.btnLinks.Location = new System.Drawing.Point(717, 159);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(28, 28);
            this.btnLinks.TabIndex = 6;
            this.btnLinks.Tag = "Li";
            this.btnLinks.Text = "⬅";
            this.btnLinks.UseVisualStyleBackColor = false;
            // 
            // btnRechts
            // 
            this.btnRechts.BackColor = System.Drawing.Color.White;
            this.btnRechts.Location = new System.Drawing.Point(787, 159);
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.Size = new System.Drawing.Size(28, 28);
            this.btnRechts.TabIndex = 7;
            this.btnRechts.Text = "->";
            this.btnRechts.UseVisualStyleBackColor = false;
            // 
            // btnRunter
            // 
            this.btnRunter.BackColor = System.Drawing.Color.White;
            this.btnRunter.Location = new System.Drawing.Point(752, 196);
            this.btnRunter.Name = "btnRunter";
            this.btnRunter.Size = new System.Drawing.Size(28, 28);
            this.btnRunter.TabIndex = 8;
            this.btnRunter.Text = "⬇";
            this.btnRunter.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(262, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 111);
            this.label2.TabIndex = 9;
            this.label2.Text =
                "Tastatursteuerung :\r\nTaste\r\n\r\nH:   Horizontale Flugrichtung umkehren\r\nV:    Verti" +
                "kale Flugrichtung umkehren\r\nP:    Spiel pausieren\r\nS:    Spiel weiterlaufen lass" + "en";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRunter);
            this.Controls.Add(this.btnRechts);
            this.Controls.Add(this.btnLinks);
            this.Controls.Add(this.btnHoch);
            this.Controls.Add(this.txtPunkte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vsbSchlägerRechts);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlSpiel);
            this.Name = "Form1";
            this.Text = "Ping-Pong Spiel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSpiel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picSchlägerRechts)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlSpiel;
        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.VScrollBar vsbSchlägerRechts;
        private System.Windows.Forms.PictureBox picSchlägerRechts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPunkte;
        private System.Windows.Forms.Button btnHoch;
        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnRunter;
        private System.Windows.Forms.Button btnRechts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBall;
    }
}