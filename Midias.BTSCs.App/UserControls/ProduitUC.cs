using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midias.BTSCs.Services;
using System.Diagnostics;
using Midias.BTSCs.Dto;
using Midias.BTSCs.Services.Services;

namespace Midias.BTSCs.App.UserControls
{
    public partial class ProduitUC : UserControl
    {
        private IProduitsService _produitsService = new ProduitsService();
        private IMouvementsService _mouvementsService = new MouvementsService();
        private PersonnalTools _tools = new PersonnalTools();

        public ProduitUC()
        {
            InitializeComponent();

            var produits = _produitsService.GetProduits();

            string[] excludedValues = new string[] {"Mouvement"};
            if (produits.Count > 0)
            {
                gridProducts = _tools.GenerateGridHeaders(gridProducts, produits[0], excludedValues);
                foreach (ProduitDto product in produits)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    var mouvements = _mouvementsService.GetMouvements().Where(m => m.Produit.Id == product.Id).ToList().ToArray();
                    
                    row.CreateCells(gridProducts);

                    row.Cells[0].Value = product.Id;
                    row.Cells[1].Value = product.Libelle;
                    row.Cells[2].Value = product.PrixHT;
                    row.Cells[3].Value = product.Taxe;
                    row.Cells[4].Value = product.Quantite;
                    row.Cells[5].Value = product.Categorie.Libelle;
                    if (mouvements.Length > 0)
                    {
                        //row.Cells[6].
                    }

                    gridProducts.Rows.Add(row);
                }
            }
            

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
        }

        private void ProduitUC_Load(object sender, EventArgs e)
        {

        }
     
    }
}
