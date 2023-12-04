namespace KassaSysteem
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
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.txtTotaal = new System.Windows.Forms.TextBox();
            this.txtLijst = new System.Windows.Forms.TextBox();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(144, 90);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(199, 22);
            this.txtPrijs.TabIndex = 0;
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(144, 160);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(199, 22);
            this.txtAantal.TabIndex = 1;
            // 
            // txtTotaal
            // 
            this.txtTotaal.Location = new System.Drawing.Point(557, 244);
            this.txtTotaal.Name = "txtTotaal";
            this.txtTotaal.Size = new System.Drawing.Size(186, 22);
            this.txtTotaal.TabIndex = 2;
            // 
            // txtLijst
            // 
            this.txtLijst.Location = new System.Drawing.Point(557, 90);
            this.txtLijst.Multiline = true;
            this.txtLijst.Name = "txtLijst";
            this.txtLijst.Size = new System.Drawing.Size(186, 129);
            this.txtLijst.TabIndex = 3;
            // 
            // btnNieuw
            // 
            this.btnNieuw.Location = new System.Drawing.Point(557, 337);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(186, 23);
            this.btnNieuw.TabIndex = 4;
            this.btnNieuw.Text = "Nieuw";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(144, 243);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(199, 23);
            this.btnVoegToe.TabIndex = 5;
            this.btnVoegToe.Text = "Voeg toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.txtLijst);
            this.Controls.Add(this.txtTotaal);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.txtPrijs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.TextBox txtTotaal;
        private System.Windows.Forms.TextBox txtLijst;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.Button btnVoegToe;
    }
}

