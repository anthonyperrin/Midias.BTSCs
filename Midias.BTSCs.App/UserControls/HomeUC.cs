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
using Midias.BTSCs.Dto;

namespace Midias.BTSCs.App.UserControls
{
    public partial class HomeUC : UserControl
    {
        public IList<ProduitDto> _produits { get; set; }

        public HomeUC()
        {
            InitializeComponent();

            IProduitsService produitsService = new ProduitsService();
            _produits = produitsService.GetProduits();
            Console.Write(_produits[0].Libelle);
        }
    }
}
