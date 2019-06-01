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
            ((System.ComponentModel.ISupportInitialize)(this.gridSalaries)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSalaries
            // 
            this.gridSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSalaries.Location = new System.Drawing.Point(3, 3);
            this.gridSalaries.Name = "gridSalaries";
            this.gridSalaries.Size = new System.Drawing.Size(672, 518);
            this.gridSalaries.TabIndex = 0;
            // 
            // SalarieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridSalaries);
            this.Name = "SalarieUC";
            this.Size = new System.Drawing.Size(887, 547);
            this.Load += new System.EventHandler(this.SalarieUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSalaries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSalaries;
    }
}
