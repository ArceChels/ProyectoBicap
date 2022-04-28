using Proyecto_Residencia.Acceso.AccesoDatos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Residencia.Acceso.Modelos;

namespace Proyecto_Residencia.Acceso.AccesoDatos.Tests
{
    [TestClass()]
    public class UsuarioTests
    {

        [TestMethod()]
        public void InsertarTest()
        {
            Usuario Us = new Usuario();
            ModeloUsuario modelo = new ModeloUsuario()
            {
                Usuario = "Rafael",
                Contrasena = "rafita1",
                Email = "rafa@hotmail.com",
                RolUsuario = "Rafa"
            };
            Us.Insertar(modelo);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Usuario Us = new Usuario();
            ModeloUsuario modelo = new ModeloUsuario()
            {
               // IdUsuario = 2
            };
            Us.Eliminar(modelo);
            //Assert.Fail();
        }

        [TestMethod()]
        public void EditarTest()
        {
            Usuario Us = new Usuario();
            ModeloUsuario modelo = new ModeloUsuario()
            {
               // IdUsuario = 2,
                Usuario = "Isabel",
                Contrasena = "6789",
                Email = "isabel@hotmail.com",
                RolUsuario = "Usuario2"
            };
            Us.Editar(modelo);
            //Assert.Fail();
        }
               

        [TestMethod()]
        public void ConsultaPersonalizadaTest()
        {
            Usuario Us = new Usuario();
            ModeloUsuario modelo = new ModeloUsuario()
            {
              //  IdUsuario = 8
            };
            Us.ConsultaPersonalizada(modelo);          
        }
    }
}