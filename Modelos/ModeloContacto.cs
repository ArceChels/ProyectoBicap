using System;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Modelo de la tabla Contacto                  |
//  Fecha: 28 de Marzo de 2022                          Hora: 14:44 hrs                                             |
//-------------------------------------------------------------------------------------------------------------------

namespace Proyecto_Residencia.Acceso.Modelos
{
    public class ModeloContacto
    {
        public string IdContacto { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string IdTemporal { get; set; } 
    }

    public class ModeloBusquedaContacto
    {
        public string IdContacto { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
