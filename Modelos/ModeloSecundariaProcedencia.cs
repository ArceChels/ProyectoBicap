﻿using System;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Modelo de la tabla secundaria procedencia                  |
//  Fecha: 28 de Marzo de 2022                          Hora: 15:15 hrs                                             |
//-------------------------------------------------------------------------------------------------------------------

namespace Proyecto_Residencia.Acceso.Modelos
{
    public class ModeloSecundariaProcedencia
    {
        public int Clave { get; set; }
        public string NombreSecundaria { get; set; }
        public double Promedio { get; set; }
        public DateTime AnioTerminacion { get; set; }
        public int IdTipoSecundaria { get; set; }
        public int IdDireccion { get; set; }
    }
}
