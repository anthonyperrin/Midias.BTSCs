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
        private Boolean _isLoaded = false;
        public VehiculeUC()
        {
            InitializeComponent();
            var vehicules = _vehiculesService.GetVehicules();

            dataGridView1.DataSource = vehicules;
            this._isLoaded = true;
        }

        private void DataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (this._isLoaded)
            {
                VehiculeDto vehicule = new VehiculeDto();
                vehicule = (VehiculeDto)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                vehicule = this._vehiculesService.UpdateVehicule(vehicule);
               
            }
        }
    }
}
