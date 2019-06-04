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


        private void AddButton_Click(object sender, EventArgs e)
        {
            //Si les champs sont remplis
            if (!String.IsNullOrEmpty(modeleText.Text) && !String.IsNullOrEmpty(marqueText.Text) && !String.IsNullOrEmpty(immatText.Text) && !String.IsNullOrEmpty(cartegriseText.Text)){
                //Nouveau vehicule
                VehiculeDto vehicule = new VehiculeDto();
                vehicule.CarteGrise = cartegriseText.Text;
                vehicule.Immatriculation = immatText.Text;
                vehicule.Modele = modeleText.Text;
                vehicule.Marque = marqueText.Text;

                //Ajout vehicule
                this._vehiculesService.AddVehicule(vehicule);

                //UpdateAffichage
                this.UpdateDataGrid();

                //Reset des champs
                modeleText.ResetText();
                marqueText.ResetText();
                cartegriseText.ResetText();
                immatText.ResetText();
            }

        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this._isLoaded)
            {
                VehiculeDto vehicule = new VehiculeDto();
                vehicule = (VehiculeDto)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                vehicule = this._vehiculesService.UpdateVehicule(vehicule);

            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                VehiculeDto vehicule = new VehiculeDto();
                vehicule = (VehiculeDto)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                this._vehiculesService.DeleteVehicule(vehicule.Id);
                this.UpdateDataGrid();
            }
        }

        private void UpdateDataGrid()
        {
            var vehicules = _vehiculesService.GetVehicules();
            dataGridView1.DataSource = vehicules;
        }

        private void VehiculeUC_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                this.UpdateDataGrid();
            }
            else
            {
                var vehicules = _vehiculesService.GetVehicules().Where(v => v.Immatriculation.ToUpper().Contains(textBox1.Text.ToUpper())).ToList();
                dataGridView1.DataSource = vehicules;
                //var vehicules = _vehiculesService.GetVehicules().Where(v => (v.Immatriculation.ToUpper().Contains(textBox1.Text.ToUpper())) || (v.Marque.ToUpper().Contains(textBox1.Text.ToUpper())) || (v.Modele.ToUpper().Contains(textBox1.Text.ToUpper())) || (v.CarteGrise.ToUpper().Contains(textBox1.Text.ToUpper()))).ToList();
                //dataGridView1.DataSource = vehicules;
            }
        }
    }
}
