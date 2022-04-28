using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Residencia.Acceso.Conexion;
using Proyecto_Residencia.Acceso.Modelos;
using System.Data.SqlClient;
using System.Data;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Clase CRUD para tabla documentos
//  Fecha: 24 de abril de 2022                          Hora: 15:42 hrs                                             
//-------------------------------------------------------------------------------------------------------------------


namespace Proyecto_Residencia.Acceso.AccesoDatos
{
    public class Documentos
    {
        public string InsertarDocumentos(ModeloDocumentos modelo)
        {
            throw new NotImplementedException();
        }

        public string EliminarDocumentos(ModeloDocumentos modelo)
        {
            throw new NotImplementedException();
        }

        public string EditarDocumentos(ModeloDocumentos modelo)
        {
            throw new NotImplementedException();
        }

        private List<ModeloDocumentos> ObtenerUnaFila(SqlDataReader lector)
        {
            throw new NotImplementedException();
        }

        private List<ModeloDocumentos> LeerFilas(SqlDataReader lector)
        {
            throw new NotImplementedException();
        }

        public List<ModeloDocumentos> MostrarConsulta()
        {
            throw new NotImplementedException();
        }
    }
}
