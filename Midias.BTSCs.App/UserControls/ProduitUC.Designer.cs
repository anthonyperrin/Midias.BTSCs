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
            ((System.ComponentModel.ISupportInitialize)(this._Midias_BTSCsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDtoBindingSource1)).BeginInit();
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
            this.gridProducts.Size = new System.Drawing.Size(646, 488);
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
            // ProduitUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridProducts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProduitUC";
            this.Size = new System.Drawing.Size(981, 494);
            this.Load += new System.EventHandler(this.ProduitUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Midias_BTSCsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDtoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource produitDtoBindingSource;
        private System.Windows.Forms.BindingSource produitDtoBindingSource1;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private _Midias_BTSCsDataSet1 _Midias_BTSCsDataSet1;
        private _Midias_BTSCsDataSet1TableAdapters.CategorieTableAdapter categorieTableAdapter;
        private System.Windows.Forms.DataGridView gridProducts;
    }
}
