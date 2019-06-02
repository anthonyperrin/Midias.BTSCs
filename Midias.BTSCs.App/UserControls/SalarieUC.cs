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
        PersonnalTools _tools = new PersonnalTools();
        string[] excludedValues = new string[] { "Livraison" };

        public SalarieUC()
        {
            InitializeComponent();

            SalarieDto[] salaries = _salarieService.GetSalaries().ToArray();

            
            if (salaries.Length > 0)
            {
                gridSalaries = _tools.GenerateGrid(gridSalaries, salaries, excludedValues);
            }
        }

        private void SalarieUC_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAddSalarie_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxName.Text) && !String.IsNullOrEmpty(textBoxFirstName.Text) && !String.IsNullOrEmpty(textBoxPermis.Text) && !String.IsNullOrEmpty(textBoxMail.Text) && !String.IsNullOrEmpty(textBoxPhone.Text))
            {
                SalarieDto salarie = new SalarieDto()
                {
                    Nom = textBoxName.Text,
                    Prenom = textBoxFirstName.Text,
                    Valide = true,
                    Permis = textBoxPermis.Text,
                    Email = textBoxMail.Text,
                    Telephone = textBoxPhone.Text
                };

                _salarieService.CreateNewSalarie(salarie);

                UpdateDataGrid();

                textBoxName.ResetText();
                textBoxFirstName.ResetText();
                textBoxPermis.ResetText();
                textBoxMail.ResetText();
                textBoxPhone.ResetText();

            }
        }

        private void UpdateDataGrid()
        {
            SalarieDto[] salaries = _salarieService.GetSalaries().ToArray();
            gridSalaries = _tools.GenerateGrid(gridSalaries, salaries, excludedValues);
        }
    }
}
