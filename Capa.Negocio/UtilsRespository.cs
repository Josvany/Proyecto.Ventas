using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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

        public DataTable GetData(string procedureName, string valueSearch)
        {
            return Conexion.GDatos.TraerDataTable(procedureName,valueSearch);
        }

        public DataTable GetData(string procedureName, Guid valueSearch)
        {
            return Conexion.GDatos.TraerDataTable(procedureName, valueSearch);
        }
    }}
