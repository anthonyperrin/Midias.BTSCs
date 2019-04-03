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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeUC1 = new Midias.BTSCs.App.UserControls.HomeUC();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(200, 800);
            this.panel1.TabIndex = 0;
            // 
            // VehiculesBtn
            // 
            this.VehiculesBtn.FlatAppearance.BorderSize = 0;
            this.VehiculesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehiculesBtn.Location = new System.Drawing.Point(0, 275);
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
            this.SalariesBtn.Location = new System.Drawing.Point(0, 215);
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
            this.ProduitsBtn.Location = new System.Drawing.Point(0, 155);
            this.ProduitsBtn.Name = "ProduitsBtn";
            this.ProduitsBtn.Size = new System.Drawing.Size(200, 60);
            this.ProduitsBtn.TabIndex = 0;
            this.ProduitsBtn.Text = "Produits";
            this.ProduitsBtn.UseVisualStyleBackColor = true;
            this.ProduitsBtn.Click += new System.EventHandler(this.ProduitsBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(50)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(324, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 118);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // homeUC1
            // 
            this.homeUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.homeUC1.Location = new System.Drawing.Point(206, 133);
            this.homeUC1.Name = "homeUC1";
            this.homeUC1.Size = new System.Drawing.Size(1160, 537);
            this.homeUC1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1224, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.homeUC1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Midias.BTSCs.App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ProduitsBtn;
        private System.Windows.Forms.Button SalariesBtn;
        private System.Windows.Forms.Button VehiculesBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.HomeUC homeUC1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

