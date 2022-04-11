using System;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Modelo de la tabla Encuesta                    |
//  Fecha: 28 de Marzo de 2022                          Hora: 14:55 hrs                                             |
//-------------------------------------------------------------------------------------------------------------------

namespace Proyecto_Residencia.Acceso.Modelos
{
    class ModeloEncuesta
    {
        public int idEncuesta { get; set; }
        public Boolean Computadora { get; set; }
        public Boolean ServicioInternet { get; set; }
        public string Compania { get; set; }
        public string TipoServicioInternet { get; set; }
        public string CondicionIntenet { get; set; }
        public Boolean CursoBachilleratoAnterior { get; set; }
        public string Lugar { get; set; }
    }
}
