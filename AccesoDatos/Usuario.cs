using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Residencia.Acceso.Conexion;
using Proyecto_Residencia.Acceso.Modelos;
using System.Data.SqlClient;
using System.Data;

//-------------------------------------------------------------------------------------------------------------------
//  Autor: Arcelia Isabel Perez Vasquez                 Descripción: Clase CRUD para tabla Usuarios
//  Fecha: 28 de Marzo de 2022                          Hora: 22:12 hrs                                             
//-------------------------------------------------------------------------------------------------------------------

namespace Proyecto_Residencia.Acceso.AccesoDatos
{
    public class Usuario
    {
        //-------------------------- Insertar Usuarios ----------------------------------------------------------
        public string Insertar (ModeloUsuario modelo)
        {
            string respuesta = "";
            string procedimiento = "Insertar_Usuario";

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

                        comando.Parameters.Add("@Usuario", SqlDbType.VarChar);
                        comando.Parameters["@Usuario"].Value = modelo.Usuario;
                        comando.Parameters.Add("@Contrasena", SqlDbType.VarChar);
                        comando.Parameters["@Contrasena"].Value = modelo.Contrasena;
                        comando.Parameters.Add("@Email", SqlDbType.VarChar);
                        comando.Parameters["@Email"].Value = modelo.Email;
                        comando.Parameters.Add("@RolUsuario", SqlDbType.VarChar);
                        comando.Parameters["@RolUsuario"].Value = modelo.RolUsuario;
                        comando.Parameters.Add("@Estatus", SqlDbType.Bit);
                        comando.Parameters["@Estatus"].Value = modelo.Estatus;

                        int response = comando.ExecuteNonQuery();
                        if (response > 0)
                            respuesta += "¡El usuario se ha guardado satisfactoriamente!";
                        else
                            respuesta += "Ocurrió un error, intente nuevamente";

                        return respuesta;
                    }
                }
            }
            catch(Exception ex)
            {
                respuesta += ex.Message;
                return respuesta;
            }
        }

        //-------------------------------- Eliminación de usuarios -----------------------------------------------
        public string Eliminar (ModeloUsuario modelo)
        {
            string respuesta = "";
            string procedimiento = "Eliminar_Usuario";

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

                        comando.Parameters.Add("@IdUsuario", SqlDbType.Int);
                        comando.Parameters["@IdUsuario"].Value = modelo.IdUsuario;

                        int response = comando.ExecuteNonQuery();
                        if (response > 0)
                            respuesta += "¡El usuario se ha eliminado satisfactoriamente!";
                        else
                            respuesta += "Ocurrió un error al eliminar, intente nuevamente";

                        return respuesta;
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta += ex.Message;
                return respuesta;
            }
        }

        //-------------------------------- Actulizar Usuarios ---------------------------------------------------

        public string Editar(ModeloUsuario modelo)
        {
            string respuesta = "";
            string procedimiento = "Actualizar_Usuario";

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

                        comando.Parameters.Add("@IdUsuario", SqlDbType.Int);
                        comando.Parameters["@IdUsuario"].Value = modelo.IdUsuario;
                        comando.Parameters.Add("@Usuario", SqlDbType.VarChar);
                        comando.Parameters["@Usuario"].Value = modelo.Usuario;
                        comando.Parameters.Add("@Contrasena", SqlDbType.VarChar);
                        comando.Parameters["@Contrasena"].Value = modelo.Contrasena;
                        comando.Parameters.Add("@Email", SqlDbType.VarChar);
                        comando.Parameters["@Email"].Value = modelo.Email;
                        comando.Parameters.Add("@RolUsuario", SqlDbType.VarChar);
                        comando.Parameters["@RolUsuario"].Value = modelo.RolUsuario;
                        comando.Parameters.Add("@Estatus", SqlDbType.Bit);
                        comando.Parameters["@Estatus"].Value = modelo.Estatus;
                        int response = comando.ExecuteNonQuery();
                        if (response > 0)
                            respuesta += "¡El usuario se ha Actualizado satisfactoriamente!";
                        else
                            respuesta += "Ocurrió un error al eliminar, intente nuevamente";

                        return respuesta;
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta += ex.Message;
                return respuesta;
            }

        }


        //-------------------------------- Leer Usuarios --------------------------------------------------------
        // Busquedas personalizadas
        //Se inicia con un metodo que permitirá hacer lectura fila por fila
        //será un metodo encapsulado para evitar ser leido por otras clases

        //BUSQUEDA PERSONALIZADA

        private ModeloUsuario ObtenerUnaFila(SqlDataReader lector) 
        {
            ModeloUsuario usuario = new ModeloUsuario();
            if (!Convert.IsDBNull(lector["Usuario"])) { usuario.Usuario = lector["Usuario"].ToString(); }
            else { usuario.Usuario = "Null"; }

            if (!Convert.IsDBNull(lector["Email"])) { usuario.Email = lector["Email"].ToString(); }
            else { usuario.Email = "Null"; }

            if (!Convert.IsDBNull(lector["RolUsuario"])) { usuario.RolUsuario = lector["RolUsuario"].ToString(); }
            else { usuario.RolUsuario = "Null"; }

            if (!Convert.IsDBNull(lector["Estatus"])) { usuario.RolUsuario = lector["Estatus"].ToString(); }
            else { usuario.RolUsuario = "Null"; }
            return usuario;
        }

        private List<ModeloUsuario>LeerFilas(SqlDataReader lector)
        {
            List<ModeloUsuario> lista = new List<ModeloUsuario>();
            if(lector != null)
            {
                while (lector.Read())
                {
                    lista.Add(ObtenerUnaFila(lector));
                }
            }
            return lista;
        }


        public List<ModeloUsuario> ConsultaPersonalizada(ModeloUsuario modelo)
        {
            string respuesta = "";
            string procedimiento = "Leer_Usuario";
            List<ModeloUsuario> lista = new List<ModeloUsuario>();

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

                        comando.Parameters.Add("@IdUsuario", SqlDbType.Int);
                        comando.Parameters["@IdUsuario"].Value = modelo.IdUsuario;

                        using(SqlDataReader lector= comando.ExecuteReader())
                        {
                            lista = LeerFilas(lector);
                        }
                        
                        return lista;
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta += "Ha ocurrido un error en la lectura de datos del usuario, Error: " + ex.Message;
                throw new Exception(respuesta);
            }
        }

    }
}
