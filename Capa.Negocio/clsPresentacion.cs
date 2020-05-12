using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Capa.Datos;

namespace Capa.Datos.ORM
{
    public class clsPresentacion
    {
        public Guid preId { get; set; }
        public string preName { get; set; }


        public void saveData(clsPresentacion clsPresentacion)
        {
            try
            {
                Conexion.GDatos.Ejecutar("SP_IM_TYPE_PRESENTATION", clsPresentacion.preId, clsPresentacion.preName);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
