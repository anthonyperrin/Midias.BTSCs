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
using Midias.BTSCs.Services;

namespace Midias.BTSCs.App.UserControls
{
    public partial class LivraisonUC : UserControl
    {
        private ILivraisonsService _livraisonsService = new LivraisonsService();
        private ISalarieService _salariesService = new SalarieService();
        private IAdressesService _adressesService = new AdressesService();
        private IVehiculeService _vehiculesService = new VehiculeService();
        private ICommandesService _commandesService = new CommandesService();
        private IProduitCommandeService _produitCommandeService = new ProduitCommandeService();

        int selectedLivraisonId;

        private double totalPriceHT = 0;
        private double totalPriceTT = 0;

        private PersonnalTools _tools = new PersonnalTools();
        public LivraisonUC()
        {
            InitializeComponent();
            gridLivraisons.AllowUserToAddRows = false;
            gridLivraisons.AllowUserToDeleteRows = false;
            UpdateDataGrid();
        }

        public void UpdateDataGrid()
        {
            selectedLivraisonId = 0;
            buttonConfirmLivraison.Hide();

            gridLivraisons.Rows.Clear();

            string[] excludedValues = new string[] {
                "Salarie",
                "Adresse",
                "Commande",
                "Vehicule",
            };

            LivraisonDto[] livraisons = _livraisonsService.GetLivraisons().ToArray();
            gridLivraisons = _tools.GenerateGrid(gridLivraisons, livraisons, excludedValues);

            List<AdresseDto> adresses = _adressesService.GetAdresses().ToList();
            comboBoxAdresse.DataSource = adresses;

            List<CommandeDto> commandes = _commandesService.GetCommandes().Where(c => c.Etat == 1).ToList();
            comboBoxCommande.DataSource = commandes;

            List<SalarieDto> salaries = _salariesService.GetSalaries().Where(s => s.Valide == true).ToList();
            comboBoxSalarie.DataSource = salaries;

            List<VehiculeDto> vehicules = _vehiculesService.GetVehicules().ToList();
            comboBoxVehicule.DataSource = vehicules;
        }


        private void ButtonAddLivraison_Click(object sender, EventArgs e)
        {
            AdresseDto adresse = _adressesService.GetAdresses().Where(a => a.Id == Convert.ToInt32(comboBoxAdresse.SelectedValue)).FirstOrDefault();
            CommandeDto commande = _commandesService.GetCommandes().Where(c => c.Id == Convert.ToInt32(comboBoxCommande.SelectedValue)).FirstOrDefault();
            SalarieDto salarie = _salariesService.GetSalaries().Where(s => s.Id == Convert.ToInt32(comboBoxSalarie.SelectedValue)).FirstOrDefault();
            VehiculeDto vehicule = _vehiculesService.GetVehicules().Where(v => v.Id == Convert.ToInt32(comboBoxVehicule.SelectedValue)).FirstOrDefault();

            LivraisonDto livraison = new LivraisonDto()
            {
                DateLivraison = null,
                Adresse = adresse,
                Commande = commande,
                Salarie = salarie,
                Vehicule = vehicule
            };

            _livraisonsService.CreateNewLivraison(livraison);

            UpdateDataGrid();
        }

        private void ButtonConfirmLivraison_Click(object sender, EventArgs e)
        {
            if (selectedLivraisonId > 0)
            {
                LivraisonDto livraison = _livraisonsService.GetLivraisons().Where(l => l.Id == selectedLivraisonId).FirstOrDefault();
                livraison.DateLivraison = DateTime.Now;

                _livraisonsService.UpdateLivraison(livraison);

                UpdateDataGrid();
            }
        }
        private void GridLivraisons_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(gridLivraisons.Rows[e.RowIndex].Cells[0].Value);
                LivraisonDto livraison = _livraisonsService.GetLivraisons().Where(l => l.Id == id).FirstOrDefault();
                buttonConfirmLivraison.Hide();

                if (e.ColumnIndex == 2)
                {
                    AdresseDto adresse = _adressesService.GetAdresses().Where(a => a.Id == livraison.Adresse.Id).FirstOrDefault();
                    string adresseToShow = "";
                    adresseToShow += adresse.Id + "\n";
                    adresseToShow += adresse.Rue1 + "\n";
                    if (!String.IsNullOrEmpty(adresse.Rue2))
                    {
                        adresseToShow += adresse.Rue2;
                    }
                    adresseToShow += adresse.Ville + "\n";
                    adresseToShow += adresse.CodePostal + "\n";
                    adresseToShow += adresse.Pays + "\n";

                    MessageBox.Show(adresseToShow, "Adresse de destination");
                }
                else if (e.ColumnIndex == 3)
                {
                    totalPriceHT = 0;
                    totalPriceTT = 0;
                    string productToShow = "";
                    CommandeDto commande = _commandesService.GetCommandes().Where(c => c.Id == livraison.Commande.Id).FirstOrDefault();
                    List<ProduitCommandeDto> produitCommande = _produitCommandeService.GetProduitCommandes().Where(pc => pc.Commande.Id == commande.Id).ToList();

                    foreach (ProduitCommandeDto produit in produitCommande)
                    {
                        if (produit.Quantite > 1)
                        {
                            produit.Produit.Libelle += "s";
                        }
                        productToShow += produit.Quantite + " " + produit.Produit.Libelle + " à " + produit.Produit.PrixHT * produit.Quantite + "€\n";
                        double prixHT = (double)produit.Produit.PrixHT;
                        double taxe = (double)produit.Produit.Taxe;
                        totalPriceHT += Math.Round(produit.Quantite * prixHT, 2);
                        totalPriceTT += Math.Round(produit.Quantite * prixHT * (1 + taxe), 2);
                    }
                    productToShow += "\n";
                    productToShow += "______________________ \n";
                    productToShow += "\n";
                    productToShow += "Prix HT : " + totalPriceHT + "€\n";
                    productToShow += "Prix TT : " + totalPriceTT + "€\n";

                    MessageBox.Show(productToShow, "Produits dans " + commande.Libelle);
                }
                else if (e.ColumnIndex == 4)
                {
                    SalarieDto salarie = _salariesService.GetSalaries().Where(s => s.Id == livraison.Salarie.Id).FirstOrDefault();
                    string salarieToShow = "";
                    salarieToShow += salarie.Id + "\n";
                    salarieToShow += salarie.Nom + "\n";
                    salarieToShow += salarie.Prenom + "\n";
                    salarieToShow += salarie.Permis + "\n";
                    salarieToShow += salarie.Email + "\n";
                    salarieToShow += salarie.Telephone + "\n";


                    MessageBox.Show(salarieToShow, "Informations de " + salarie.Nom + " " + salarie.Prenom);
                }
                else if (e.ColumnIndex == 5)
                {
                    VehiculeDto vehicule = _vehiculesService.GetVehicules().Where(v => v.Id == livraison.Vehicule.Id).FirstOrDefault();
                    string vehiculeToShow = "";
                    vehiculeToShow += vehicule.Id + "\n";
                    vehiculeToShow += vehicule.Immatriculation + "\n";
                    vehiculeToShow += vehicule.CarteGrise + "\n";
                    vehiculeToShow += vehicule.Modele + "\n";
                    vehiculeToShow += vehicule.Marque + "\n";

                    MessageBox.Show(vehiculeToShow, "Informations du véhicule");
                }
                else
                {
                    if (livraison.DateLivraison == null)
                    {
                        buttonConfirmLivraison.Show();
                        selectedLivraisonId = id;
                    } else
                    {
                        buttonConfirmLivraison.Hide();

                    }
                }
            }
        }
    }
}
