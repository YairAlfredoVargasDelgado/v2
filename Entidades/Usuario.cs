using System;

namespace Entidades
{
    public enum DatosUsuario
    {
        FOTOGRAFÍA = 9, NOMBRE_DE_USUARIO, CONTRASEÑA, ROL
    }

    public enum Rol
    {
        ADMINISTRADOR, SECRETARIO, EMPLEADO
    }

    public class Usuario : Persona
    {
        public string Fotografía { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Contraseña { get; set; }
        public byte Rol { get; set; }

        public Usuario(string nombre, string númeroDeCédula, byte género, short edad, string teléfono,
            string dirección, string correoElectrónico, DateTime fechaDeRegistro, string fotografía,
            string nombreDeUsuario, string contraseña, byte rol
            ) : base(nombre, númeroDeCédula, género, edad, teléfono, dirección, correoElectrónico, fechaDeRegistro)
        {
            Fotografía = fotografía;
            NombreDeUsuario = nombreDeUsuario;
            Contraseña = contraseña;
            Rol = rol;
        }
    }
}
