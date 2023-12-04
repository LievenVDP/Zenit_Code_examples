namespace radiobuttons
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
            this.grpKeuze = new System.Windows.Forms.GroupBox();
            this.chkKeuze2 = new System.Windows.Forms.CheckBox();
            this.chkKeuze1 = new System.Windows.Forms.CheckBox();
            this.rbtGeel = new System.Windows.Forms.RadioButton();
            this.rbtBlauw = new System.Windows.Forms.RadioButton();
            this.rbtRood = new System.Windows.Forms.RadioButton();
            this.grpKeuze.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKeuze
            // 
            this.grpKeuze.Controls.Add(this.chkKeuze2);
            this.grpKeuze.Controls.Add(this.chkKeuze1);
            this.grpKeuze.Controls.Add(this.rbtGeel);
            this.grpKeuze.Controls.Add(this.rbtBlauw);
            this.grpKeuze.Controls.Add(this.rbtRood);
            this.grpKeuze.Location = new System.Drawing.Point(43, 55);
            this.grpKeuze.Name = "grpKeuze";
            this.grpKeuze.Size = new System.Drawing.Size(237, 274);
            this.grpKeuze.TabIndex = 0;
            this.grpKeuze.TabStop = false;
            this.grpKeuze.Text = "Maak je Keuze";
            // 
            // chkKeuze2
            // 
            this.chkKeuze2.AutoSize = true;
            this.chkKeuze2.Location = new System.Drawing.Point(27, 209);
            this.chkKeuze2.Name = "chkKeuze2";
            this.chkKeuze2.Size = new System.Drawing.Size(76, 20);
            this.chkKeuze2.TabIndex = 4;
            this.chkKeuze2.Text = "Keuze 2";
            this.chkKeuze2.UseVisualStyleBackColor = true;
            this.chkKeuze2.CheckedChanged += new System.EventHandler(this.chkKeuze1_CheckedChanged);
            // 
            // chkKeuze1
            // 
            this.chkKeuze1.AutoSize = true;
            this.chkKeuze1.Location = new System.Drawing.Point(27, 183);
            this.chkKeuze1.Name = "chkKeuze1";
            this.chkKeuze1.Size = new System.Drawing.Size(76, 20);
            this.chkKeuze1.TabIndex = 3;
            this.chkKeuze1.Text = "Keuze 1";
            this.chkKeuze1.UseVisualStyleBackColor = true;
            this.chkKeuze1.CheckedChanged += new System.EventHandler(this.chkKeuze1_CheckedChanged);
            // 
            // rbtGeel
            // 
            this.rbtGeel.AutoSize = true;
            this.rbtGeel.Location = new System.Drawing.Point(27, 81);
            this.rbtGeel.Name = "rbtGeel";
            this.rbtGeel.Size = new System.Drawing.Size(57, 20);
            this.rbtGeel.TabIndex = 2;
            this.rbtGeel.TabStop = true;
            this.rbtGeel.Text = "Geel";
            this.rbtGeel.UseVisualStyleBackColor = true;
            this.rbtGeel.CheckedChanged += new System.EventHandler(this.rbtGeel_CheckedChanged);
            // 
            // rbtBlauw
            // 
            this.rbtBlauw.AutoSize = true;
            this.rbtBlauw.Location = new System.Drawing.Point(27, 107);
            this.rbtBlauw.Name = "rbtBlauw";
            this.rbtBlauw.Size = new System.Drawing.Size(64, 20);
            this.rbtBlauw.TabIndex = 1;
            this.rbtBlauw.TabStop = true;
            this.rbtBlauw.Text = "Blauw";
            this.rbtBlauw.UseVisualStyleBackColor = true;
            this.rbtBlauw.CheckedChanged += new System.EventHandler(this.rbtBlauw_CheckedChanged);
            // 
            // rbtRood
            // 
            this.rbtRood.AutoSize = true;
            this.rbtRood.Location = new System.Drawing.Point(27, 55);
            this.rbtRood.Name = "rbtRood";
            this.rbtRood.Size = new System.Drawing.Size(62, 20);
            this.rbtRood.TabIndex = 0;
            this.rbtRood.TabStop = true;
            this.rbtRood.Text = "Rood";
            this.rbtRood.UseVisualStyleBackColor = true;
            this.rbtRood.CheckedChanged += new System.EventHandler(this.rbtRood_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpKeuze);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpKeuze.ResumeLayout(false);
            this.grpKeuze.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKeuze;
        private System.Windows.Forms.CheckBox chkKeuze2;
        private System.Windows.Forms.CheckBox chkKeuze1;
        private System.Windows.Forms.RadioButton rbtGeel;
        private System.Windows.Forms.RadioButton rbtBlauw;
        private System.Windows.Forms.RadioButton rbtRood;
    }
}

