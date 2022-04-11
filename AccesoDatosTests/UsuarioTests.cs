using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Residencia.Acceso.AccesoDatos;
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
        public void InsertarUsuariosTest()
        {
            Usuario user = new Usuario();
            ModeloUsuario modelo = new ModeloUsuario()
            {
                Usuarios = "Arceliaxd",
                Contrasena = "Arceliaxd12!",
                Email = "aarilec@hotmail.com",
                RolUsuario = "Coordinador"
            };
            user.Insertar(modelo);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Usuario user = new Usuario();
            ModeloUsuario modelo = new ModeloUsuario()
            {
                IdUsuario = 1
            };
            user.Eliminar(modelo);
        }
    }
}