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


        //public DataGridView GenerateGrid(DataGridView dataGrid, List<object> listObjects)
        //{
        //    if (listObjects.Count > 0)
        //    {

        //        dataGrid = GenerateGridHeaders(dataGrid, listObjects[0]);

        //        int i = 0;
        //        foreach (object obj in listObjects)
        //        {
        //            dataGrid.Column
        //        }

        //    }
        //    return dataGrid;
        //}


        public DataGridView GenerateGridHeaders(DataGridView dataGrid , object personnalObject)
        {

            string objectType = GetObjectType(personnalObject);
            string[] properties = GetArrayProperties(personnalObject);
            PropertyInfo[] propertiesInfos = GetPropertiesTypes(personnalObject);
            int objectSize = properties.Length;
            dataGrid.ColumnCount = objectSize;
            for (int i = 0; i < objectSize - 1; i++)
            {
                string value = properties[i];

                dataGrid.Columns[i].HeaderText = value;
            }

            return dataGrid;

        }


        









        public string GetObjectType(object personnalObject)
        {
            Type type = personnalObject.GetType();

            string[] arrayAccess = type.ToString().Split('.');
            string lastValue = arrayAccess[arrayAccess.Length - 1];

            return lastValue;
        }

        public PropertyInfo[] GetPropertiesTypes(object personnalObject)
        {
            PropertyInfo[] propertiesInfo = personnalObject.GetType().GetProperties();
            return propertiesInfo;
        }


        public string[] GetArrayProperties(object personnalObject)
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
