using System;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Modelo de la tabla Direccion                    |
//  Fecha: 28 de Marzo de 2022                          Hora: 15:05 hrs                                             |
//-------------------------------------------------------------------------------------------------------------------

namespace Proyecto_Residencia.Acceso.Modelos
{
    public class ModeloDireccion
    {
        public int IdDireccion { get; set; }
        public string Calle { get; set; }
        public int NumeroInt { get; set; }
        public int NumeroExt { get; set; }
        public string Colonia { get; set; }
        public int CP { get; set; }
        public string Referecias { get; set; }  

    }
}
