using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public abstract class DocumentoComercial
    {
        #region Constructores
        public DocumentoComercial( string pNumero, DateTime pFecha, string pCliente, string pDireccion, string pCondicionIva,
            string pCondicionVenta, string pDetalle, decimal pTotal)
        {
            Numero = pNumero;
            Fecha = pFecha;
            Cliente = pCliente;
            Direccion = pDireccion;
            CondicionIVA = pCondicionIva;
            CondicionVenta = pCondicionVenta;
            Detalle = pDetalle;
            Total = pTotal;
        }
        public DocumentoComercial() { }
        
        #endregion

        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        public decimal Total { get; set; }
    }
}
