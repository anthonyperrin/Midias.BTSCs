namespace Midias.BTSCs.App.UserControls
{
    partial class VehiculeUC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehiculeDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Midias_BTSCsDataSet = new Midias.BTSCs.App._Midias_BTSCsDataSet();
            this.vehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculeTableAdapter = new Midias.BTSCs.App._Midias_BTSCsDataSetTableAdapters.VehiculeTableAdapter();
            this.midiasBTSCsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carteGriseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.immatriculationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Midias_BTSCsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midiasBTSCsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.carteGriseDataGridViewTextBoxColumn,
            this.immatriculationDataGridViewTextBoxColumn,
            this.modeleDataGridViewTextBoxColumn,
            this.marqueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehiculeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(588, 527);
            this.dataGridView1.TabIndex = 0;
            // 
            // vehiculeDtoBindingSource
            // 
            this.vehiculeDtoBindingSource.DataSource = typeof(Midias.BTSCs.Dto.VehiculeDto);
            // 
            // _Midias_BTSCsDataSet
            // 
            this._Midias_BTSCsDataSet.DataSetName = "_Midias_BTSCsDataSet";
            this._Midias_BTSCsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculeBindingSource
            // 
            this.vehiculeBindingSource.DataMember = "Vehicule";
            this.vehiculeBindingSource.DataSource = this._Midias_BTSCsDataSet;
            // 
            // vehiculeTableAdapter
            // 
            this.vehiculeTableAdapter.ClearBeforeFill = true;
            // 
            // midiasBTSCsDataSetBindingSource
            // 
            this.midiasBTSCsDataSetBindingSource.DataSource = this._Midias_BTSCsDataSet;
            this.midiasBTSCsDataSetBindingSource.Position = 0;
            // 
            // vehiculeBindingSource1
            // 
            this.vehiculeBindingSource1.DataMember = "Vehicule";
            this.vehiculeBindingSource1.DataSource = this.midiasBTSCsDataSetBindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carteGriseDataGridViewTextBoxColumn
            // 
            this.carteGriseDataGridViewTextBoxColumn.DataPropertyName = "CarteGrise";
            this.carteGriseDataGridViewTextBoxColumn.HeaderText = "CarteGrise";
            this.carteGriseDataGridViewTextBoxColumn.Name = "carteGriseDataGridViewTextBoxColumn";
            // 
            // immatriculationDataGridViewTextBoxColumn
            // 
            this.immatriculationDataGridViewTextBoxColumn.DataPropertyName = "Immatriculation";
            this.immatriculationDataGridViewTextBoxColumn.HeaderText = "Immatriculation";
            this.immatriculationDataGridViewTextBoxColumn.Name = "immatriculationDataGridViewTextBoxColumn";
            // 
            // modeleDataGridViewTextBoxColumn
            // 
            this.modeleDataGridViewTextBoxColumn.DataPropertyName = "Modele";
            this.modeleDataGridViewTextBoxColumn.HeaderText = "Modele";
            this.modeleDataGridViewTextBoxColumn.Name = "modeleDataGridViewTextBoxColumn";
            // 
            // marqueDataGridViewTextBoxColumn
            // 
            this.marqueDataGridViewTextBoxColumn.DataPropertyName = "Marque";
            this.marqueDataGridViewTextBoxColumn.HeaderText = "Marque";
            this.marqueDataGridViewTextBoxColumn.Name = "marqueDataGridViewTextBoxColumn";
            // 
            // VehiculeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VehiculeUC";
            this.Size = new System.Drawing.Size(886, 532);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Midias_BTSCsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midiasBTSCsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vehiculeDtoBindingSource;
        private System.Windows.Forms.BindingSource vehiculeBindingSource;
        private _Midias_BTSCsDataSet _Midias_BTSCsDataSet;
        private _Midias_BTSCsDataSetTableAdapters.VehiculeTableAdapter vehiculeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carteGriseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn immatriculationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vehiculeBindingSource1;
        private System.Windows.Forms.BindingSource midiasBTSCsDataSetBindingSource;
    }
}
