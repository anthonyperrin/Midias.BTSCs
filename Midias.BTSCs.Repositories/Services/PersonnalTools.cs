using Midias.BTSCs.Dto;
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
                            if (mouvements.Length > 0)
                            {
                                //DataGridViewButtonCell showMouvements = new DataGridViewButtonCell();
                                //showMouvements. = "Afficher";
                                //row.Cells[6]. = showMouvements;
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
            for (int i = 0; i < objectSize; i++)
            {
                string value = properties[i];
                if (!excludedValues.Contains(properties[i]))
                {
                    dataGrid.Columns[i].HeaderText = value;
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
