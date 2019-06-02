namespace Midias.BTSCs.App.UserControls
{
    partial class SalarieUC
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
            this.gridSalaries = new System.Windows.Forms.DataGridView();
            this.salarieName = new System.Windows.Forms.Label();
            this.salarieFirstname = new System.Windows.Forms.Label();
            this.Permis = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxPermis = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonAddSalarie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSalaries)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSalaries
            // 
            this.gridSalaries.AllowUserToAddRows = false;
            this.gridSalaries.AllowUserToDeleteRows = false;
            this.gridSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSalaries.Location = new System.Drawing.Point(3, 3);
            this.gridSalaries.Name = "gridSalaries";
            this.gridSalaries.Size = new System.Drawing.Size(629, 491);
            this.gridSalaries.TabIndex = 0;
            // 
            // salarieName
            // 
            this.salarieName.AutoSize = true;
            this.salarieName.Location = new System.Drawing.Point(643, 17);
            this.salarieName.Name = "salarieName";
            this.salarieName.Size = new System.Drawing.Size(29, 13);
            this.salarieName.TabIndex = 1;
            this.salarieName.Text = "Nom";
            // 
            // salarieFirstname
            // 
            this.salarieFirstname.AutoSize = true;
            this.salarieFirstname.Location = new System.Drawing.Point(643, 51);
            this.salarieFirstname.Name = "salarieFirstname";
            this.salarieFirstname.Size = new System.Drawing.Size(43, 13);
            this.salarieFirstname.TabIndex = 2;
            this.salarieFirstname.Text = "Prénom";
            // 
            // Permis
            // 
            this.Permis.AutoSize = true;
            this.Permis.Location = new System.Drawing.Point(643, 84);
            this.Permis.Name = "Permis";
            this.Permis.Size = new System.Drawing.Size(38, 13);
            this.Permis.TabIndex = 4;
            this.Permis.Text = "Permis";
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Location = new System.Drawing.Point(644, 118);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(32, 13);
            this.Mail.TabIndex = 5;
            this.Mail.Text = "Email";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(644, 156);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(58, 13);
            this.Phone.TabIndex = 6;
            this.Phone.Text = "Téléphone";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(708, 17);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(131, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(708, 48);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(131, 20);
            this.textBoxFirstName.TabIndex = 8;
            // 
            // textBoxPermis
            // 
            this.textBoxPermis.Location = new System.Drawing.Point(708, 81);
            this.textBoxPermis.Name = "textBoxPermis";
            this.textBoxPermis.Size = new System.Drawing.Size(23, 20);
            this.textBoxPermis.TabIndex = 9;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(708, 115);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(153, 20);
            this.textBoxMail.TabIndex = 10;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(708, 153);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 11;
            // 
            // buttonAddSalarie
            // 
            this.buttonAddSalarie.Location = new System.Drawing.Point(708, 199);
            this.buttonAddSalarie.Name = "buttonAddSalarie";
            this.buttonAddSalarie.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSalarie.TabIndex = 12;
            this.buttonAddSalarie.Text = "Ajouter";
            this.buttonAddSalarie.UseVisualStyleBackColor = true;
            this.buttonAddSalarie.Click += new System.EventHandler(this.ButtonAddSalarie_Click);
            // 
            // SalarieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddSalarie);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxPermis);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Permis);
            this.Controls.Add(this.salarieFirstname);
            this.Controls.Add(this.salarieName);
            this.Controls.Add(this.gridSalaries);
            this.Name = "SalarieUC";
            this.Size = new System.Drawing.Size(894, 502);
            this.Load += new System.EventHandler(this.SalarieUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSalaries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSalaries;
        private System.Windows.Forms.Label salarieName;
        private System.Windows.Forms.Label salarieFirstname;
        private System.Windows.Forms.Label Permis;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxPermis;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonAddSalarie;
    }
}
