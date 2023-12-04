namespace VoorbeeldListView
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
            this.lstLijstStudent = new System.Windows.Forms.ListBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lstLijstAuto = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstLijstStudent
            // 
            this.lstLijstStudent.FormattingEnabled = true;
            this.lstLijstStudent.ItemHeight = 16;
            this.lstLijstStudent.Location = new System.Drawing.Point(141, 76);
            this.lstLijstStudent.Name = "lstLijstStudent";
            this.lstLijstStudent.Size = new System.Drawing.Size(148, 180);
            this.lstLijstStudent.TabIndex = 0;
            this.lstLijstStudent.SelectedIndexChanged += new System.EventHandler(this.lstLijstStudent_SelectedIndexChanged);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(483, 87);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(162, 16);
            this.lblSelected.TabIndex = 1;
            this.lblSelected.Text = "Je Selecteerde Nog Niets";
            // 
            // lstLijstAuto
            // 
            this.lstLijstAuto.FormattingEnabled = true;
            this.lstLijstAuto.ItemHeight = 16;
            this.lstLijstAuto.Location = new System.Drawing.Point(308, 76);
            this.lstLijstAuto.Name = "lstLijstAuto";
            this.lstLijstAuto.Size = new System.Drawing.Size(148, 180);
            this.lstLijstAuto.TabIndex = 2;
            this.lstLijstAuto.SelectedIndexChanged += new System.EventHandler(this.lstLijstAuto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Autos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Studenten";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLijstAuto);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lstLijstStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLijstStudent;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ListBox lstLijstAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

