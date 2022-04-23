using System;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Modelo de la tabla Padre de falia o tutor                    |
//  Fecha: 28 de Marzo de 2022                          Hora: 15:07 hrs                                             |
//-------------------------------------------------------------------------------------------------------------------

namespace Proyecto_Residencia.Acceso.Modelos
{
    public class ModeloPadreFamiliaTutor
    {
        public int IdPadreFamilia { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Familiaridad { get; set; }
    }
}
