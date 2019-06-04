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

namespace Midias.BTSCs.App.UserControls
{
    public partial class HomeUC : UserControl
    {
        private IVehiculeService _vehiculesService = new VehiculeService();

        public HomeUC()
        {
            InitializeComponent();

            var vehicules = _vehiculesService.GetVehicules();
            dataGridViewVehicules.DataSource = vehicules;
        }
    }
}
