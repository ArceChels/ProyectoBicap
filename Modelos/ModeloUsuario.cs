//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Modelo de la tabla usuario                     |
//  Fecha: 28 de Marzo de 2022                          Hora: 14:15 hrs                                             |
//-------------------------------------------------------------------------------------------------------------------

namespace Proyecto_Residencia.Acceso.Modelos
{
    public class ModeloUsuario
    {
        public string IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Email { get; set; }
        public string RolUsuario { get; set; }
        public string Estatus { get; set; }
        public string Acceso { get; set; }
    }
}
