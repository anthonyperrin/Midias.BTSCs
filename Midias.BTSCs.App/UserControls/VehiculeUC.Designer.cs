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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carteGriseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.immatriculationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suppression = new System.Windows.Forms.DataGridViewButtonColumn();
            this.vehiculeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.midiasBTSCsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Midias_BTSCsDataSet = new Midias.BTSCs.App._Midias_BTSCsDataSet();
            this.vehiculeDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculeTableAdapter = new Midias.BTSCs.App._Midias_BTSCsDataSetTableAdapters.VehiculeTableAdapter();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cartegriseText = new System.Windows.Forms.TextBox();
            this.immatText = new System.Windows.Forms.TextBox();
            this.modeleText = new System.Windows.Forms.TextBox();
            this.marqueText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midiasBTSCsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Midias_BTSCsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).BeginInit();
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
            this.marqueDataGridViewTextBoxColumn,
            this.Suppression});
            this.dataGridView1.DataSource = this.vehiculeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(613, 527);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 30F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
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
            // Suppression
            // 
            this.Suppression.HeaderText = "Suppression";
            this.Suppression.Name = "Suppression";
            this.Suppression.Text = "Supprimer";
            this.Suppression.UseColumnTextForButtonValue = true;
            // 
            // vehiculeBindingSource1
            // 
            this.vehiculeBindingSource1.DataMember = "Vehicule";
            this.vehiculeBindingSource1.DataSource = this.midiasBTSCsDataSetBindingSource;
            // 
            // midiasBTSCsDataSetBindingSource
            // 
            this.midiasBTSCsDataSetBindingSource.DataSource = this._Midias_BTSCsDataSet;
            this.midiasBTSCsDataSetBindingSource.Position = 0;
            // 
            // _Midias_BTSCsDataSet
            // 
            this._Midias_BTSCsDataSet.DataSetName = "_Midias_BTSCsDataSet";
            this._Midias_BTSCsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculeDtoBindingSource
            // 
            this.vehiculeDtoBindingSource.DataSource = typeof(Midias.BTSCs.Dto.VehiculeDto);
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
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(634, 159);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(231, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Ajouter";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carte Grise :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Immatriculation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modele :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Marque :";
            // 
            // cartegriseText
            // 
            this.cartegriseText.Location = new System.Drawing.Point(702, 55);
            this.cartegriseText.Name = "cartegriseText";
            this.cartegriseText.Size = new System.Drawing.Size(162, 20);
            this.cartegriseText.TabIndex = 6;
            // 
            // immatText
            // 
            this.immatText.Location = new System.Drawing.Point(720, 81);
            this.immatText.Name = "immatText";
            this.immatText.Size = new System.Drawing.Size(144, 20);
            this.immatText.TabIndex = 7;
            // 
            // modeleText
            // 
            this.modeleText.Location = new System.Drawing.Point(683, 107);
            this.modeleText.Name = "modeleText";
            this.modeleText.Size = new System.Drawing.Size(181, 20);
            this.modeleText.TabIndex = 8;
            // 
            // marqueText
            // 
            this.marqueText.Location = new System.Drawing.Point(683, 133);
            this.marqueText.Name = "marqueText";
            this.marqueText.Size = new System.Drawing.Size(181, 20);
            this.marqueText.TabIndex = 9;
            // 
            // VehiculeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.marqueText);
            this.Controls.Add(this.modeleText);
            this.Controls.Add(this.immatText);
            this.Controls.Add(this.cartegriseText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VehiculeUC";
            this.Size = new System.Drawing.Size(886, 532);
            this.Load += new System.EventHandler(this.VehiculeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midiasBTSCsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Midias_BTSCsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vehiculeDtoBindingSource;
        private System.Windows.Forms.BindingSource vehiculeBindingSource;
        private _Midias_BTSCsDataSet _Midias_BTSCsDataSet;
        private _Midias_BTSCsDataSetTableAdapters.VehiculeTableAdapter vehiculeTableAdapter;
        private System.Windows.Forms.BindingSource vehiculeBindingSource1;
        private System.Windows.Forms.BindingSource midiasBTSCsDataSetBindingSource;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cartegriseText;
        private System.Windows.Forms.TextBox immatText;
        private System.Windows.Forms.TextBox modeleText;
        private System.Windows.Forms.TextBox marqueText;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carteGriseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn immatriculationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Suppression;
    }
}
