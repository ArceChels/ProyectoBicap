using System;

namespace Proyecto_Residencia.Acceso.Conexion
{
    public class ConnectionString
    {
        public static string CadenaConexion
        {
            get
            {
                return @"DATA SOURCE=DESKTOP-H48ENMF; PERSIST SECURITY INFO=TRUE; INITIAL CATALOG=BICAP; USER ID=Arcelia;
                        PASSWORD=arcelia";
            }
        }
    }
}
