using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Residencia.Acceso.Conexion;
using Proyecto_Residencia.Acceso.Modelos;
using System.Data.SqlClient;
using System.Data;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Clase CRUD para tabla encuesta
//  Fecha: 24 de abril de 2022                          Hora: 15:53 hrs                                             
//-------------------------------------------------------------------------------------------------------------------


namespace Proyecto_Residencia.Acceso.AccesoDatos
{
    public class Encuesta
    {
        public string InsertarEncuesta(ModeloEncuesta modelo)
        {
            throw new NotImplementedException();
        }

        public string EliminarEncuesta(ModeloEncuesta modelo)
        {
            throw new NotImplementedException();
        }

        public string EditarEncuesta(ModeloEncuesta modelo)
        {
            throw new NotImplementedException();
        }

        private List<ModeloEncuesta> ObtenerUnaFila(SqlDataReader lector)
        {
            throw new NotImplementedException();
        }

        private List<ModeloEncuesta> LeerFilas(SqlDataReader lector)
        {
            throw new NotImplementedException();
        }

        public List<ModeloEncuesta> MostrarConsulta()
        {
            throw new NotImplementedException();
        }
    }
}