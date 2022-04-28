using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Residencia.Acceso.Conexion;
using Proyecto_Residencia.Acceso.Modelos;
using System.Data.SqlClient;
using System.Data;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Clase CRUD para tabla datos médicos
//  Fecha: 23 de abril de 2022                              Hora: 20:24 hrs                                             
//-------------------------------------------------------------------------------------------------------------------


namespace Proyecto_Residencia.Acceso.AccesoDatos
{
    public class DatosMedicos
    {
        public string InsertarDatosMedicos(ModeloDatosMedicos modelo)
        {
            throw new NotImplementedException();
        }

        public string EliminarDatosMedicos(ModeloDatosMedicos modelo)
        {
            throw new NotImplementedException();
        }

        public string EditarDatosMedicos(ModeloDatosMedicos modelo)
        {
            throw new NotImplementedException();
        }

        private List<ModeloDatosMedicos> ObtenerUnaFila(SqlDataReader lector)
        {
            throw new NotImplementedException();
        }

        private List<ModeloDatosMedicos> LeerFilas(SqlDataReader lector)
        {
            throw new NotImplementedException();
        }

        public List<ModeloDatosMedicos> MostrarConsulta()
        {
            throw new NotImplementedException();
        }
    }
}
