//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Modelo de la tabla usuario                     |
//  Fecha: 22 de Abril de 2022                              Hora: 17:06 hrs                                             |
//-------------------------------------------------------------------------------------------------------------------

namespace Proyecto_Residencia.Acceso.Modelos
{
    public class ModeloEmpleados

    {
        public string IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string AreaDeTrabajo { get; set; }
        public byte[] Fotografia { get; set; }
        public string IdUsuario { get; set; }
    }
}