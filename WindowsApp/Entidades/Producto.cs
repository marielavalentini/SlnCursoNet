using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double Iva { get; set; }
        public decimal PrecioBruto
        {
            get
            {
                decimal PrecioBruto = PrecioCosto + Convert.ToDecimal(Margen);
                return PrecioBruto;
            }
        }

        public decimal PrecioVenta
        {
            get
            {
                decimal PrecioVenta = PrecioBruto +Convert.ToDecimal (this.Iva);
                return PrecioVenta;
            }
        }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
    }
}
