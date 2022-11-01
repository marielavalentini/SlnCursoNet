using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp
{
    public abstract class Persona
    {
        #region Constructores
        public Persona(string pNombre, string pApellido, string pEmail, string pDireccion, string pTelefono)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Email = pEmail;
            Direccion = pDireccion;
            Telefono = pTelefono;
        }
        #endregion
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
