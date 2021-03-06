﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midias.BTSCs.Services;
using System.Diagnostics;
using Midias.BTSCs.Dto;
using Midias.BTSCs.Services.Services;

namespace Midias.BTSCs.App.UserControls
{
    public partial class ProduitUC : UserControl
    {
        private IProduitsService _produitsService = new ProduitsService();
        private IMouvementsService _mouvementsService = new MouvementsService();
        private ICategoriesService _categorieService = new CategoriesService();

        private PersonnalTools _tools = new PersonnalTools();

        public ProduitUC()
        {
            InitializeComponent();

            var categories = _categorieService.GetCategories().ToList();
            comboBoxCategories.DataSource = categories;
            var products = _produitsService.GetProduits().ToList();
            comboBoxProducts.DataSource = products;

            comboBoxCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProducts.DropDownStyle = ComboBoxStyle.DropDownList;

            this.UpdateDataGrid();
            
            if (products.Count > 0)
            {
                gridProducts.Columns[0].Width = 30;
                gridProducts.Columns[0].ReadOnly = true;
                gridProducts.Columns[2].Width = 75;
                gridProducts.Columns[3].Width = 75;
                gridProducts.Columns[4].Width = 75;
                gridProducts.Columns[4].ReadOnly = true;
                gridProducts.Columns[5].ReadOnly = true;
            }
            

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
        }

        private void ProduitUC_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text))
            {
                var categories = _categorieService.GetCategories();
                CategorieDto cat = categories.Where(c => c.Id == Convert.ToInt32(comboBoxCategories.SelectedValue)).FirstOrDefault();
                ProduitDto prod = new ProduitDto()
                {
                    Libelle = textBox1.Text,
                    PrixHT = Convert.ToDouble(textBox2.Text),
                    Quantite = Convert.ToInt32(textBox3.Text),
                    Taxe = Convert.ToDouble(textBox4.Text),
                    Categorie = cat
                };
                
                _produitsService.CreateNewProduit(prod);

                this.UpdateDataGrid();

                textBox1.ResetText();
                textBox2.ResetText();
                textBox3.ResetText();
                textBox4.ResetText();
            }
        }

        private void UpdateDataGrid()
        {
            ProduitDto[] produits = _produitsService.GetProduits().ToArray();
            var categories = _categorieService.GetCategories();

            this.comboBoxCategories.DataSource = categories;
            this.comboBoxProducts.DataSource = produits;

            string[] excludedValues = new string[] { "Mouvements" };
            if (produits.Length > 0)
            {
                gridProducts.Rows.Clear();
                gridProducts = _tools.GenerateGrid(gridProducts, produits, excludedValues);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(stokTextBox.Text))
            {
                ProduitDto prod = _produitsService.GetProduits().Where(p => p.Id == Convert.ToInt32(comboBoxProducts.SelectedValue)).FirstOrDefault();
                MouvementDto mouv = new MouvementDto();
                mouv.Produit = prod;
                mouv.Quantite = Convert.ToInt32(stokTextBox.Text);
                mouv.DateCreation = DateTime.Now;

                _mouvementsService.CreateNewMouvement(mouv);

                this.UpdateDataGrid();

                stokTextBox.ResetText();
            }
        }

        private void GridProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ProduitDto prod = new ProduitDto();
            int id = Convert.ToInt32(gridProducts.Rows[e.RowIndex].Cells[0].Value);
            prod = _produitsService.GetProduits().Where(p=>p.Id == id).FirstOrDefault();
            prod.Libelle = gridProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
            prod.PrixHT = Convert.ToDouble(gridProducts.Rows[e.RowIndex].Cells[2].Value);
            prod.Taxe = Convert.ToDouble(gridProducts.Rows[e.RowIndex].Cells[3].Value);
            prod = this._produitsService.UpdateProduit(prod);
        }

        private void GridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int id = Convert.ToInt32(gridProducts.Rows[e.RowIndex].Cells[0].Value);
                ProduitDto produit = _produitsService.GetProduits().Where(p => p.Id == id).FirstOrDefault();
                List<MouvementDto> mouvements = _mouvementsService.GetMouvements().Where(m => m.Produit.Id == id).ToList();
                string mouvementsToShow = "ID       Quantité                    Date\n";
                if (mouvements.Count > 0)
                {
                    foreach (MouvementDto mvt in mouvements)
                    {
                        string qte;
                        if (mvt.Quantite.ToString().Length == 1)
                        {
                            qte = "0" + mvt.Quantite.ToString();
                        } else
                        {
                            qte = mvt.Quantite.ToString();
                        }
                        mouvementsToShow += mvt.Id + "        " + qte + "                    " + mvt.DateCreation + "\n";
                    }
                    MessageBox.Show(mouvementsToShow, "Mouvements de " + produit.Libelle);
                } else
                {
                    MessageBox.Show("Il n'y a pas de mouvements");
                }
            }
        }

        private void GridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox5.Text))
            {
                gridProducts.Rows.Clear();
                this.UpdateDataGrid();
            }
            else
            {

                ProduitDto[] produits = _produitsService.GetProduits().Where(p => p.Libelle.ToUpper().Contains(textBox5.Text.ToUpper())).ToArray();
                //ProduitDto[] produits = _produitsService.GetProduits().Where(p => p.Libelle.ToUpper().Contains(textBox5.Text.ToUpper()) || p.Categorie.Libelle.ToUpper().Contains(textBox5.Text.ToUpper())).ToArray();
                var categories = _categorieService.GetCategories();

                string[] excludedValues = new string[] { "Mouvements" };
                if (produits.Length > 0)
                {
                    gridProducts.Rows.Clear();
                    gridProducts = _tools.GenerateGrid(gridProducts, produits, excludedValues);
                }
            }
        }
    }
}
