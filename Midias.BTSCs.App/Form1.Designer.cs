namespace Midias.BTSCs.App
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VehiculesBtn = new System.Windows.Forms.Button();
            this.SalariesBtn = new System.Windows.Forms.Button();
            this.ProduitsBtn = new System.Windows.Forms.Button();
            this.homeUC = new Midias.BTSCs.App.UserControls.HomeUC();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.VehiculesBtn);
            this.panel1.Controls.Add(this.SalariesBtn);
            this.panel1.Controls.Add(this.ProduitsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1033);
            this.panel1.TabIndex = 0;
            // 
            // VehiculesBtn
            // 
            this.VehiculesBtn.FlatAppearance.BorderSize = 0;
            this.VehiculesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehiculesBtn.Location = new System.Drawing.Point(0, 235);
            this.VehiculesBtn.Name = "VehiculesBtn";
            this.VehiculesBtn.Size = new System.Drawing.Size(200, 60);
            this.VehiculesBtn.TabIndex = 2;
            this.VehiculesBtn.Text = "Véhicules";
            this.VehiculesBtn.UseVisualStyleBackColor = true;
            this.VehiculesBtn.Click += new System.EventHandler(this.VehiculesBtn_Click);
            // 
            // SalariesBtn
            // 
            this.SalariesBtn.FlatAppearance.BorderSize = 0;
            this.SalariesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalariesBtn.Location = new System.Drawing.Point(0, 175);
            this.SalariesBtn.Name = "SalariesBtn";
            this.SalariesBtn.Size = new System.Drawing.Size(200, 60);
            this.SalariesBtn.TabIndex = 1;
            this.SalariesBtn.Text = "Salariés";
            this.SalariesBtn.UseVisualStyleBackColor = true;
            this.SalariesBtn.Click += new System.EventHandler(this.SalariesBtn_Click);
            // 
            // ProduitsBtn
            // 
            this.ProduitsBtn.FlatAppearance.BorderSize = 0;
            this.ProduitsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProduitsBtn.Location = new System.Drawing.Point(0, 115);
            this.ProduitsBtn.Name = "ProduitsBtn";
            this.ProduitsBtn.Size = new System.Drawing.Size(200, 60);
            this.ProduitsBtn.TabIndex = 0;
            this.ProduitsBtn.Text = "Produits";
            this.ProduitsBtn.UseVisualStyleBackColor = true;
            this.ProduitsBtn.Click += new System.EventHandler(this.ProduitsBtn_Click);
            // 
            // homeUC
            // 
            this.homeUC.Location = new System.Drawing.Point(206, 0);
            this.homeUC.Name = "homeUC";
            this.homeUC.Size = new System.Drawing.Size(1204, 764);
            this.homeUC.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.homeUC);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Midias.BTSCs.App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ProduitsBtn;
        private System.Windows.Forms.Button SalariesBtn;
        private System.Windows.Forms.Button VehiculesBtn;
        private UserControls.HomeUC homeUC;
    }
}

