namespace Taschenrechner
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
            System.Windows.Forms.Label Label2;
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraktion = new System.Windows.Forms.Button();
            this.btnPotenz = new System.Windows.Forms.Button();
            this.btnMultiplikation = new System.Windows.Forms.Button();
            this.btnMaximum = new System.Windows.Forms.Button();
            Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label2
            // 
            Label2.Location = new System.Drawing.Point(185, 200);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(108, 27);
            Label2.TabIndex = 3;
            Label2.Text = "Ergebnis:";
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(85, 104);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(272, 23);
            this.txtOperand1.TabIndex = 0;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(545, 104);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(272, 23);
            this.txtOperand2.TabIndex = 1;
            // 
            // lblOperator
            // 
            this.lblOperator.Location = new System.Drawing.Point(393, 107);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(108, 27);
            this.lblOperator.TabIndex = 2;
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.BackColor = System.Drawing.Color.White;
            this.lblErgebnis.Location = new System.Drawing.Point(393, 200);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(108, 27);
            this.lblErgebnis.TabIndex = 4;
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(76, 264);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(188, 65);
            this.btnAddition.TabIndex = 5;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubtraktion
            // 
            this.btnSubtraktion.Location = new System.Drawing.Point(338, 264);
            this.btnSubtraktion.Name = "btnSubtraktion";
            this.btnSubtraktion.Size = new System.Drawing.Size(203, 65);
            this.btnSubtraktion.TabIndex = 6;
            this.btnSubtraktion.Text = "Subtraktion";
            this.btnSubtraktion.UseVisualStyleBackColor = true;
            this.btnSubtraktion.Click += new System.EventHandler(this.btnSubtraktion_Click);
            // 
            // btnPotenz
            // 
            this.btnPotenz.Location = new System.Drawing.Point(614, 264);
            this.btnPotenz.Name = "btnPotenz";
            this.btnPotenz.Size = new System.Drawing.Size(203, 65);
            this.btnPotenz.TabIndex = 7;
            this.btnPotenz.Text = "Potenz";
            this.btnPotenz.UseVisualStyleBackColor = true;
            this.btnPotenz.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnMultiplikation
            // 
            this.btnMultiplikation.Location = new System.Drawing.Point(76, 382);
            this.btnMultiplikation.Name = "btnMultiplikation";
            this.btnMultiplikation.Size = new System.Drawing.Size(188, 65);
            this.btnMultiplikation.TabIndex = 8;
            this.btnMultiplikation.Text = "Multiplikation";
            this.btnMultiplikation.UseVisualStyleBackColor = true;
            this.btnMultiplikation.Click += new System.EventHandler(this.btnMultiplikation_Click);
            // 
            // btnMaximum
            // 
            this.btnMaximum.Location = new System.Drawing.Point(338, 382);
            this.btnMaximum.Name = "btnMaximum";
            this.btnMaximum.Size = new System.Drawing.Size(203, 65);
            this.btnMaximum.TabIndex = 9;
            this.btnMaximum.Text = "Maximum";
            this.btnMaximum.UseVisualStyleBackColor = true;
            this.btnMaximum.Click += new System.EventHandler(this.btnMaximum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.btnMaximum);
            this.Controls.Add(this.btnMultiplikation);
            this.Controls.Add(this.btnPotenz);
            this.Controls.Add(this.btnSubtraktion);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(Label2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Name = "Form1";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblErgebnis;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.Button btnSubtraktion;
        private System.Windows.Forms.Button btnPotenz;
        private System.Windows.Forms.Button btnMultiplikation;
        private System.Windows.Forms.Button btnMaximum;
    }
}