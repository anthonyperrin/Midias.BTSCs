﻿using System;

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
            this.homeUC = new UserControls.HomeUC();
            this.vehiculeUC1 = new UserControls.VehiculeUC();
            this.produitUC = new UserControls.ProduitUC();
            this.salarieUC = new UserControls.SalarieUC();
            this.clientUC = new UserControls.ClientUC();
            this.commandeUC = new UserControls.CommandeUC();
            this.livraisonUC = new UserControls.LivraisonUC();
        
            this.HomeBtn = new System.Windows.Forms.Button();
            this.VehiculesBtn = new System.Windows.Forms.Button();
            this.SalariesBtn = new System.Windows.Forms.Button();
            this.ProduitsBtn = new System.Windows.Forms.Button();
            this.CommandeBtn = new System.Windows.Forms.Button();
            this.ClientsBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.minimizeAppBox = new System.Windows.Forms.PictureBox();
            this.closeAppBox = new System.Windows.Forms.PictureBox();
            this.LivraisonBtn = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.LivraisonBtn);
            this.panel1.Controls.Add(this.menuBarPanel);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.VehiculesBtn);
            this.panel1.Controls.Add(this.SalariesBtn);
            this.panel1.Controls.Add(this.ProduitsBtn);
            this.panel1.Controls.Add(this.CommandeBtn);
            this.panel1.Controls.Add(this.ClientsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 650);
            this.panel1.TabIndex = 0;
            // 
            // menuBarPanel
            // 
            this.menuBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(50)))));
            this.menuBarPanel.Location = new System.Drawing.Point(0, 107);
            this.menuBarPanel.Margin = new System.Windows.Forms.Padding(2);
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
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(141, 49);
            this.HomeBtn.TabIndex = 3;
            this.HomeBtn.Text = "   Accueil";
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
            this.VehiculesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.VehiculesBtn.Name = "VehiculesBtn";
            this.VehiculesBtn.Size = new System.Drawing.Size(141, 49);
            this.VehiculesBtn.TabIndex = 2;
            this.VehiculesBtn.Text = "   Véhicules";
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
            this.SalariesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SalariesBtn.Name = "SalariesBtn";
            this.SalariesBtn.Size = new System.Drawing.Size(141, 49);
            this.SalariesBtn.TabIndex = 1;
            this.SalariesBtn.Text = "   Salariés";
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
            this.ProduitsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ProduitsBtn.Name = "ProduitsBtn";
            this.ProduitsBtn.Size = new System.Drawing.Size(141, 49);
            this.ProduitsBtn.TabIndex = 0;
            this.ProduitsBtn.Text = "   Produits";
            this.ProduitsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProduitsBtn.UseVisualStyleBackColor = true;
            this.ProduitsBtn.Click += new System.EventHandler(this.ProduitsBtn_Click);
            // 
            // CommandeBtn
            // 
            this.CommandeBtn.FlatAppearance.BorderSize = 0;
            this.CommandeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommandeBtn.Image = ((System.Drawing.Image)(resources.GetObject("CommandeBtn.Image")));
            this.CommandeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CommandeBtn.Location = new System.Drawing.Point(9, 303);
            this.CommandeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CommandeBtn.Name = "CommandeBtn";
            this.CommandeBtn.Size = new System.Drawing.Size(141, 49);
            this.CommandeBtn.TabIndex = 0;
            this.CommandeBtn.Text = "   Commandes";
            this.CommandeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CommandeBtn.UseVisualStyleBackColor = true;
            this.CommandeBtn.Click += new System.EventHandler(this.CommandeBtn_Click);
            // 
            // ClientsBtn
            // 
            this.ClientsBtn.FlatAppearance.BorderSize = 0;
            this.ClientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ClientsBtn.Image")));
            this.ClientsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientsBtn.Location = new System.Drawing.Point(9, 352);
            this.ClientsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClientsBtn.Name = "ClientsBtn";
            this.ClientsBtn.Size = new System.Drawing.Size(141, 49);
            this.ClientsBtn.TabIndex = 0;
            this.ClientsBtn.Text = "   Clients";
            this.ClientsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClientsBtn.UseVisualStyleBackColor = true;
            this.ClientsBtn.Click += new System.EventHandler(this.ClientsBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(243, 7);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 96);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 8);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Midias.BTSCs.App.Properties.Resources.logo_livretou;
            this.pictureBox2.Location = new System.Drawing.Point(395, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
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
            this.minimizeAppBox.Margin = new System.Windows.Forms.Padding(2);
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
            this.closeAppBox.Margin = new System.Windows.Forms.Padding(2);
            this.closeAppBox.Name = "closeAppBox";
            this.closeAppBox.Size = new System.Drawing.Size(9, 10);
            this.closeAppBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeAppBox.TabIndex = 3;
            this.closeAppBox.TabStop = false;
            this.closeAppBox.Click += new System.EventHandler(this.closeAppBox_Click);
            // 
            // LivraisonBtn
            // 
            this.LivraisonBtn.FlatAppearance.BorderSize = 0;
            this.LivraisonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LivraisonBtn.Image = ((System.Drawing.Image)(resources.GetObject("LivraisonBtn.Image")));
            this.LivraisonBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LivraisonBtn.Location = new System.Drawing.Point(9, 405);
            this.LivraisonBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LivraisonBtn.Name = "LivraisonBtn";
            this.LivraisonBtn.Size = new System.Drawing.Size(141, 49);
            this.LivraisonBtn.TabIndex = 6;
            this.LivraisonBtn.Text = "   Livraisons";
            this.LivraisonBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LivraisonBtn.UseVisualStyleBackColor = true;
            this.LivraisonBtn.Click += new System.EventHandler(this.LivraisonBtn_Click);
            
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
            // ProduitUC
            // 
            this.produitUC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.produitUC.Location = new System.Drawing.Point(154, 108);
            this.produitUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.produitUC.Name = "ProduitUC";
            this.produitUC.Size = new System.Drawing.Size(886, 532);
            this.produitUC.TabIndex = 6;
            // 
            // SalarieUC
            // 
            this.salarieUC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.salarieUC.Location = new System.Drawing.Point(154, 108);
            this.salarieUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salarieUC.Name = "SalarieUC";
            this.salarieUC.Size = new System.Drawing.Size(886, 532);
            this.salarieUC.TabIndex = 6;
            // 
            // ClientUC
            // 
            this.clientUC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clientUC.Location = new System.Drawing.Point(154, 108);
            this.clientUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientUC.Name = "ClientUC";
            this.clientUC.Size = new System.Drawing.Size(886, 532);
            this.clientUC.TabIndex = 6;
            // 
            // CommandeUC
            // 
            this.commandeUC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.commandeUC.Location = new System.Drawing.Point(154, 108);
            this.commandeUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commandeUC.Name = "CommandeUC";
            this.commandeUC.Size = new System.Drawing.Size(886, 532);
            this.commandeUC.TabIndex = 6;

            // 
            // LivraisonUC
            // 
            this.livraisonUC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.livraisonUC.Location = new System.Drawing.Point(154, 108);
            this.livraisonUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.livraisonUC.Name = "LivraisonUC";
            this.livraisonUC.Size = new System.Drawing.Size(886, 532);
            this.livraisonUC.TabIndex = 6;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.vehiculeUC1);
            this.Controls.Add(this.homeUC);
            this.Controls.Add(this.produitUC);
            this.Controls.Add(this.salarieUC);
            this.Controls.Add(this.clientUC);
            this.Controls.Add(this.commandeUC);
            this.Controls.Add(this.livraisonUC);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.minimizeAppBox);
            this.Controls.Add(this.closeAppBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.homeUC.Hide();
            this.salarieUC.Hide();
            this.clientUC.Hide();
            this.commandeUC.Hide();
            this.livraisonUC.Hide();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ProduitsBtn;
        private System.Windows.Forms.Button SalariesBtn;
        private System.Windows.Forms.Button VehiculesBtn;
        private System.Windows.Forms.Button CommandeBtn;
        private System.Windows.Forms.Button ClientsBtn;
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
        private UserControls.ProduitUC produitUC;
        private UserControls.SalarieUC salarieUC;
        private UserControls.ClientUC clientUC;
        private UserControls.CommandeUC commandeUC;
        private UserControls.LivraisonUC livraisonUC;
        private System.Windows.Forms.Button LivraisonBtn;
    }
}

