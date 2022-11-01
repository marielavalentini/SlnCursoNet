using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Factura:DocumentoComercial
    {
        #region Constructores

        public Factura (string pNumero, DateTime pFecha, string pCliente, string pDireccion, string pCondicionIva,
            string pCondicionVenta, string pDetalle, decimal pTotal, string pTipo): base(pNumero, pFecha, pCliente,
                pDireccion, pCondicionIva, pCondicionVenta, pDetalle, pTotal)
        {
            Tipo = pTipo;
        }

        public Factura() { }
        
        #endregion
        public string Tipo { get; set; }
    }
}
