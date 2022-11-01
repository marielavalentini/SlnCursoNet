using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Vendedor:Persona
    {
        #region Constructores
        public Vendedor(string pNombre, string pApellido, string pDNI, string pEmail, string pDireccion, string pTelefono) : base(pNombre, pApellido, pEmail, pDireccion, pTelefono)
        {
            DNI = pDNI;
        }
        #endregion

        public string DNI { get; set; }
       
    }
}
