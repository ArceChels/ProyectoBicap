using System;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Modelo de la tabla Materia                     |
//  Fecha: 28 de Marzo de 2022                          Hora: 14:15 hrs                                             |
//-------------------------------------------------------------------------------------------------------------------

namespace Proyecto_Residencia.Acceso.Modelos
{
    public class ModeloMateria
    {
        public int idMateria { get; set; }
        public string NombreMateria { get; set; }
        public string Grupo { get; set; }
        public string Grado { get; set; }
        public double CalificacionBimestral { get; set; }   
        public int IdBimestre { get; set; } 
        public double CalificacionFinal { get; set; }
        public bool Aprobado { get; set; }
        public int IdRecuperacion { get; set; }
        public string IdTipoMateria { get; set; }
        public string MatriculaMaestro { get; set; }
    }
}