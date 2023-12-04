namespace MyFavouriteCars
{
    partial class MyForm
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
            this.cmbMerk = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtKleur = new System.Windows.Forms.TextBox();
            this.dtConstruction = new System.Windows.Forms.DateTimePicker();
            this.btnMaak = new System.Windows.Forms.Button();
            this.btnToon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbMerk
            // 
            this.cmbMerk.FormattingEnabled = true;
            this.cmbMerk.Items.AddRange(new object[] {
            "Volvo",
            "BMW",
            "Audi",
            "Volkswagen",
            "Peugeot",
            "Citroen",
            "Renault",
            "Chevrolet, ",
            "Opel"});
            this.cmbMerk.Location = new System.Drawing.Point(202, 95);
            this.cmbMerk.Name = "cmbMerk";
            this.cmbMerk.Size = new System.Drawing.Size(262, 24);
            this.cmbMerk.TabIndex = 0;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "SUV",
            "Hatchback",
            "Roadster",
            "Sedan",
            "Coupe"});
            this.cmbType.Location = new System.Drawing.Point(202, 136);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(262, 24);
            this.cmbType.TabIndex = 1;
            // 
            // txtKleur
            // 
            this.txtKleur.Location = new System.Drawing.Point(202, 184);
            this.txtKleur.Name = "txtKleur";
            this.txtKleur.Size = new System.Drawing.Size(262, 22);
            this.txtKleur.TabIndex = 2;
            // 
            // dtConstruction
            // 
            this.dtConstruction.Location = new System.Drawing.Point(202, 232);
            this.dtConstruction.Name = "dtConstruction";
            this.dtConstruction.Size = new System.Drawing.Size(262, 22);
            this.dtConstruction.TabIndex = 3;
            // 
            // btnMaak
            // 
            this.btnMaak.Location = new System.Drawing.Point(202, 292);
            this.btnMaak.Name = "btnMaak";
            this.btnMaak.Size = new System.Drawing.Size(125, 41);
            this.btnMaak.TabIndex = 4;
            this.btnMaak.Text = "Maak auto";
            this.btnMaak.UseVisualStyleBackColor = true;
            this.btnMaak.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnToon
            // 
            this.btnToon.Location = new System.Drawing.Point(339, 292);
            this.btnToon.Name = "btnToon";
            this.btnToon.Size = new System.Drawing.Size(125, 41);
            this.btnToon.TabIndex = 5;
            this.btnToon.Text = "Toon Auto";
            this.btnToon.UseVisualStyleBackColor = true;
            this.btnToon.Click += new System.EventHandler(this.btnToon_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToon);
            this.Controls.Add(this.btnMaak);
            this.Controls.Add(this.dtConstruction);
            this.Controls.Add(this.txtKleur);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbMerk);
            this.Name = "MyForm";
            this.Text = "mijn favourite auto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMerk;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtKleur;
        private System.Windows.Forms.DateTimePicker dtConstruction;
        private System.Windows.Forms.Button btnMaak;
        private System.Windows.Forms.Button btnToon;
    }
}

