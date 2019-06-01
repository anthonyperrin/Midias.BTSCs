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
    public partial class SalarieUC : UserControl
    {

        SalarieService _salarieService = new SalarieService();

        public SalarieUC()
        {
            InitializeComponent();

            var salaries = _salarieService.GetSalaries();
            var _tools = new PersonnalTools();

            string[] excludedValues = new string[] { "Livraison" };
            if (salaries.Count > 0)
            {
                gridSalaries = _tools.GenerateGridHeaders(gridSalaries, salaries[0], excludedValues);
                foreach (SalarieDto salarie in salaries)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    //var mouvements = _salarieService.GetMouvements().Where(m => m.Produit.Id == product.Id).ToList().ToArray();

                    row.CreateCells(gridSalaries);

                    row.Cells[0].Value = salarie.Id;
                    row.Cells[1].Value = salarie.Nom;
                    row.Cells[2].Value = salarie.Prenom;
                    row.Cells[3].Value = salarie.Valide;
                    row.Cells[4].Value = salarie.Permis;
                    row.Cells[5].Value = salarie.Email;
                    row.Cells[6].Value = salarie.Telephone;
                    

                    gridSalaries.Rows.Add(row);
                }
            }
        }

        private void SalarieUC_Load(object sender, EventArgs e)
        {

        }
    }
}
