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
using Midias.BTSCs.Services.Services;

namespace Midias.BTSCs.App.UserControls
{ 
    public partial class ClientUC : UserControl
    {
        private PersonnalTools _tools = new PersonnalTools();
        private IClientsService _clientsService = new ClientsService();
        private IAdressesService _adressesService = new AdressesService();

        public ClientUC()
        {
            InitializeComponent();
            this.UpdateDataGrid();
            
        }

        private void UpdateDataGrid()
        {
            ClientDto[] clients = _clientsService.GetClients().ToArray();
            List<AdresseDto> adresses = _adressesService.GetAdresses();


            string[] excludedValues = new string[] { "Adresse", "Commande" };

            if (clients.Length > 0)
            {
                gridClients.Rows.Clear();
                gridClients = _tools.GenerateGrid(gridClients, clients, excludedValues);
                gridClients.Columns[0].Width = 30;
                gridClients.Columns[0].ReadOnly = true;
                gridClients.Columns[3].ReadOnly = true;
                gridClients.Columns[4].ReadOnly = true;
                gridClients.Columns[5].ReadOnly = true;
                gridClients.Columns[5].Width = 75;

            }
            gridClients.AllowUserToAddRows = false;

            comboBox1.DataSource = adresses;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text) && !String.IsNullOrEmpty(textBox5.Text))
            {
                AdresseDto adresse = new AdresseDto();
                adresse.Rue1 = textBox1.Text;
                adresse.Rue2 = textBox2.Text;
                adresse.CodePostal = textBox3.Text;
                adresse.Ville = textBox4.Text;
                adresse.Pays = textBox5.Text;

                _adressesService.CreateNewAdresse(adresse);

                textBox1.ResetText();
                textBox2.ResetText();
                textBox3.ResetText();
                textBox4.ResetText();
                textBox5.ResetText();

                comboBox1.DataSource = _adressesService.GetAdresses();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox6.Text) && !String.IsNullOrEmpty(textBox7.Text))
            {
                AdresseDto adresse = _adressesService.GetAdresses().Where(c => c.Id == Convert.ToInt32(comboBox1.SelectedValue)).FirstOrDefault();

                ClientDto client = new ClientDto();
                client.Nom = textBox6.Text;
                client.Prenom = textBox7.Text;
                client.Adresse = adresse;

                _clientsService.CreateNewClient(client);

                textBox6.ResetText();
                textBox7.ResetText();

                this.UpdateDataGrid();
            }
        }

        private void GridClients_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ClientDto client = new ClientDto();
            int id = Convert.ToInt32(gridClients.Rows[e.RowIndex].Cells[0].Value);
            client = _clientsService.GetClients().Where(p => p.Id == id).FirstOrDefault();
            client.Nom = gridClients.Rows[e.RowIndex].Cells[1].Value.ToString();
            client.Prenom = gridClients.Rows[e.RowIndex].Cells[1].Value.ToString();
           
            client = this._clientsService.UpdateClient(client);
        }
    }
}
