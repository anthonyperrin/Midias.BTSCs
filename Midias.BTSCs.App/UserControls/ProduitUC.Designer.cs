namespace Midias.BTSCs.App.UserControls
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
            this._Midias_BTSCsDataSet1 = new Midias.BTSCs.App._Midias_BTSCsDataSet1();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieTableAdapter = new Midias.BTSCs.App._Midias_BTSCsDataSet1TableAdapters.CategorieTableAdapter();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._Midias_BTSCsDataSet2 = new Midias.BTSCs.App._Midias_BTSCsDataSet2();
            this.categorieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categorieTableAdapter1 = new Midias.BTSCs.App._Midias_BTSCsDataSet2TableAdapters.CategorieTableAdapter();
            this._Midias_BTSCsDataSet3 = new Midias.BTSCs.App._Midias_BTSCsDataSet3();
            this.categorieBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categorieTableAdapter2 = new Midias.BTSCs.App._Midias_BTSCsDataSet3TableAdapters.CategorieTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._Midias_BTSCsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Midias_BTSCsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Midias_BTSCsDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // _Midias_BTSCsDataSet1
            // 
            this._Midias_BTSCsDataSet1.DataSetName = "_Midias_BTSCsDataSet1";
            this._Midias_BTSCsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this._Midias_BTSCsDataSet1;
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Location = new System.Drawing.Point(3, 3);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.Size = new System.Drawing.Size(613, 526);
            this.gridProducts.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(634, 6);
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categorieBindingSource2;
            this.comboBox1.DisplayMember = "Libelle";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(686, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "Id";
            // 
            // _Midias_BTSCsDataSet2
            // 
            this._Midias_BTSCsDataSet2.DataSetName = "_Midias_BTSCsDataSet2";
            this._Midias_BTSCsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categorieBindingSource1
            // 
            this.categorieBindingSource1.DataMember = "Categorie";
            this.categorieBindingSource1.DataSource = this._Midias_BTSCsDataSet2;
            // 
            // categorieTableAdapter1
            // 
            this.categorieTableAdapter1.ClearBeforeFill = true;
            // 
            // _Midias_BTSCsDataSet3
            // 
            this._Midias_BTSCsDataSet3.DataSetName = "_Midias_BTSCsDataSet3";
            this._Midias_BTSCsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categorieBindingSource2
            // 
            this.categorieBindingSource2.DataMember = "Categorie";
            this.categorieBindingSource2.DataSource = this._Midias_BTSCsDataSet3;
            // 
            // categorieTableAdapter2
            // 
            this.categorieTableAdapter2.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProduitUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this._Midias_BTSCsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Midias_BTSCsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Midias_BTSCsDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource produitDtoBindingSource;
        private System.Windows.Forms.BindingSource produitDtoBindingSource1;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private _Midias_BTSCsDataSet1 _Midias_BTSCsDataSet1;
        private _Midias_BTSCsDataSet1TableAdapters.CategorieTableAdapter categorieTableAdapter;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource categorieBindingSource2;
        private _Midias_BTSCsDataSet3 _Midias_BTSCsDataSet3;
        private _Midias_BTSCsDataSet2 _Midias_BTSCsDataSet2;
        private System.Windows.Forms.BindingSource categorieBindingSource1;
        private _Midias_BTSCsDataSet2TableAdapters.CategorieTableAdapter categorieTableAdapter1;
        private _Midias_BTSCsDataSet3TableAdapters.CategorieTableAdapter categorieTableAdapter2;
        private System.Windows.Forms.Button button1;
    }
}
