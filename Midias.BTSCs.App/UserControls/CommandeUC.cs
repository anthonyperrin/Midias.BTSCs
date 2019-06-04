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
using System.Diagnostics;
using Midias.BTSCs.Services;

namespace Midias.BTSCs.App.UserControls
{
    public partial class CommandeUC : UserControl
    {
        private ICommandesService _commandesService = new CommandesService();
        private IClientsService _clientsService = new ClientsService();
        private IProduitCommandeService _produitCommandeService = new ProduitCommandeService();
        private IProduitsService _produitsService = new ProduitsService();
        private PersonnalTools _tools = new PersonnalTools();
        private List<ProduitCommandeDto> produitsDansCommande = new List<ProduitCommandeDto>();
        private double totalPriceHT = 0;
        private double totalPriceTT = 0;
        private bool areHidden = false;
        int selectedCommandId;

        public CommandeUC()
        {
            InitializeComponent();

            HideOrShowElements();

            comboBoxClient.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxClient.DisplayMember = "Nom";

            CommandeDto[] commandes = _commandesService.GetCommandes().ToArray();
            var clients = _clientsService.GetClients();

            comboBoxClient.DataSource = clients;
            if (commandes.Length > 0)
            {
                string[] excludedValues = new string[] { "Client", "Livraison", "ProduitCommandes"};

                gridCommandes = _tools.GenerateGrid(gridCommandes, commandes, excludedValues);

                gridCommandes.Columns[0].Width = 30;
                gridCommandes.Columns[0].ReadOnly = true;
                gridCommandes.Columns[1].ReadOnly = true;
                gridCommandes.Columns[2].Width = 75;
                gridCommandes.Columns[3].Width = 125;
                gridCommandes.Columns[3].ReadOnly = true;
                gridCommandes.Columns[4].Width = 125;
                gridCommandes.Columns[4].ReadOnly = true;

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int clientId = Convert.ToInt32(comboBoxClient.SelectedValue);
            ClientDto client = _clientsService.GetClients().Where(c => c.Id == clientId).FirstOrDefault();
            CommandeDto commande = new CommandeDto()
            {
                Libelle = textBoxLibelle.Text.Trim(),
                Etat = 0,
                DateCreation = DateTime.Now,
                DateValidation = DateTime.Now,
                Client = client,
            };

            _commandesService.CreateNewCommande(commande);

            UpdateDataGrid();

            textBoxLibelle.ResetText();
        }

        private void UpdateDataGrid()
        {
            CommandeDto[] commandes = _commandesService.GetCommandes().ToArray();
            var clients = _clientsService.GetClients();
            string[] excludedValues = new string[] { "Client", "Livraison", "ProduitCommandes" };
            comboBoxClient.DataSource = clients;

            if (commandes.Length > 0)
            {
                gridCommandes.Rows.Clear();
                _tools.GenerateGrid(gridCommandes, commandes, excludedValues);
            }
        }

        private void GridCommandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(gridCommandes.Rows[e.RowIndex].Cells[0].Value);

                if (e.ColumnIndex == 5)
                {
                    CommandeDto commande = _commandesService.GetCommandes().Where(c => c.Id == id).FirstOrDefault();
                    ClientDto client = _clientsService.GetClients().Where(c => c.Id == commande.Client.Id).FirstOrDefault();
                    string clientToShow = "";
                    clientToShow += client.Id + "\n";
                    clientToShow += client.Nom + "\n";
                    clientToShow += client.Prenom + "\n";
                    clientToShow += client.Adresse.Rue1 + "\n";
                    if (!String.IsNullOrEmpty(client.Adresse.Rue2))
                    {
                        clientToShow += client.Adresse.Rue2;
                    }
                    clientToShow += client.Adresse.Ville + "\n";
                    clientToShow += client.Adresse.CodePostal + "\n";
                    clientToShow += client.Adresse.Pays + "\n";
                    MessageBox.Show(clientToShow, "Informations de " + commande.Client.Nom + " " + commande.Client.Prenom);
                }
                else if (e.ColumnIndex == 6)
                {
                    string productToShow = "";
                    CommandeDto commande = _commandesService.GetCommandes().Where(c => c.Id == id).FirstOrDefault();
                    List<ProduitCommandeDto> produitCommande = _produitCommandeService.GetProduitCommandes().Where(pc => pc.Commande.Id == commande.Id).ToList();
                    if (produitCommande.Count > 0)
                    {
                        
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
                    else
                    {
                        MessageBox.Show("Il n'y a pas de produits dans cette commande pour le moment", "Erreur");
                    }
                }
                else
                {
                    selectedCommandId = id;
                    CommandeDto commande = _commandesService.GetCommandes().Where(c => c.Id == id).FirstOrDefault();
                    if (commande.Etat == 0)
                    {
                        totalPriceHT = 0;
                        totalPriceTT = 0;
                        labelTotalPrices.ResetText();
                        areHidden = true;
                        HideOrShowElements();
                        if (produitsDansCommande.Count > 0)
                        {
                            produitsDansCommande.Clear();
                            labelProductInCommand.Text = "";
                        }
                        labelLibelleCommande.Text = commande.Id + " - " + commande.Libelle;

                        var produits = _produitsService.GetProduits().ToList();
                        comboBoxProduits.DataSource = produits;
                    }
                    else
                    {
                        areHidden = false;
                        HideOrShowElements();
                    }
                }
            }
        }

        private void HideOrShowElements()
        {
            if (areHidden)
            {
                labelAddProduct.Show();
                labelLibelleCommande.Show();
                labelProductInCommand.Show();
                labelProduit.Show();
                labelQty.Show();
                labelRecap.Show();
                comboBoxProduits.Show();
                numericUpDownQty.Show();
                buttonAddProduct.Show();
                buttonValidateCommand.Show();
            } else
            {
                labelAddProduct.Hide();
                labelLibelleCommande.Hide();
                labelProductInCommand.Hide();
                labelProduit.Hide();
                labelQty.Hide();
                labelRecap.Hide();
                comboBoxProduits.Hide();
                numericUpDownQty.Hide();
                buttonAddProduct.Hide();
                buttonValidateCommand.Hide();
            }
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            ProduitDto produit = _produitsService.GetProduits().Where(c => c.Id == Convert.ToInt32(comboBoxProduits.SelectedValue)).FirstOrDefault();

            if (produit != null)
            {
                if (numericUpDownQty.Value >= 1)
                {
                    if (produit.Quantite >= numericUpDownQty.Value)
                    {
                        int qty = Decimal.ToInt32(numericUpDownQty.Value);
                        double prixHT = (double)produit.PrixHT;
                        double taxe = (double)produit.Taxe;
                        totalPriceHT += Math.Round(qty * prixHT, 2);
                        totalPriceTT += Math.Round(qty * prixHT * (1 + taxe), 2);
                        labelTotalPrices.Text = "Prix Total HT : " + totalPriceHT + "€\n";
                        labelTotalPrices.Text += "Prix Total TT : " + totalPriceTT + "€\n";
                        CommandeDto commande = _commandesService.GetCommandes().Where(c => c.Id == selectedCommandId).FirstOrDefault();
                        ProduitCommandeDto produitCommande = new ProduitCommandeDto()
                        {
                            Quantite = qty,
                            Produit = produit,
                            Commande = commande
                        };
                        produitsDansCommande.Add(produitCommande);
                        labelProductInCommand.Text += qty + " " + produit.Libelle + " " + produit.PrixHT * qty + "€\n";
                        numericUpDownQty.Value = 1;
                        List<ProduitDto> produitRestant = new List<ProduitDto>();
                        var produits = _produitsService.GetProduits().ToList();
                        foreach (ProduitDto prod in produits)
                        {
                            bool isInList = produitsDansCommande.Exists(pc => pc.Produit.Id == prod.Id);
                            if (!isInList)
                            {
                                produitRestant.Add(prod);
                            }
                        }
                        comboBoxProduits.DataSource = produitRestant;
                    } else
                    {
                        MessageBox.Show("La quantité en stock est insuffisante.\nIl reste " + produit.Quantite + " " + produit.Libelle, "ERROR");
                    }
                }
            }
        }

        private void ButtonValidateCommand_Click(object sender, EventArgs e)
        {
            CommandeDto commande = _commandesService.GetCommandes().Where(c => c.Id == selectedCommandId).FirstOrDefault();
            commande.Etat = 1;
            commande.DateValidation = DateTime.Now;
            _commandesService.UpdateCommande(commande);
            foreach(ProduitCommandeDto produitCommande in produitsDansCommande)
            {
                _produitCommandeService.CreateNewProduitCommands(produitCommande);
            }
            areHidden = false;
            HideOrShowElements();
            totalPriceHT = 0;
            totalPriceTT = 0;
            labelTotalPrices.ResetText();
            if (produitsDansCommande.Count > 0)
            {
                produitsDansCommande.Clear();
                labelProductInCommand.Text = "";
            }
            UpdateDataGrid();

        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSearch.Text))
            {
                gridCommandes.Rows.Clear();
                this.UpdateDataGrid();
            }
            else
            {

                CommandeDto[] commandes = _commandesService.GetCommandes().Where(c => c.Libelle.ToUpper().Contains(textBoxSearch.Text.ToUpper()) || c.DateCreation.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()) || c.DateValidation.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper()) || c.Etat.ToString().ToUpper().Contains(textBoxSearch.Text.ToUpper())).ToArray();

                string[] excludedValues = new string[] { "Client", "Livraison", "ProduitCommandes" };
                if (commandes.Length > 0)
                {
                    gridCommandes.Rows.Clear();
                    gridCommandes = _tools.GenerateGrid(gridCommandes, commandes, excludedValues);
                }
            }
        }
    }
}
