namespace Capa.Datos
{
    public class Conexion
    {

        public static GDatos GDatos;
        public static bool IniciarSesion(string nombreServidor, string baseDatos, string usuario, string password)
        {
            GDatos = new SqlServer(nombreServidor, baseDatos, usuario, password);
            return GDatos.Autenticar(usuario, password);
        }

        public static bool IniciarSesion()
        {
            string cadenaConex = @"Integrated Security=True;Persist Security Info=False; Initial Catalog = DB_FARMACY; Data Source = (local);";
            GDatos = new SqlServer(cadenaConex);
            return GDatos.Autenticar();
        }

        public static void FinalizarSesion()
        {
            GDatos.CerrarConexion();
        } //fin FinalizaSesion
    }
}