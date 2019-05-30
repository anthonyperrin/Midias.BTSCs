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
            this.menuBarPanel = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.VehiculesBtn = new System.Windows.Forms.Button();
            this.SalariesBtn = new System.Windows.Forms.Button();
            this.ProduitsBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.minimizeAppBox = new System.Windows.Forms.PictureBox();
            this.closeAppBox = new System.Windows.Forms.PictureBox();
            this.vehiculeUC1 = new Midias.BTSCs.App.UserControls.VehiculeUC();
            this.homeUC = new Midias.BTSCs.App.UserControls.HomeUC();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeAppBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.menuBarPanel);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.VehiculesBtn);
            this.panel1.Controls.Add(this.SalariesBtn);
            this.panel1.Controls.Add(this.ProduitsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 650);
            this.panel1.TabIndex = 0;
            // 
            // menuBarPanel
            // 
            this.menuBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(50)))));
            this.menuBarPanel.Location = new System.Drawing.Point(0, 107);
            this.menuBarPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menuBarPanel.Name = "menuBarPanel";
            this.menuBarPanel.Size = new System.Drawing.Size(9, 49);
            this.menuBarPanel.TabIndex = 5;
            // 
            // HomeBtn
            // 
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Location = new System.Drawing.Point(9, 107);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(141, 49);
            this.HomeBtn.TabIndex = 3;
            this.HomeBtn.Text = "     Accueil";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // VehiculesBtn
            // 
            this.VehiculesBtn.FlatAppearance.BorderSize = 0;
            this.VehiculesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehiculesBtn.Image = ((System.Drawing.Image)(resources.GetObject("VehiculesBtn.Image")));
            this.VehiculesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VehiculesBtn.Location = new System.Drawing.Point(9, 254);
            this.VehiculesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VehiculesBtn.Name = "VehiculesBtn";
            this.VehiculesBtn.Size = new System.Drawing.Size(141, 49);
            this.VehiculesBtn.TabIndex = 2;
            this.VehiculesBtn.Text = "     Véhicules";
            this.VehiculesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VehiculesBtn.UseVisualStyleBackColor = true;
            this.VehiculesBtn.Click += new System.EventHandler(this.VehiculesBtn_Click);
            // 
            // SalariesBtn
            // 
            this.SalariesBtn.FlatAppearance.BorderSize = 0;
            this.SalariesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalariesBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalariesBtn.Image")));
            this.SalariesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalariesBtn.Location = new System.Drawing.Point(9, 205);
            this.SalariesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SalariesBtn.Name = "SalariesBtn";
            this.SalariesBtn.Size = new System.Drawing.Size(141, 49);
            this.SalariesBtn.TabIndex = 1;
            this.SalariesBtn.Text = "     Salariés";
            this.SalariesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SalariesBtn.UseVisualStyleBackColor = true;
            this.SalariesBtn.Click += new System.EventHandler(this.SalariesBtn_Click);
            // 
            // ProduitsBtn
            // 
            this.ProduitsBtn.FlatAppearance.BorderSize = 0;
            this.ProduitsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProduitsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ProduitsBtn.Image")));
            this.ProduitsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProduitsBtn.Location = new System.Drawing.Point(9, 156);
            this.ProduitsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProduitsBtn.Name = "ProduitsBtn";
            this.ProduitsBtn.Size = new System.Drawing.Size(141, 49);
            this.ProduitsBtn.TabIndex = 0;
            this.ProduitsBtn.Text = "     Produits";
            this.ProduitsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProduitsBtn.UseVisualStyleBackColor = true;
            this.ProduitsBtn.Click += new System.EventHandler(this.ProduitsBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(243, 7);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 96);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(50)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 8);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Midias.BTSCs.App.Properties.Resources.logo_livretou;
            this.pictureBox2.Location = new System.Drawing.Point(395, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(474, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // minimizeAppBox
            // 
            this.minimizeAppBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizeAppBox.Image")));
            this.minimizeAppBox.Location = new System.Drawing.Point(1004, 19);
            this.minimizeAppBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minimizeAppBox.Name = "minimizeAppBox";
            this.minimizeAppBox.Size = new System.Drawing.Size(9, 10);
            this.minimizeAppBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeAppBox.TabIndex = 4;
            this.minimizeAppBox.TabStop = false;
            this.minimizeAppBox.Click += new System.EventHandler(this.minimizeAppBox_Click);
            // 
            // closeAppBox
            // 
            this.closeAppBox.Image = ((System.Drawing.Image)(resources.GetObject("closeAppBox.Image")));
            this.closeAppBox.Location = new System.Drawing.Point(1029, 16);
            this.closeAppBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeAppBox.Name = "closeAppBox";
            this.closeAppBox.Size = new System.Drawing.Size(9, 10);
            this.closeAppBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeAppBox.TabIndex = 3;
            this.closeAppBox.TabStop = false;
            this.closeAppBox.Click += new System.EventHandler(this.closeAppBox_Click);
            // 
            // vehiculeUC1
            // 
            this.vehiculeUC1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.vehiculeUC1.Location = new System.Drawing.Point(154, 108);
            this.vehiculeUC1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vehiculeUC1.Name = "vehiculeUC1";
            this.vehiculeUC1.Size = new System.Drawing.Size(886, 532);
            this.vehiculeUC1.TabIndex = 6;

            // 
            // HomeUC
            // 
            this.homeUC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.homeUC.Location = new System.Drawing.Point(154, 108);
            this.homeUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homeUC.Name = "HomeUC";
            this.homeUC.Size = new System.Drawing.Size(886, 532);
            this.homeUC.TabIndex = 6;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.vehiculeUC1);
            this.Controls.Add(this.homeUC);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.minimizeAppBox);
            this.Controls.Add(this.closeAppBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Midias.BTSCs.App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeAppBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppBox)).EndInit();
            this.vehiculeUC1.Hide();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ProduitsBtn;
        private System.Windows.Forms.Button SalariesBtn;
        private System.Windows.Forms.Button VehiculesBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox closeAppBox;
        private System.Windows.Forms.PictureBox minimizeAppBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel menuBarPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UserControls.HomeUC homeUC;
        private UserControls.VehiculeUC vehiculeUC1;
    }
}

