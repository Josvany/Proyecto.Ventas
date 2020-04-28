using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Capa.Datos;
using Capa.Datos.ORM;

namespace Capa.Datos.ORM
{
    [Serializable]
    [ComVisible(false)]
    public class UtilsRespository
    {
        public DataTable GetData(string procedureName)
        {
            return Conexion.GDatos.TraerDataTable(procedureName);
        }

        public object GetData(string procedureName, string columnameFilterValue, string columReturnValue, object valueToFilter)
        {
            DataTable dtGetData = new DataTable();
            object valueReturn = new object();
            dtGetData = Conexion.GDatos.TraerDataTable(procedureName);

            if (dtGetData != null && dtGetData.Rows.Count > 0)
            {
                if (dtGetData.Columns.Contains(columnameFilterValue))
                {
                    valueReturn = dtGetData.AsEnumerable().Where(x => object.Equals(x[columnameFilterValue], valueToFilter.ToString())).Select(x => x[columReturnValue]).SingleOrDefault();
                }
            }

            return valueReturn;
        }

        public Dictionary<string, Guid> GetCombo(string procedureName)
        {
            Dictionary<string, Guid> valueReturn = new Dictionary<string, Guid>
            {
                { "Seleccione", Guid.Empty }
            };

            DataTable dtData = GetData(procedureName);

            foreach (DataRow item in dtData.Rows)
            {
                valueReturn.Add(item[1].ToString(), Guid.Parse(item[0].ToString()));
            }

            return valueReturn;
        }

        public void blockLeter(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
