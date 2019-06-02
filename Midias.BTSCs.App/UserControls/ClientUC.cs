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


            string[] excludedValues = new string[] { };
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
        }
    }
}
