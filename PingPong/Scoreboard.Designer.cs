using System.ComponentModel;

namespace PingPong
{
    partial class Scoreboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnZurück = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punkte:";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            this.lblPoints.BackColor = System.Drawing.SystemColors.Control;
            this.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPoints.Location = new System.Drawing.Point(34, 81);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(86, 23);
            this.lblPoints.TabIndex = 2;
            this.lblScores.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblScores.Location = new System.Drawing.Point(30, 134);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(434, 210);
            this.lblScores.TabIndex = 3;
            this.txtName.Location = new System.Drawing.Point(187, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(115, 23);
            this.txtName.TabIndex = 4;
            this.btnEnter.Location = new System.Drawing.Point(357, 72);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(107, 38);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Eintragen";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            this.btnZurück.Location = new System.Drawing.Point(357, 368);
            this.btnZurück.Name = "btnZurück";
            this.btnZurück.Size = new System.Drawing.Size(107, 40);
            this.btnZurück.TabIndex = 6;
            this.btnZurück.Text = "Zurück";
            this.btnZurück.UseVisualStyleBackColor = true;
            this.btnZurück.Click += new System.EventHandler(this.btnZurück_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 437);
            this.Controls.Add(this.btnZurück);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Scoreboard";
            this.Text = "Scoreboard";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnZurück;
    }
}