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
            this.listBoxVehicules = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxVehicules
            // 
            this.listBoxVehicules.FormattingEnabled = true;
            this.listBoxVehicules.ItemHeight = 16;
            this.listBoxVehicules.Location = new System.Drawing.Point(851, 3);
            this.listBoxVehicules.Name = "listBoxVehicules";
            this.listBoxVehicules.Size = new System.Drawing.Size(309, 644);
            this.listBoxVehicules.TabIndex = 0;
            // 
            // HomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxVehicules);
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(1182, 655);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVehicules;
    }
}
