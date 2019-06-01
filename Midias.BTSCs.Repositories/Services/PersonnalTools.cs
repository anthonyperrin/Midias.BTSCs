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


        public DataGridView GenerateGridHeaders(DataGridView dataGrid , object personnalObject, string[] excludedValues)
        {

            string objectType = GetObjectType(personnalObject);
            Debug.WriteLine(objectType);
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
