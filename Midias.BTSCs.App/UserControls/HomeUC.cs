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
        IVehiculeService _vehiculeService { get; set; }
        public HomeUC()
        {
            InitializeComponent();
            // TO DO : SET INDENTITY ON PRIMARY KEYS IN DB
            _vehiculeService = new VehiculeService();
            var newVehicule = new VehiculeDto()
            {
                Immatriculation = "ABC123ABC",
                CarteGrise = "1000055824",
                Marque = "Fiat",
                Modele = "Punto"
            };
            _vehiculeService.AddVehicule(newVehicule);
            var vehicules = _vehiculeService.GetVehicules();

            listBoxVehicules.DataSource = vehicules;
        }
    }
}
