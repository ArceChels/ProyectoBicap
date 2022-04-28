using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Residencia.Acceso.Conexion;
using Proyecto_Residencia.Acceso.Modelos;
using System.Data.SqlClient;
using System.Data;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Clase CRUD para tabla empleados
//  Fecha: 24 de abril de 2022                          Hora: 15:48 hrs                                             
//-------------------------------------------------------------------------------------------------------------------


namespace Proyecto_Residencia.Acceso.AccesoDatos
{
    public class Empleados
    {
        public string InsertarEmpleados(ModeloEmpleados modelo)
        {
            throw new NotImplementedException();
        }

        public string EliminarEmpleados(ModeloEmpleados modelo)
        {
            throw new NotImplementedException();
        }

        public string EditarEmpleados(ModeloEmpleados modelo)
        {
            throw new NotImplementedException();
        }

        private List<ModeloEmpleados> ObtenerUnaFila(SqlDataReader lector)
        {
            throw new NotImplementedException();
        }

        private List<ModeloEmpleados> LeerFilas(SqlDataReader lector)
        {
            throw new NotImplementedException();
        }

        public List<ModeloEmpleados> MostrarConsulta()
        {
            throw new NotImplementedException();
        }
    }
}