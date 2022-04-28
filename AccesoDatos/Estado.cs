using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Residencia.Acceso.Conexion;
using Proyecto_Residencia.Acceso.Modelos;
using System.Data.SqlClient;
using System.Data;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Clase CRUD para tabla Estado
//  Fecha: 24 de abril de 2022                          Hora: 16:00 hrs                                             
//-------------------------------------------------------------------------------------------------------------------


namespace Proyecto_Residencia.Acceso.AccesoDatos
{
    public class Estado
    {
        public string InsertarEstado(ModeloEstado modelo)
        {
            throw new NotImplementedException();
        }

        public string EliminarEstado(ModeloEstado modelo)
        {
            throw new NotImplementedException();
        }

        public string EditarEstado(ModeloEstado modelo)
        {
            throw new NotImplementedException();
        }

        private List<ModeloEstado> ObtenerUnaFila(SqlDataReader lector)
        {
            throw new NotImplementedException();
        }

        private List<ModeloEstado> LeerFilas(SqlDataReader lector)
        {
            throw new NotImplementedException();
        }

        public List<ModeloEstado> MostrarConsulta()
        {
            throw new NotImplementedException();
        }
    }
}