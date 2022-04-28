using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Residencia.Acceso.Conexion;
using Proyecto_Residencia.Acceso.Modelos;
using System.Data.SqlClient;
using System.Data;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Clase CRUD para tabla contacto
//  Fecha: 23 de abril de 2022                              Hora: 20:24 hrs                                             
//-------------------------------------------------------------------------------------------------------------------


namespace Proyecto_Residencia.Acceso.AccesoDatos
{
    public class Contacto
    {
        public string InsertarContacto(ModeloContacto modelo)
        {
            throw new NotImplementedException();
        }

        public string EliminarContacto(ModeloContacto modelo)
        {
            throw new NotImplementedException();
        }

        public string EditarContacto(ModeloContacto modelo)
        {
            throw new NotImplementedException();
        }

        private List<ModeloContacto> ObtenerUnaFila(SqlDataReader lector)
        {
            throw new NotImplementedException();
        }

        private List<ModeloContacto> LeerFilas (SqlDataReader lector)
        {
            throw new NotImplementedException();
        }

        public List<ModeloContacto> MostrarConsulta()
        {
            throw new NotImplementedException();
        }
    }
}
