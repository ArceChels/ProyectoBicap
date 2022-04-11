using System;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Modelo de la tabla documentos                  |
//  Fecha: 28 de Marzo de 2022                          Hora: 14:22 hrs                                             |
//-------------------------------------------------------------------------------------------------------------------

namespace Proyecto_Residencia.Acceso.Modelos
{
    public class ModeloDocumentos
    {
        public int idDocumentacion { get; set; }
        public Boolean Acta { get; set; }
        public Boolean CopiaActa { get; set; }
        public Boolean Curp { get; set; }
        public Boolean CopiaCurp { get; set; }
        public Boolean Certificado { get; set; }
        public Boolean CopiaCertificado { get; set; }
        public Boolean CartaConducta { get; set; }
        public Boolean CopiaCartaConducta { get; set; }
        public Boolean CertificadoMedico { get; set; }
        public Boolean CopiaCertificadoMedico { get; set; }
        public Boolean ConstanciaEstudios { get; set; }
        public Boolean CopiaConstanciaEstuios { get; set; }
        public Boolean Fotografia { get; set; }
    }
}