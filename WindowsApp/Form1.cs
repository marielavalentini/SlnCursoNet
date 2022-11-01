using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Entidades;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearObjetos_Click(object sender, EventArgs e)
        {
            Empresa clienteEmpresa = new Empresa();

            clienteEmpresa.Nombre = "Las flores SRL";
            clienteEmpresa.CUIT = "123456";
            clienteEmpresa.Contacto = "Juan Perez";
            clienteEmpresa.Email = "lasflores@gmail.com";
            clienteEmpresa.Direccion = " Indepensencia 342";

            MessageBox.Show("Empresa: " + clienteEmpresa.Nombre + "\nEmail: " + clienteEmpresa.Email);

        }
    }
}
