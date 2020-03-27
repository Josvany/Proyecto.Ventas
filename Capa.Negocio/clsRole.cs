using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capa.Datos;
using Capa.Datos.ORM;

namespace Capa.Datos.ORM
{
    public class clsRole
    {
        //variables de objeto publicas y privadas
        private Guid rolIntIdValue;
        public Guid rolIntId
        {
            get { return rolIntIdValue; }
            set { rolIntIdValue = value; }
        }

        private string rolNameValue;
        public string rolName
        {
            get { return rolNameValue; }
            set { rolNameValue = value; }
        }

        // funciones Crud
        public void Insert(clsRole objRole)
        {
            Conexion.GDatos.Ejecutar("INSERT_ROLE", objRole.rolIntId, objRole.rolName);
        }


    }
}
