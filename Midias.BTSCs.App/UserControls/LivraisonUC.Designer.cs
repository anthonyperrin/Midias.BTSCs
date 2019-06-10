namespace Midias.BTSCs.App.UserControls
{
    partial class LivraisonUC
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
            this.gridLivraisons = new System.Windows.Forms.DataGridView();
            this.labelAddLivraison = new System.Windows.Forms.Label();
            this.comboBoxAdresse = new System.Windows.Forms.ComboBox();
            this.adresseDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCommande = new System.Windows.Forms.ComboBox();
            this.commandeDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSalarie = new System.Windows.Forms.ComboBox();
            this.salarieDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxVehicule = new System.Windows.Forms.ComboBox();
            this.vehiculeDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddLivraison = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonConfirmLivraison = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLivraisons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresseDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarieDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLivraisons
            // 
            this.gridLivraisons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLivraisons.Location = new System.Drawing.Point(4, 41);
            this.gridLivraisons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridLivraisons.Name = "gridLivraisons";
            this.gridLivraisons.Size = new System.Drawing.Size(867, 639);
            this.gridLivraisons.TabIndex = 0;
            this.gridLivraisons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridLivraisons_CellContentClick_1);
            // 
            // labelAddLivraison
            // 
            this.labelAddLivraison.AutoSize = true;
            this.labelAddLivraison.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddLivraison.Location = new System.Drawing.Point(903, 41);
            this.labelAddLivraison.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddLivraison.Name = "labelAddLivraison";
            this.labelAddLivraison.Size = new System.Drawing.Size(230, 29);
            this.labelAddLivraison.TabIndex = 2;
            this.labelAddLivraison.Text = "Ajouter une livraison";
            // 
            // comboBoxAdresse
            // 
            this.comboBoxAdresse.DataSource = this.adresseDtoBindingSource;
            this.comboBoxAdresse.DisplayMember = "Rue1";
            this.comboBoxAdresse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdresse.FormattingEnabled = true;
            this.comboBoxAdresse.Location = new System.Drawing.Point(884, 116);
            this.comboBoxAdresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxAdresse.Name = "comboBoxAdresse";
            this.comboBoxAdresse.Size = new System.Drawing.Size(292, 24);
            this.comboBoxAdresse.TabIndex = 3;
            this.comboBoxAdresse.ValueMember = "Id";
            // 
            // adresseDtoBindingSource
            // 
            this.adresseDtoBindingSource.DataSource = typeof(Midias.BTSCs.Dto.AdresseDto);
            // 
            // comboBoxCommande
            // 
            this.comboBoxCommande.DataSource = this.commandeDtoBindingSource;
            this.comboBoxCommande.DisplayMember = "Libelle";
            this.comboBoxCommande.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCommande.FormattingEnabled = true;
            this.comboBoxCommande.Location = new System.Drawing.Point(884, 187);
            this.comboBoxCommande.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCommande.Name = "comboBoxCommande";
            this.comboBoxCommande.Size = new System.Drawing.Size(292, 24);
            this.comboBoxCommande.TabIndex = 4;
            this.comboBoxCommande.ValueMember = "Id";
            // 
            // commandeDtoBindingSource
            // 
            this.commandeDtoBindingSource.DataSource = typeof(Midias.BTSCs.Dto.CommandeDto);
            // 
            // comboBoxSalarie
            // 
            this.comboBoxSalarie.DataSource = this.salarieDtoBindingSource;
            this.comboBoxSalarie.DisplayMember = "Nom";
            this.comboBoxSalarie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSalarie.FormattingEnabled = true;
            this.comboBoxSalarie.Location = new System.Drawing.Point(884, 265);
            this.comboBoxSalarie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSalarie.Name = "comboBoxSalarie";
            this.comboBoxSalarie.Size = new System.Drawing.Size(292, 24);
            this.comboBoxSalarie.TabIndex = 5;
            this.comboBoxSalarie.ValueMember = "Id";
            // 
            // salarieDtoBindingSource
            // 
            this.salarieDtoBindingSource.DataSource = typeof(Midias.BTSCs.Dto.SalarieDto);
            // 
            // comboBoxVehicule
            // 
            this.comboBoxVehicule.DataSource = this.vehiculeDtoBindingSource;
            this.comboBoxVehicule.DisplayMember = "Immatriculation";
            this.comboBoxVehicule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVehicule.FormattingEnabled = true;
            this.comboBoxVehicule.Location = new System.Drawing.Point(884, 341);
            this.comboBoxVehicule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxVehicule.Name = "comboBoxVehicule";
            this.comboBoxVehicule.Size = new System.Drawing.Size(292, 24);
            this.comboBoxVehicule.TabIndex = 6;
            this.comboBoxVehicule.ValueMember = "Id";
            // 
            // vehiculeDtoBindingSource
            // 
            this.vehiculeDtoBindingSource.DataSource = typeof(Midias.BTSCs.Dto.VehiculeDto);
            // 
            // buttonAddLivraison
            // 
            this.buttonAddLivraison.Location = new System.Drawing.Point(884, 395);
            this.buttonAddLivraison.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddLivraison.Name = "buttonAddLivraison";
            this.buttonAddLivraison.Size = new System.Drawing.Size(293, 28);
            this.buttonAddLivraison.TabIndex = 7;
            this.buttonAddLivraison.Text = "Ajouter";
            this.buttonAddLivraison.UseVisualStyleBackColor = true;
            this.buttonAddLivraison.Click += new System.EventHandler(this.ButtonAddLivraison_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(884, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(884, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Commande";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(884, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Salarié";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(884, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Véhicule";
            // 
            // buttonConfirmLivraison
            // 
            this.buttonConfirmLivraison.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonConfirmLivraison.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmLivraison.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmLivraison.Location = new System.Drawing.Point(884, 447);
            this.buttonConfirmLivraison.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConfirmLivraison.Name = "buttonConfirmLivraison";
            this.buttonConfirmLivraison.Size = new System.Drawing.Size(293, 207);
            this.buttonConfirmLivraison.TabIndex = 12;
            this.buttonConfirmLivraison.Text = "Livraison terminée";
            this.buttonConfirmLivraison.UseVisualStyleBackColor = false;
            this.buttonConfirmLivraison.Click += new System.EventHandler(this.ButtonConfirmLivraison_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(128, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(743, 22);
            this.textBoxSearch.TabIndex = 13;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(4, 12);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(106, 20);
            this.labelSearch.TabIndex = 14;
            this.labelSearch.Text = "Rechercher :";
            // 
            // LivraisonUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonConfirmLivraison);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddLivraison);
            this.Controls.Add(this.comboBoxVehicule);
            this.Controls.Add(this.comboBoxSalarie);
            this.Controls.Add(this.comboBoxCommande);
            this.Controls.Add(this.comboBoxAdresse);
            this.Controls.Add(this.labelAddLivraison);
            this.Controls.Add(this.gridLivraisons);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LivraisonUC";
            this.Size = new System.Drawing.Size(1181, 683);
            ((System.ComponentModel.ISupportInitialize)(this.gridLivraisons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresseDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarieDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLivraisons;
        private System.Windows.Forms.Label labelAddLivraison;
        private System.Windows.Forms.ComboBox comboBoxAdresse;
        private System.Windows.Forms.ComboBox comboBoxCommande;
        private System.Windows.Forms.ComboBox comboBoxSalarie;
        private System.Windows.Forms.ComboBox comboBoxVehicule;
        private System.Windows.Forms.Button buttonAddLivraison;
        private System.Windows.Forms.BindingSource adresseDtoBindingSource;
        private System.Windows.Forms.BindingSource commandeDtoBindingSource;
        private System.Windows.Forms.BindingSource salarieDtoBindingSource;
        private System.Windows.Forms.BindingSource vehiculeDtoBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonConfirmLivraison;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
    }
}
