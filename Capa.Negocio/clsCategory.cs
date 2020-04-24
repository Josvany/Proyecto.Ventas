using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capa.Datos;
using Capa.Datos.ORM;

namespace Capa.Datos.ORM
{
    public class clsCategory
    {
        public Guid categoryIntId { get; set; }
        public string categoryName { get; set; }
        public string categoryCode { get; set; }
        public bool categoryStatus { get; set; }

        public void saveData(clsCategory clsCategory)
        {
            Conexion.GDatos.Ejecutar("SP_IM_CATEGORY", clsCategory.categoryIntId, clsCategory.categoryName, clsCategory.categoryCode, clsCategory.categoryStatus);
        }
    }
}