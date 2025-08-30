using System;
using ConexionDatos;

namespace Dominio
{
    public class AutenticarUsuario
    {
        Autenticacion autenticacion = new Autenticacion();
        public bool IniciarSesion(string usuario, string contrasena)
        {
            return autenticacion.IniciarSesion(usuario, contrasena);
        }
    }
}