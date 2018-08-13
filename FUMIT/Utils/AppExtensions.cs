using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.Utils
{
    public static class AppExtensions
    {
        public static DataTable ToDataTable<T>(this IEnumerable<T> coleccion)
        {
            var dataTable = new DataTable();

            PropertyInfo[] propiedadesTipoT = typeof(T).GetProperties();
            foreach(PropertyInfo propiedad in propiedadesTipoT)
            {
                dataTable.Columns.Add(propiedad.Name, propiedad.PropertyType);
            }

            foreach(T elemento in coleccion)
            {
                var valores = new object[propiedadesTipoT.Length];
                for(int i=0; i< propiedadesTipoT.Length; i++)
                {
                    valores[i] = propiedadesTipoT[i].GetValue(elemento);
                }

                dataTable.Rows.Add(valores);
            }

            return dataTable;
        }
    }
}
