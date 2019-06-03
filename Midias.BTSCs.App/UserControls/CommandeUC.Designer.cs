namespace Midias.BTSCs.App.UserControls
{
    partial class CommandeUC
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
            this.gridCommandes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLibelle = new System.Windows.Forms.TextBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.clientDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAddProduct = new System.Windows.Forms.Label();
            this.labelProductInCommand = new System.Windows.Forms.Label();
            this.labelRecap = new System.Windows.Forms.Label();
            this.comboBoxProduits = new System.Windows.Forms.ComboBox();
            this.produitDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelProduit = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.labelLibelleCommande = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonValidateCommand = new System.Windows.Forms.Button();
            this.labelTotalPrices = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCommandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCommandes
            // 
            this.gridCommandes.AllowUserToAddRows = false;
            this.gridCommandes.AllowUserToDeleteRows = false;
            this.gridCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCommandes.Location = new System.Drawing.Point(4, 4);
            this.gridCommandes.Name = "gridCommandes";
            this.gridCommandes.Size = new System.Drawing.Size(664, 526);
            this.gridCommandes.TabIndex = 0;
            this.gridCommandes.CellContentClick += GridCommandes_CellContentClick;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(689, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Libellé :";
            // 
            // textBoxLibelle
            // 
            this.textBoxLibelle.Location = new System.Drawing.Point(738, 49);
            this.textBoxLibelle.Name = "textBoxLibelle";
            this.textBoxLibelle.Size = new System.Drawing.Size(145, 20);
            this.textBoxLibelle.TabIndex = 3;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DataSource = this.clientDtoBindingSource;
            this.comboBoxClient.DisplayMember = "Nom";
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(738, 75);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(145, 21);
            this.comboBoxClient.TabIndex = 4;
            this.comboBoxClient.ValueMember = "Id";
            // 
            // clientDtoBindingSource
            // 
            this.clientDtoBindingSource.DataSource = typeof(Midias.BTSCs.Dto.ClientDto);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(689, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Client :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(738, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(674, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajouter une commande";
            // 
            // labelAddProduct
            // 
            this.labelAddProduct.AutoSize = true;
            this.labelAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddProduct.Location = new System.Drawing.Point(674, 144);
            this.labelAddProduct.Name = "labelAddProduct";
            this.labelAddProduct.Size = new System.Drawing.Size(178, 24);
            this.labelAddProduct.TabIndex = 7;
            this.labelAddProduct.Text = "Ajouter des produits";
            // 
            // labelProductInCommand
            // 
            this.labelProductInCommand.AutoSize = true;
            this.labelProductInCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductInCommand.Location = new System.Drawing.Point(689, 371);
            this.labelProductInCommand.Name = "labelProductInCommand";
            this.labelProductInCommand.Size = new System.Drawing.Size(0, 16);
            this.labelProductInCommand.TabIndex = 8;
            // 
            // labelRecap
            // 
            this.labelRecap.AutoSize = true;
            this.labelRecap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecap.Location = new System.Drawing.Point(674, 334);
            this.labelRecap.Name = "labelRecap";
            this.labelRecap.Size = new System.Drawing.Size(211, 24);
            this.labelRecap.TabIndex = 9;
            this.labelRecap.Text = "Récapitulatif commande";
            // 
            // comboBoxProduits
            // 
            this.comboBoxProduits.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produitDtoBindingSource, "Libelle", true));
            this.comboBoxProduits.DataSource = this.produitDtoBindingSource;
            this.comboBoxProduits.DisplayMember = "Libelle";
            this.comboBoxProduits.FormattingEnabled = true;
            this.comboBoxProduits.Location = new System.Drawing.Point(678, 217);
            this.comboBoxProduits.Name = "comboBoxProduits";
            this.comboBoxProduits.Size = new System.Drawing.Size(204, 21);
            this.comboBoxProduits.TabIndex = 10;
            this.comboBoxProduits.ValueMember = "Id";
            // 
            // produitDtoBindingSource
            // 
            this.produitDtoBindingSource.DataSource = typeof(Midias.BTSCs.Dto.ProduitDto);
            // 
            // labelProduit
            // 
            this.labelProduit.AutoSize = true;
            this.labelProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduit.Location = new System.Drawing.Point(678, 196);
            this.labelProduit.Name = "labelProduit";
            this.labelProduit.Size = new System.Drawing.Size(55, 18);
            this.labelProduit.TabIndex = 11;
            this.labelProduit.Text = "Produit";
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQty.Location = new System.Drawing.Point(678, 241);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(63, 18);
            this.labelQty.TabIndex = 12;
            this.labelQty.Text = "Quantité";
            // 
            // numericUpDownQty
            // 
            this.numericUpDownQty.Location = new System.Drawing.Point(678, 262);
            this.numericUpDownQty.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQty.Name = "numericUpDownQty";
            this.numericUpDownQty.Size = new System.Drawing.Size(204, 20);
            this.numericUpDownQty.TabIndex = 13;
            this.numericUpDownQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelLibelleCommande
            // 
            this.labelLibelleCommande.AutoSize = true;
            this.labelLibelleCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibelleCommande.Location = new System.Drawing.Point(678, 168);
            this.labelLibelleCommande.Name = "labelLibelleCommande";
            this.labelLibelleCommande.Size = new System.Drawing.Size(0, 18);
            this.labelLibelleCommande.TabIndex = 14;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(678, 288);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(205, 23);
            this.buttonAddProduct.TabIndex = 15;
            this.buttonAddProduct.Text = "Confirmer";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // buttonValidateCommand
            // 
            this.buttonValidateCommand.Location = new System.Drawing.Point(678, 507);
            this.buttonValidateCommand.Name = "buttonValidateCommand";
            this.buttonValidateCommand.Size = new System.Drawing.Size(205, 23);
            this.buttonValidateCommand.TabIndex = 16;
            this.buttonValidateCommand.Text = "Valider la commande";
            this.buttonValidateCommand.UseVisualStyleBackColor = true;
            this.buttonValidateCommand.Click += new System.EventHandler(this.ButtonValidateCommand_Click);
            // 
            // labelTotalPrices
            // 
            this.labelTotalPrices.AutoSize = true;
            this.labelTotalPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrices.Location = new System.Drawing.Point(689, 473);
            this.labelTotalPrices.Name = "labelTotalPrices";
            this.labelTotalPrices.Size = new System.Drawing.Size(0, 13);
            this.labelTotalPrices.TabIndex = 17;
            // 
            // CommandeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTotalPrices);
            this.Controls.Add(this.buttonValidateCommand);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.labelLibelleCommande);
            this.Controls.Add(this.numericUpDownQty);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.labelProduit);
            this.Controls.Add(this.comboBoxProduits);
            this.Controls.Add(this.labelRecap);
            this.Controls.Add(this.labelProductInCommand);
            this.Controls.Add(this.labelAddProduct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.textBoxLibelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridCommandes);
            this.Name = "CommandeUC";
            this.Size = new System.Drawing.Size(886, 533);
            ((System.ComponentModel.ISupportInitialize)(this.gridCommandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView gridCommandes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLibelle;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource clientDtoBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAddProduct;
        private System.Windows.Forms.Label labelProductInCommand;
        private System.Windows.Forms.Label labelRecap;
        private System.Windows.Forms.ComboBox comboBoxProduits;
        private System.Windows.Forms.Label labelProduit;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.NumericUpDown numericUpDownQty;
        private System.Windows.Forms.Label labelLibelleCommande;
        private System.Windows.Forms.Button buttonValidateCommand;
        private System.Windows.Forms.BindingSource produitDtoBindingSource;
        public System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Label labelTotalPrices;
    }
}
