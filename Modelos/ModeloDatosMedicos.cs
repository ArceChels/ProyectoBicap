using System;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Modelo de la tabla datos medicos               |
//  Fecha: 28 de Marzo de 2022                          Hora: 14:15 hrs                                             |
//-------------------------------------------------------------------------------------------------------------------

namespace Proyecto_Residencia.Acceso.Modelos
{
    public class ModeloDatosMedicos
    {
        public int idDatosMedicos { get; set; }
        public string Discapacidad { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string TipoSanguineo { get; set; }
    }
}