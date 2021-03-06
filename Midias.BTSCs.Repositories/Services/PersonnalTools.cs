﻿using Midias.BTSCs.Dto;
using Midias.BTSCs.Services.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midias.BTSCs
{
    public class PersonnalTools
    {
        private IMouvementsService _mouvementsService = new MouvementsService();

        public DataGridView GenerateGrid(DataGridView dataGrid, object[] arrayObjects, string[] excludedValues)
        {
            var listObjects = arrayObjects.ToList();
            if (listObjects.Count > 0)
            {
                var list = listObjects as IEnumerable<object>;
                string type = GetObjectType(listObjects[0]);
                dataGrid = GenerateGridHeaders(dataGrid, listObjects[0], excludedValues);
                switch (type)
                {
                    case "Salarie":
                        foreach (SalarieDto salarie in listObjects)
                        {
                            DataGridViewRow row = new DataGridViewRow();

                            row.CreateCells(dataGrid);

                            row.Cells[0].Value = salarie.Id;
                            row.Cells[1].Value = salarie.Nom;
                            row.Cells[2].Value = salarie.Prenom;
                            row.Cells[3].Value = "Non";
                            if (salarie.Valide == true)
                            {
                                row.Cells[3].Value = "Oui";
                            }
                            row.Cells[4].Value = salarie.Permis;
                            row.Cells[5].Value = salarie.Email;
                            row.Cells[6].Value = salarie.Telephone;


                            dataGrid.Rows.Add(row);
                        }
                        break;
                    case "Produit":
                        foreach(ProduitDto product in listObjects)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            var mouvements = _mouvementsService.GetMouvements().Where(m => m.Produit.Id == product.Id).ToList().ToArray();

                            row.CreateCells(dataGrid);

                            row.Cells[0].Value = product.Id;
                            row.Cells[1].Value = product.Libelle;
                            row.Cells[2].Value = product.PrixHT;
                            row.Cells[3].Value = product.Taxe;
                            row.Cells[4].Value = product.Quantite;
                            row.Cells[5].Value = product.Categorie.Libelle;

                            dataGrid.Rows.Add(row);
                        }
                        break;
                    case "Client":
                        foreach (ClientDto client in listObjects)
                        {
                            DataGridViewRow row = new DataGridViewRow();

                            row.CreateCells(dataGrid);

                            row.Cells[0].Value = client.Id;
                            row.Cells[1].Value = client.Nom;
                            row.Cells[2].Value = client.Prenom;
                            row.Cells[3].Value = client.Adresse.Rue1;
                            row.Cells[4].Value = client.Adresse.Ville;
                            row.Cells[5].Value = client.Adresse.CodePostal;

                            dataGrid.Rows.Add(row);
                        }
                        break;
                    case "Commande":
                        foreach (CommandeDto commande in listObjects)
                        {
                            DataGridViewRow row = new DataGridViewRow();

                            row.CreateCells(dataGrid);

                            row.Cells[0].Value = commande.Id;
                            row.Cells[1].Value = commande.Libelle;
                            row.Cells[2].Value = "Créée";
                            if (commande.Etat == 1)
                            {
                                row.Cells[2].Value = "Validée";
                            } else if (commande.Etat == 2)
                            {
                                row.Cells[2].Value = "En transit";
                            } else if (commande.Etat == 3)
                            {
                                row.Cells[2].Value = "Acheminée";
                            }
                            row.Cells[3].Value = commande.DateValidation;
                            row.Cells[4].Value = commande.DateCreation;

                            dataGrid.Rows.Add(row);
                        }
                        break;
                    case "Livraison":
                        foreach (LivraisonDto livraison in listObjects)
                        {
                            DataGridViewRow row = new DataGridViewRow();

                            row.CreateCells(dataGrid);

                            row.Cells[0].Value = livraison.Id;
                            row.Cells[1].Value = livraison.DateLivraison;
                            if (livraison.DateLivraison == null)
                            {
                                row.Cells[1].Value = "En transit";
                            }
                            dataGrid.Rows.Add(row);
                        }
                        break;
                    default:
                        Debug.WriteLine("Default");
                        break;
                }

            }
            return dataGrid;
        }


        public DataGridView GenerateGridHeaders(DataGridView dataGrid , object personnalObject, string[] excludedValues)
        {

            string objectType = GetObjectType(personnalObject);
            string[] properties = GetPropertiesArray(personnalObject);
            int objectSize = properties.Length - excludedValues.Length;
            dataGrid.ColumnCount = objectSize;
            switch (objectType)
            {
                case "Salarie":
                    dataGrid.ColumnCount = 7;
                    break;
                case "Client":
                    dataGrid.ColumnCount = 6;
                    break;
                case "Commande":
                    dataGrid.ColumnCount = 5;
                    break;
                case "Livraison":
                    dataGrid.ColumnCount = 2;
                    break;
                default:
                    Debug.WriteLine("Default");
                    break;
            };
            for (int i = 0; i < properties.Length; i++)
            {
                string value = properties[i];
                if (!excludedValues.Contains(properties[i]))
                {
                    dataGrid.Columns[i].HeaderText = value;
                    
                } else
                {
                    switch (objectType)
                    {
                        case "Client":
                            if (properties[i].Equals("Adresse"))
                            {
                                dataGrid.Columns[3].HeaderText = "Rue 1";
                                dataGrid.Columns[4].HeaderText = "Ville";
                                dataGrid.Columns[5].HeaderText = "Code postal";
                            }
                            break;
                        case "Produit":
                            DataGridViewButtonColumn colBtn = new DataGridViewButtonColumn()
                            {
                                Text = "Afficher",
                                Name = "Mouvements",
                                UseColumnTextForButtonValue = true,
                            };
                            dataGrid.Columns.Add(colBtn);
                            break;
                        case "Commande":
                            if (value.Equals("Client"))
                            {
                                DataGridViewButtonColumn colBtnClient = new DataGridViewButtonColumn()
                                {
                                    Text = "Afficher",
                                    Name = "Client",
                                    UseColumnTextForButtonValue = true,
                                };
                                dataGrid.Columns.Add(colBtnClient);
                            } else if (value.Equals("ProduitCommandes"))
                            {
                                DataGridViewButtonColumn colBtnProducts = new DataGridViewButtonColumn()
                                {
                                    Text = "Afficher",
                                    Name = "Produits",
                                    UseColumnTextForButtonValue = true,
                                };
                                dataGrid.Columns.Add(colBtnProducts);

                            } else if (value.Equals("Livraison"))
                            {
                                DataGridViewButtonColumn colBtnLivraison = new DataGridViewButtonColumn()
                                {
                                    Text = "Afficher",
                                    Name = "Livraison",
                                    UseColumnTextForButtonValue = true,
                                };
                                dataGrid.Columns.Add(colBtnLivraison);
                            }
                            break;
                        case "Livraison":
                            if (value.Equals("Salarie"))
                            {
                                DataGridViewButtonColumn colBtnSalarie = new DataGridViewButtonColumn()
                                {
                                    Text = "Afficher",
                                    Name = "Salarié",
                                    UseColumnTextForButtonValue = true,
                                };
                                dataGrid.Columns.Add(colBtnSalarie);
                            } else if (value.Equals("Adresse"))
                            {
                                DataGridViewButtonColumn colBtnAdresse = new DataGridViewButtonColumn()
                                {
                                    Text = "Afficher",
                                    Name = "Adresse",
                                    UseColumnTextForButtonValue = true,
                                };
                                dataGrid.Columns.Add(colBtnAdresse);
                            } else if (value.Equals("Commande"))
                            {
                                DataGridViewButtonColumn colBtnCommande = new DataGridViewButtonColumn()
                                {
                                    Text = "Afficher",
                                    Name = "Commande",
                                    UseColumnTextForButtonValue = true,
                                };
                                dataGrid.Columns.Add(colBtnCommande);
                            }
                            else if (value.Equals("Vehicule"))
                            {
                                DataGridViewButtonColumn colBtnVehicule = new DataGridViewButtonColumn()
                                {
                                    Text = "Afficher",
                                    Name = "Vehicule",
                                    UseColumnTextForButtonValue = true,
                                };
                                dataGrid.Columns.Add(colBtnVehicule);
                            }
                            break;
                        default:
                            Debug.WriteLine("Default");
                            break;
                    }
                }
            }

            return dataGrid;

        }


        public string GetObjectType(object personnalObject)
        {
            Type type = personnalObject.GetType();

            string[] arrayAccess = type.ToString().Split('.');
            string lastValue = arrayAccess[arrayAccess.Length - 1];
            lastValue = lastValue.Substring(0, lastValue.Length - 3);

            return lastValue;
        }

        public PropertyInfo[] GetPropertiesTypes(object personnalObject)
        {
            PropertyInfo[] propertiesInfo = personnalObject.GetType().GetProperties();
            return propertiesInfo;
        }


        public string[] GetPropertiesArray(object personnalObject)
        {
            List<string> propertiesString = new List<string>();
            PropertyInfo[] properties = personnalObject.GetType().GetProperties();
            foreach (var prop in properties)
            {
                string propString = prop.ToString().Split(' ')[1];
                propertiesString.Add(propString);
            }

            return propertiesString.ToArray();
        }
    }
}
