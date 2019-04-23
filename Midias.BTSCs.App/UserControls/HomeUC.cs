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
        IVehiculeService _vehiculeService { get; set; }
        public HomeUC()
        {
            InitializeComponent();

            _vehiculeService = new VehiculeService();

            var vehicules = _vehiculeService.GetVehicules();

            listBoxVehicules.DataSource = vehicules;
        }
    }
}
