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
    public partial class VehiculeUC : UserControl
    {
        private IVehiculeService _vehiculesService = new VehiculeService();
        public VehiculeUC()
        {
            InitializeComponent();
            var vehicules = _vehiculesService.GetVehicules();

            dataGridView1.DataSource = vehicules;
        }
    }
}
