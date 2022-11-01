using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Remito:DocumentoComercial
    {
        #region Constructores

        public Remito(string pNumero, DateTime pFecha, string pCliente, string pDireccion, string pCondicionIva,
            string pCondicionVenta, string pDetalle, decimal pTotal, DateTime pFechaEntrega) : base(pNumero, pFecha, pCliente,
                pDireccion, pCondicionIva, pCondicionVenta, pDetalle, pTotal)
        {
            FechaEntrega = pFechaEntrega;
        }
        public Remito() { }
       
        #endregion
        public DateTime FechaEntrega { get; set; }
       
    }
}
