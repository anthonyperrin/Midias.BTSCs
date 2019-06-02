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

            ProduitDto[] produits = _produitsService.GetProduits().ToArray();
            var categories = _categorieService.GetCategories();

            this.comboBox1.DataSource = categories;

            string[] excludedValues = new string[] {"Mouvement"};
            if (produits.Length > 0)
            {
                gridProducts = _tools.GenerateGrid(gridProducts, produits, excludedValues);
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
