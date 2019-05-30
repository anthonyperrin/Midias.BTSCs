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
            dataGridView1.AllowUserToAddRows = true;
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

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(modeleText.Text) && !String.IsNullOrEmpty(marqueText.Text) && !String.IsNullOrEmpty(immatText.Text) && !String.IsNullOrEmpty(cartegriseText.Text)){
                VehiculeDto vehicule = new VehiculeDto();
                vehicule.CarteGrise = cartegriseText.Text;
                vehicule.Immatriculation = immatText.Text;
                vehicule.Modele = modeleText.Text;
                vehicule.Marque = marqueText.Text;
                this._vehiculesService.AddVehicule(vehicule);
                var vehicules = _vehiculesService.GetVehicules();
                dataGridView1.DataSource = vehicules;

                modeleText.ResetText();
                marqueText.ResetText();
                cartegriseText.ResetText();
                immatText.ResetText();
            }

        }
    }
}
