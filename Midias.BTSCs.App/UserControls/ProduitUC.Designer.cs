﻿namespace Midias.BTSCs.App.UserControls
{
    partial class ProduitUC
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.produitDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitDtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.categorieBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categorieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.stokTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.categorieDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Location = new System.Drawing.Point(3, 30);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.Size = new System.Drawing.Size(613, 499);
            this.gridProducts.TabIndex = 0;
            this.gridProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProducts_CellContentClick);
            this.gridProducts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProducts_CellEndEdit);
            // 
            // produitDtoBindingSource
            // 
            this.produitDtoBindingSource.DataSource = typeof(Midias.BTSCs.Dto.ProduitDto);
            // 
            // produitDtoBindingSource1
            // 
            this.produitDtoBindingSource1.DataSource = typeof(Midias.BTSCs.Dto.ProduitDto);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(623, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajouter un nouveau produit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Libelle :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(671, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prix HT :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(676, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(681, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(202, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantité :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(665, 111);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(218, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Taxe :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(622, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Catégorie :";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categorieDtoBindingSource, "Libelle", true));
            this.comboBoxCategories.DataSource = this.categorieDtoBindingSource;
            this.comboBoxCategories.DisplayMember = "Libelle";
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(686, 137);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(197, 21);
            this.comboBoxCategories.TabIndex = 11;
            this.comboBoxCategories.ValueMember = "Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(623, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Modifier le stock d\'un produit";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(622, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Produit :";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produitDtoBindingSource, "Libelle", true));
            this.comboBoxProducts.DataSource = this.produitDtoBindingSource;
            this.comboBoxProducts.DisplayMember = "Libelle";
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(674, 276);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(209, 21);
            this.comboBoxProducts.TabIndex = 15;
            this.comboBoxProducts.ValueMember = "Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(622, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Stock :";
            // 
            // stokTextBox
            // 
            this.stokTextBox.Location = new System.Drawing.Point(669, 307);
            this.stokTextBox.Name = "stokTextBox";
            this.stokTextBox.Size = new System.Drawing.Size(214, 20);
            this.stokTextBox.TabIndex = 17;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(622, 333);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(261, 23);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "Valider la modification de stock";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(78, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(537, 20);
            this.textBox5.TabIndex = 19;
            this.textBox5.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Rechercher :";
            // 
            // categorieDtoBindingSource
            // 
            this.categorieDtoBindingSource.DataSource = typeof(Midias.BTSCs.Dto.CategorieDto);
            // 
            // ProduitUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.stokTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridProducts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProduitUC";
            this.Size = new System.Drawing.Size(886, 532);
            this.Load += new System.EventHandler(this.ProduitUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource produitDtoBindingSource;
        private System.Windows.Forms.BindingSource produitDtoBindingSource1;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.BindingSource categorieBindingSource2;
        private System.Windows.Forms.BindingSource categorieBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stokTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource categorieDtoBindingSource;
    }
}
