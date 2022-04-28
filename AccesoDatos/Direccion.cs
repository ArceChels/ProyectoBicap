using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Residencia.Acceso.Conexion;
using Proyecto_Residencia.Acceso.Modelos;
using System.Data.SqlClient;
using System.Data;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Clase CRUD para tabla dirección
//  Fecha: 23 de abril de 2022                              Hora: 20:24 hrs                                             
//-------------------------------------------------------------------------------------------------------------------


namespace Proyecto_Residencia.Acceso.AccesoDatos
{
    public class Direccion
    {
        public string InsertarDireccion(ModeloDireccion modelo)
        {
            throw new NotImplementedException();
        }

        public string EliminarDireccion(ModeloDireccion modelo)
        {
            throw new NotImplementedException();
        }

        public string EditarDireccion(ModeloDireccion modelo)
        {
            throw new NotImplementedException();
        }

        private List<ModeloDireccion> ObtenerUnaFila(SqlDataReader lector)
        {
            throw new NotImplementedException();
        }

        private List<ModeloDireccion> LeerFilas(SqlDataReader lector)
        {
            throw new NotImplementedException();
        }

        public List<ModeloDireccion> MostrarConsulta()
        {
            throw new NotImplementedException();
        }
    }
}

