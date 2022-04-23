using System;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Modelo de la tabla Localidad                    |
//  Fecha: 28 de Marzo de 2022                          Hora: 15:01 hrs                                             |
//-------------------------------------------------------------------------------------------------------------------

namespace Proyecto_Residencia.Acceso.Modelos
{
   public  class ModeloLocalidad
    {
        public int IdLocalidad { get; set; }
        public string NombreLocalidad { get; set; }
        public int NumeroMunicipio { get; set; }
    }
}
