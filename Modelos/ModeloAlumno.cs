using System;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Modelo de la tabla Alumnos                  |
//  Fecha: 28 de Marzo de 2022                          Hora: 14:31 hrs                                             |
//-------------------------------------------------------------------------------------------------------------------

namespace Proyecto_Residencia.Acceso.Modelos
{
    class ModeloAlumno
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Sexo { get; set; }
        public string Curp { get; set; }
        public string LugarNacimiento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string GrupoEtnico { get; set; }
        public string Periodo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Boolean RolAlumno { get; set; }
        public string TipoBeca { get; set; }
        public byte[] FotoPerfil { get; set; }


    }
}
