using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Capa.Datos;

namespace Capa.Datos.ORM
{
    public class clsAgencyBox
    {
        public Guid boxIntId { get; set; }
        public string boxName { get; set; }
        public bool boxStatus { get; set; }

        public void saveData(clsAgencyBox clsAgencyBox)
        {
            Conexion.GDatos.Ejecutar("SP_IM_AGENCY_BOX", clsAgencyBox.boxIntId, clsAgencyBox.boxName,
                                                         clsAgencyBox.boxStatus);
        }
        public void saveData(Guid newHisAgencyBox, Guid agencyBox, Guid userIntId, decimal amountInitial)
        {
            try
            {
                DataTable dtData = Conexion.GDatos.TraerDataTable("SP_GET_HIS_AGENCY_BOX_BY_BOX_ID", agencyBox);

                if (dtData.Rows.Count > 0)
                {
                    throw new Exception("La caja ya ha sido asignada");
                }

                dtData = Conexion.GDatos.TraerDataTable("SP_GET_HIS_AGENCY_BOX_BY_USER_ID", userIntId);

                if (dtData.Rows.Count > 0)
                {
                    throw new Exception("El usuario ya tiene una caja asignada");
                }

                Conexion.GDatos.Ejecutar("SP_I_HIS_AGENCY_BOX", newHisAgencyBox, userIntId, agencyBox, amountInitial);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}