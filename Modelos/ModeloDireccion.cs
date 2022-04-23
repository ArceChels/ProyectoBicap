using System;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Modelo de la tabla Direccion                    |
//  Fecha: 28 de Marzo de 2022                          Hora: 15:05 hrs                                             |
//-------------------------------------------------------------------------------------------------------------------

namespace Proyecto_Residencia.Acceso.Modelos
{
    class ModeloDireccion
    {
        public int IdDireccion { get; set; }
        public int CodigoPostal { get; set; }
        public string Barrio { get; set; }
        public int IdLocaligag { get; set; }

    }
}
