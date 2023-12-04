namespace Meetkundige_dingen
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
            this.rbtGelijkzijdigeDriehoek = new System.Windows.Forms.RadioButton();
            this.rbtRechthoek = new System.Windows.Forms.RadioButton();
            this.rbtVierkant = new System.Windows.Forms.RadioButton();
            this.rbtCirkel = new System.Windows.Forms.RadioButton();
            this.grpKeuze = new System.Windows.Forms.GroupBox();
            this.lblZijde = new System.Windows.Forms.Label();
            this.txtZijde = new System.Windows.Forms.TextBox();
            this.txtStraal = new System.Windows.Forms.TextBox();
            this.lblStraal = new System.Windows.Forms.Label();
            this.txtHoogte = new System.Windows.Forms.TextBox();
            this.lblHoogte = new System.Windows.Forms.Label();
            this.txtBasis = new System.Windows.Forms.TextBox();
            this.lblBasis = new System.Windows.Forms.Label();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBasisHoogte = new System.Windows.Forms.Panel();
            this.pnlStraal = new System.Windows.Forms.Panel();
            this.pnlZIjde = new System.Windows.Forms.Panel();
            this.grpKeuze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.pnlBasisHoogte.SuspendLayout();
            this.pnlStraal.SuspendLayout();
            this.pnlZIjde.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtGelijkzijdigeDriehoek
            // 
            this.rbtGelijkzijdigeDriehoek.AutoSize = true;
            this.rbtGelijkzijdigeDriehoek.Location = new System.Drawing.Point(26, 22);
            this.rbtGelijkzijdigeDriehoek.Name = "rbtGelijkzijdigeDriehoek";
            this.rbtGelijkzijdigeDriehoek.Size = new System.Drawing.Size(157, 20);
            this.rbtGelijkzijdigeDriehoek.TabIndex = 0;
            this.rbtGelijkzijdigeDriehoek.TabStop = true;
            this.rbtGelijkzijdigeDriehoek.Text = "Gelijkzijdige driehoek";
            this.rbtGelijkzijdigeDriehoek.UseVisualStyleBackColor = true;
            this.rbtGelijkzijdigeDriehoek.CheckedChanged += new System.EventHandler(this.CheckRadioButtons);
            // 
            // rbtRechthoek
            // 
            this.rbtRechthoek.AutoSize = true;
            this.rbtRechthoek.Location = new System.Drawing.Point(26, 114);
            this.rbtRechthoek.Name = "rbtRechthoek";
            this.rbtRechthoek.Size = new System.Drawing.Size(93, 20);
            this.rbtRechthoek.TabIndex = 1;
            this.rbtRechthoek.TabStop = true;
            this.rbtRechthoek.Text = "Rechthoek";
            this.rbtRechthoek.UseVisualStyleBackColor = true;
            this.rbtRechthoek.CheckedChanged += new System.EventHandler(this.CheckRadioButtons);
            // 
            // rbtVierkant
            // 
            this.rbtVierkant.AutoSize = true;
            this.rbtVierkant.Location = new System.Drawing.Point(26, 68);
            this.rbtVierkant.Name = "rbtVierkant";
            this.rbtVierkant.Size = new System.Drawing.Size(77, 20);
            this.rbtVierkant.TabIndex = 2;
            this.rbtVierkant.TabStop = true;
            this.rbtVierkant.Text = "Vierkant";
            this.rbtVierkant.UseVisualStyleBackColor = true;
            this.rbtVierkant.CheckedChanged += new System.EventHandler(this.CheckRadioButtons);
            // 
            // rbtCirkel
            // 
            this.rbtCirkel.AutoSize = true;
            this.rbtCirkel.Location = new System.Drawing.Point(26, 163);
            this.rbtCirkel.Name = "rbtCirkel";
            this.rbtCirkel.Size = new System.Drawing.Size(62, 20);
            this.rbtCirkel.TabIndex = 3;
            this.rbtCirkel.TabStop = true;
            this.rbtCirkel.Text = "Cirkel";
            this.rbtCirkel.UseVisualStyleBackColor = true;
            this.rbtCirkel.CheckedChanged += new System.EventHandler(this.CheckRadioButtons);
            // 
            // grpKeuze
            // 
            this.grpKeuze.Controls.Add(this.rbtRechthoek);
            this.grpKeuze.Controls.Add(this.rbtCirkel);
            this.grpKeuze.Controls.Add(this.rbtGelijkzijdigeDriehoek);
            this.grpKeuze.Controls.Add(this.rbtVierkant);
            this.grpKeuze.Location = new System.Drawing.Point(65, 45);
            this.grpKeuze.Name = "grpKeuze";
            this.grpKeuze.Size = new System.Drawing.Size(200, 199);
            this.grpKeuze.TabIndex = 4;
            this.grpKeuze.TabStop = false;
            this.grpKeuze.Text = "Keuze figuur";
            // 
            // lblZijde
            // 
            this.lblZijde.AutoSize = true;
            this.lblZijde.Location = new System.Drawing.Point(8, 24);
            this.lblZijde.Name = "lblZijde";
            this.lblZijde.Size = new System.Drawing.Size(35, 16);
            this.lblZijde.TabIndex = 5;
            this.lblZijde.Text = "zijde";
            // 
            // txtZijde
            // 
            this.txtZijde.Location = new System.Drawing.Point(121, 24);
            this.txtZijde.Name = "txtZijde";
            this.txtZijde.Size = new System.Drawing.Size(100, 22);
            this.txtZijde.TabIndex = 6;
            // 
            // txtStraal
            // 
            this.txtStraal.Location = new System.Drawing.Point(118, 19);
            this.txtStraal.Name = "txtStraal";
            this.txtStraal.Size = new System.Drawing.Size(100, 22);
            this.txtStraal.TabIndex = 8;
            // 
            // lblStraal
            // 
            this.lblStraal.AutoSize = true;
            this.lblStraal.Location = new System.Drawing.Point(5, 19);
            this.lblStraal.Name = "lblStraal";
            this.lblStraal.Size = new System.Drawing.Size(40, 16);
            this.lblStraal.TabIndex = 7;
            this.lblStraal.Text = "straal";
            // 
            // txtHoogte
            // 
            this.txtHoogte.Location = new System.Drawing.Point(116, 59);
            this.txtHoogte.Name = "txtHoogte";
            this.txtHoogte.Size = new System.Drawing.Size(100, 22);
            this.txtHoogte.TabIndex = 10;
            // 
            // lblHoogte
            // 
            this.lblHoogte.AutoSize = true;
            this.lblHoogte.Location = new System.Drawing.Point(3, 59);
            this.lblHoogte.Name = "lblHoogte";
            this.lblHoogte.Size = new System.Drawing.Size(49, 16);
            this.lblHoogte.TabIndex = 9;
            this.lblHoogte.Text = "hoogte";
            // 
            // txtBasis
            // 
            this.txtBasis.Location = new System.Drawing.Point(116, 18);
            this.txtBasis.Name = "txtBasis";
            this.txtBasis.Size = new System.Drawing.Size(100, 22);
            this.txtBasis.TabIndex = 12;
            // 
            // lblBasis
            // 
            this.lblBasis.AutoSize = true;
            this.lblBasis.Location = new System.Drawing.Point(3, 18);
            this.lblBasis.Name = "lblBasis";
            this.lblBasis.Size = new System.Drawing.Size(40, 16);
            this.lblBasis.TabIndex = 11;
            this.lblBasis.Text = "basis";
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(396, 194);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(221, 180);
            this.imgBox.TabIndex = 13;
            this.imgBox.TabStop = false;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(64, 295);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(200, 23);
            this.btnBereken.TabIndex = 14;
            this.btnBereken.Text = "Bereken Omtrek";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // txtResultaat
            // 
            this.txtResultaat.Location = new System.Drawing.Point(164, 352);
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.Size = new System.Drawing.Size(100, 22);
            this.txtResultaat.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Resultaat";
            // 
            // pnlBasisHoogte
            // 
            this.pnlBasisHoogte.Controls.Add(this.lblBasis);
            this.pnlBasisHoogte.Controls.Add(this.lblHoogte);
            this.pnlBasisHoogte.Controls.Add(this.txtHoogte);
            this.pnlBasisHoogte.Controls.Add(this.txtBasis);
            this.pnlBasisHoogte.Location = new System.Drawing.Point(490, 60);
            this.pnlBasisHoogte.Name = "pnlBasisHoogte";
            this.pnlBasisHoogte.Size = new System.Drawing.Size(239, 100);
            this.pnlBasisHoogte.TabIndex = 17;
            // 
            // pnlStraal
            // 
            this.pnlStraal.Controls.Add(this.txtStraal);
            this.pnlStraal.Controls.Add(this.lblStraal);
            this.pnlStraal.Location = new System.Drawing.Point(490, 166);
            this.pnlStraal.Name = "pnlStraal";
            this.pnlStraal.Size = new System.Drawing.Size(239, 100);
            this.pnlStraal.TabIndex = 18;
            // 
            // pnlZIjde
            // 
            this.pnlZIjde.Controls.Add(this.lblZijde);
            this.pnlZIjde.Controls.Add(this.txtZijde);
            this.pnlZIjde.Location = new System.Drawing.Point(493, 12);
            this.pnlZIjde.Name = "pnlZIjde";
            this.pnlZIjde.Size = new System.Drawing.Size(239, 100);
            this.pnlZIjde.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlZIjde);
            this.Controls.Add(this.pnlStraal);
            this.Controls.Add(this.pnlBasisHoogte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.grpKeuze);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpKeuze.ResumeLayout(false);
            this.grpKeuze.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.pnlBasisHoogte.ResumeLayout(false);
            this.pnlBasisHoogte.PerformLayout();
            this.pnlStraal.ResumeLayout(false);
            this.pnlStraal.PerformLayout();
            this.pnlZIjde.ResumeLayout(false);
            this.pnlZIjde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtGelijkzijdigeDriehoek;
        private System.Windows.Forms.RadioButton rbtRechthoek;
        private System.Windows.Forms.RadioButton rbtVierkant;
        private System.Windows.Forms.RadioButton rbtCirkel;
        private System.Windows.Forms.GroupBox grpKeuze;
        private System.Windows.Forms.Label lblZijde;
        private System.Windows.Forms.TextBox txtZijde;
        private System.Windows.Forms.TextBox txtStraal;
        private System.Windows.Forms.Label lblStraal;
        private System.Windows.Forms.TextBox txtHoogte;
        private System.Windows.Forms.Label lblHoogte;
        private System.Windows.Forms.TextBox txtBasis;
        private System.Windows.Forms.Label lblBasis;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox txtResultaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBasisHoogte;
        private System.Windows.Forms.Panel pnlStraal;
        private System.Windows.Forms.Panel pnlZIjde;
    }
}

