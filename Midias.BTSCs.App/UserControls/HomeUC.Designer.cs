namespace Midias.BTSCs.App.UserControls
{
    partial class HomeUC
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
            this.dataGridViewVehicules = new System.Windows.Forms.DataGridView();
            this.immatriculationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculeDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVehicules
            // 
            this.dataGridViewVehicules.AutoGenerateColumns = false;
            this.dataGridViewVehicules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.immatriculationDataGridViewTextBoxColumn,
            this.modeleDataGridViewTextBoxColumn,
            this.marqueDataGridViewTextBoxColumn});
            this.dataGridViewVehicules.DataSource = this.vehiculeDtoBindingSource;
            this.dataGridViewVehicules.Location = new System.Drawing.Point(663, 6);
            this.dataGridViewVehicules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewVehicules.Name = "dataGridViewVehicules";
            this.dataGridViewVehicules.RowTemplate.Height = 24;
            this.dataGridViewVehicules.Size = new System.Drawing.Size(395, 650);
            this.dataGridViewVehicules.TabIndex = 0;
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
            // vehiculeDtoBindingSource
            // 
            this.vehiculeDtoBindingSource.DataSource = typeof(Midias.BTSCs.Dto.VehiculeDto);
            // 
            // HomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewVehicules);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(1181, 656);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVehicules;
        private System.Windows.Forms.BindingSource vehiculeDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn immatriculationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marqueDataGridViewTextBoxColumn;
    }
}
