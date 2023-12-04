namespace Oefening2_Dierentuin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVolwassenen = new System.Windows.Forms.TextBox();
            this.txtKinderen = new System.Windows.Forms.TextBox();
            this.txtTotaal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aantal Volwassenen (16,00)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aantal Kinderen (7,50)";
            // 
            // txtVolwassenen
            // 
            this.txtVolwassenen.Location = new System.Drawing.Point(396, 54);
            this.txtVolwassenen.Name = "txtVolwassenen";
            this.txtVolwassenen.Size = new System.Drawing.Size(100, 22);
            this.txtVolwassenen.TabIndex = 2;
            // 
            // txtKinderen
            // 
            this.txtKinderen.Location = new System.Drawing.Point(396, 109);
            this.txtKinderen.Name = "txtKinderen";
            this.txtKinderen.Size = new System.Drawing.Size(100, 22);
            this.txtKinderen.TabIndex = 3;
            // 
            // txtTotaal
            // 
            this.txtTotaal.Location = new System.Drawing.Point(396, 181);
            this.txtTotaal.Name = "txtTotaal";
            this.txtTotaal.Size = new System.Drawing.Size(100, 22);
            this.txtTotaal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Totaal";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(65, 181);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 6;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotaal);
            this.Controls.Add(this.txtKinderen);
            this.Controls.Add(this.txtVolwassenen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVolwassenen;
        private System.Windows.Forms.TextBox txtKinderen;
        private System.Windows.Forms.TextBox txtTotaal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBereken;
    }
}

