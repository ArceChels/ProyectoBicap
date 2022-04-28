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
            string msj = "";
            string procedimiento = "SP_InsertarContacto";

            try
            {
                using (SqlConnection conexion = new SqlConnection(ConnectionString.CadenaConexion))
                {
                    if (conexion.State == ConnectionState.Closed)
                        conexion.Open();

                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = procedimiento;
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.Add("@IdContacto", SqlDbType.VarChar);
                        comando.Parameters["@IdContacto"].Value = modelo.IdContacto;
                        comando.Parameters.Add("@Telefono", SqlDbType.VarChar);
                        comando.Parameters["@Telefono"].Value = modelo.Telefono;
                        comando.Parameters.Add("@Email", SqlDbType.VarChar);
                        comando.Parameters["@Email"].Value = modelo.IdContacto;
                        comando.Parameters.Add("@Salida",SqlDbType.VarChar,1000).Direction = ParameterDirection.Output;

                        comando.ExecuteNonQuery();
                        msj += comando.Parameters["@Salida"].Value.ToString();
                        return msj;
                    }
                }
            } catch (Exception ex)
            {
                return msj += "Ocurrió el siguiente error "+ ex.Message;
            }
        }

        public string EliminarContacto(ModeloContacto modelo)
        {
            string msj = "";
            string procedimiento = "SP_EliminarContacto";

            try
            {
                using (SqlConnection conexion = new SqlConnection(ConnectionString.CadenaConexion))
                {
                    if (conexion.State == ConnectionState.Closed)
                        conexion.Open();

                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = procedimiento;
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.Add("@IdContacto", SqlDbType.VarChar);
                        comando.Parameters["@IdContacto"].Value = modelo.IdContacto;

                        comando.Parameters.Add("@Salida", SqlDbType.VarChar, 1000).Direction = ParameterDirection.Output;

                        comando.ExecuteNonQuery();
                        msj += comando.Parameters["@Salida"].Value.ToString();
                        return msj;
                    }
                }
            }
            catch (Exception ex)
            {
                return msj += "Ocurrió el siguiente error " + ex.Message;
            }
        }

        public string EditarContacto(ModeloContacto modelo)
        {
            string msj = "";
            string procedimiento = "SP_EditarContacto";

            try
            {
                using (SqlConnection conexion = new SqlConnection(ConnectionString.CadenaConexion))
                {
                    if (conexion.State == ConnectionState.Closed)
                        conexion.Open();

                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = procedimiento;
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.Add("@IdContacto", SqlDbType.VarChar);
                        comando.Parameters["@IdContacto"].Value = modelo.IdContacto;
                        comando.Parameters.Add("@IdTempo", SqlDbType.VarChar);
                        comando.Parameters["@IdTempo"].Value = modelo.IdTemporal;
                        comando.Parameters.Add("@Telefono", SqlDbType.VarChar);
                        comando.Parameters["@Telefono"].Value = modelo.Telefono;
                        comando.Parameters.Add("@Email", SqlDbType.VarChar);
                        comando.Parameters["@Email"].Value = modelo.IdContacto;
                        comando.Parameters.Add("@Salida", SqlDbType.VarChar, 1000).Direction = ParameterDirection.Output;

                        comando.ExecuteNonQuery();
                        msj += comando.Parameters["@Salida"].Value.ToString();
                        return msj;
                    }
                }
            }
            catch (Exception ex)
            {
                return msj += "Ocurrió el siguiente error " + ex.Message;
            }
        }

        private ModeloBusquedaContacto ObtenerUnaFila(SqlDataReader lector)
        {
            ModeloBusquedaContacto modelo = new ModeloBusquedaContacto();
            if (!Convert.IsDBNull(lector["IdContacto"])) { modelo.IdContacto = lector["IdContacto"].ToString(); }
            else { modelo.IdContacto = "S/D"; }
            if (!Convert.IsDBNull(lector["Telefono"])) { modelo.Telefono = lector["Telefono"].ToString(); }
            else { modelo.Telefono = "Sin teléfono"; }
            if (!Convert.IsDBNull(lector["Email"])) { modelo.Email = lector["Email"].ToString(); }
            else { modelo.Email = "Sin correo"; }

            return modelo;
        }

        private List<ModeloBusquedaContacto> LeerFilas (SqlDataReader lector)
        {
            List<ModeloBusquedaContacto> lista = new List<ModeloBusquedaContacto>();
            if (lector != null)
            {
                while (lector.Read())
                {
                    lista.Add(ObtenerUnaFila(lector));
                }
            }
            return lista;
        }

        public List<ModeloBusquedaContacto> MostrarConsulta()
        {
            string procedimiento = "SP_BuscarContacto";
            List<ModeloBusquedaContacto> lista = new List<ModeloBusquedaContacto>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(ConnectionString.CadenaConexion))
                {
                    if (conexion.State == ConnectionState.Closed)
                        conexion.Open();

                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = procedimiento;
                        comando.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            lista = LeerFilas(lector);
                        }

                        return lista;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
