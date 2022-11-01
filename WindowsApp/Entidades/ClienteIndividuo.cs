using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{ 
    public class ClienteIndividuo: Persona
    {
        #region Constructores
        public ClienteIndividuo(string pNombre, string pApellido, string pCUIT, string pEmail, string pDireccion, string pTelefono):base(pNombre,pApellido,pEmail,pDireccion,pTelefono)
        {
            Cuit = pCUIT;
        }
        #endregion
       
        public string Cuit { get; set; } 
    }
}
