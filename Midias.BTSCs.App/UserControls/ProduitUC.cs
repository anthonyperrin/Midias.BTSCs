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
        private ICategoriesService _categorieService = new CategoriesService();

        private PersonnalTools _tools = new PersonnalTools();

        public ProduitUC()
        {
            InitializeComponent();

            this.UpdateDataGrid();

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

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text))
            {
                var categories = _categorieService.GetCategories();
                CategorieDto cat = categories.Where(c => c.Id == Convert.ToInt32(comboBox1.SelectedValue)).FirstOrDefault();
                ProduitDto prod = new ProduitDto();
                prod.Libelle = textBox1.Text;
                prod.PrixHT = Convert.ToDouble(textBox2.Text);
                prod.Quantite = Convert.ToInt32(textBox3.Text);
                prod.Taxe = Convert.ToDouble(textBox4.Text);
                prod.Categorie = cat;

                _produitsService.CreateNewProduit(prod);

                this.UpdateDataGrid();

                textBox1.ResetText();
                textBox2.ResetText();
                textBox3.ResetText();
                textBox4.ResetText();
            }
        }

        private void UpdateDataGrid()
        {
            var produits = _produitsService.GetProduits();
            var categories = _categorieService.GetCategories();

            this.comboBox1.DataSource = categories;

            string[] excludedValues = new string[] { "Mouvement" };
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
    }
}
