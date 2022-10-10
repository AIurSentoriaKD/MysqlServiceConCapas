using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormClient
{
    public partial class Form1 : Form
    {
        private static ServiceReference1.WSClienteSoap servicio = new ServiceReference1.WSClienteSoapClient();

        private void Listar()
        {
            DataTable result = servicio.ListarPrestamo().Tables[0];
            gridPrestamo.DataSource = result;
        }
        public Form1()
        {
            InitializeComponent();
            Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] result = servicio.AgregarPrestamo(txtCodAutor.Text, txtCodLibro.Text, txtFechaPrestamo.Text);
            Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string[] result = servicio.EliminarPrestamo(txtCodAutor.Text, txtCodLibro.Text, txtFechaPrestamo.Text);
            Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable result = servicio.BuscarPrestamo(txtBusqueda.Text).Tables[0];
            gridPrestamo.DataSource = result;
        }
    }
}
