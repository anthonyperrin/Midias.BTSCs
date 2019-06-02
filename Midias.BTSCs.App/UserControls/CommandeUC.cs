using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midias.BTSCs.Services.Services;
using Midias.BTSCs.Dto;

namespace Midias.BTSCs.App.UserControls
{
    public partial class CommandeUC : UserControl
    {
        private ICommandesService _commandesService = new CommandesService();
        private PersonnalTools _tools = new PersonnalTools();

        public CommandeUC()
        {
            InitializeComponent();

            CommandeDto[] commandes = _commandesService.GetCommandes().ToArray();
            if (commandes.Length > 0)
            {
                string[] excludedValues = new string[] { "Client", "Livraison"};

                gridCommandes = _tools.GenerateGrid(gridCommandes, commandes, excludedValues);

                gridCommandes.Columns[0].Width = 30;
                gridCommandes.Columns[0].ReadOnly = true;
                gridCommandes.Columns[1].ReadOnly = true;
                gridCommandes.Columns[2].Width = 75;
                gridCommandes.Columns[3].Width = 125;
                gridCommandes.Columns[3].ReadOnly = true;
                gridCommandes.Columns[4].Width = 125;
                gridCommandes.Columns[4].ReadOnly = true;

            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
