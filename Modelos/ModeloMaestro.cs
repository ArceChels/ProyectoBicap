using System;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Modelo de la tabla maestro                  |
//  Fecha: 22 de Abril de 2022                              Hora: 17:31 hrs                                             |
//-------------------------------------------------------------------------------------------------------------------

namespace Proyecto_Residencia.Acceso.Modelos
{
    public class ModeloMaestro
    {
        public string MatriculaProfesor { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNamicimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int AnioDeIngreso { get; set; }
        public bool MaestroActivo { get; set; }
        public byte[] Fotografia { get; set; }
    }
}