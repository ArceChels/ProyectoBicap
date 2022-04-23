using System;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Modelo de la tabla Encuesta                    |
//  Fecha: 28 de Marzo de 2022                          Hora: 14:55 hrs                                             |
//-------------------------------------------------------------------------------------------------------------------

namespace Proyecto_Residencia.Acceso.Modelos
{
    public class ModeloEncuesta
    {
        public string IdEncuesta { get; set; }
        public bool Computadora { get; set; }
        public bool Celular { get; set; }
        public bool ServicioInternet { get; set; }
        public string Compania { get; set; }
        public string TipoServicioInternet { get; set; }
        public string CondicionIntenet { get; set; }
        public bool CursoBachilleratoAnterior { get; set; }
        public string Lugar { get; set; }
    }
}
