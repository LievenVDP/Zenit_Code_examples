namespace Oefening1_DrukSterren
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
            this.txtAantalSterren = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoe = new System.Windows.Forms.Button();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAantalSterren
            // 
            this.txtAantalSterren.Location = new System.Drawing.Point(401, 13);
            this.txtAantalSterren.Name = "txtAantalSterren";
            this.txtAantalSterren.Size = new System.Drawing.Size(100, 22);
            this.txtAantalSterren.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aantal Sterren";
            // 
            // btnDoe
            // 
            this.btnDoe.Location = new System.Drawing.Point(165, 58);
            this.btnDoe.Name = "btnDoe";
            this.btnDoe.Size = new System.Drawing.Size(336, 23);
            this.btnDoe.TabIndex = 2;
            this.btnDoe.Text = "Doen!";
            this.btnDoe.UseVisualStyleBackColor = true;
            this.btnDoe.Click += new System.EventHandler(this.btnDoe_Click);
            // 
            // txtResultaat
            // 
            this.txtResultaat.Location = new System.Drawing.Point(12, 122);
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.Size = new System.Drawing.Size(489, 22);
            this.txtResultaat.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 198);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.btnDoe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAantalSterren);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAantalSterren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoe;
        private System.Windows.Forms.TextBox txtResultaat;
    }
}

