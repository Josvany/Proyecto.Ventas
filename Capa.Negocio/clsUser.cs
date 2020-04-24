using System;
using System.Data;

namespace Capa.Datos.ORM
{
    public class clsUser
    {
        //variables de objeto publicas y privadas
        public Guid userIntIdValue { get; set; }

        public string userNameValue { get; set; }

        public string userLoginValue { get; set; }

        public string userPasswordValue { get; set; }

        public Guid rolIntIdValue { get; set; }

        public bool userStatusValue { get; set; }

        // funciones Crud
        public void Insert(clsUser objUser)
        {

            Conexion.GDatos.Ejecutar("SP_IM_USER", objUser.userIntIdValue, objUser.userNameValue,
                                                   objUser.userLoginValue,
                                                   objUser.userPasswordValue, objUser.rolIntIdValue,
                                                   objUser.userStatusValue);
        }


        public DataTable GetData()
        {
            return Conexion.GDatos.TraerDataTable("SP_GET_USER");
        }
    }
}