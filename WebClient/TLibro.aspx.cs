using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class TLibro : System.Web.UI.Page
    {
        private static ServiceReference1.WSClienteSoap servicio = new ServiceReference1.WSClienteSoapClient();

        private void Listar()
        {
            gvLibros.DataSource = servicio.ListarLibro().Tables[0];
            gvLibros.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodLibro.Text.Equals("") || txtTitulo.Text.Equals("") || txtEditorial.Text.Equals(""))
            {
                Response.Write("<script>alert('Todos los campos requeridos');</script>");
                return;
            }
            string[] respuesta = servicio.AgregarLibro(txtCodLibro.Text, txtTitulo.Text, txtEditorial.Text);
            Response.Write("<script>alert('" + respuesta[1] + "');</script>");
            Listar();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodLibro.Text.Equals(""))
            {
                Response.Write("<script>alert('Codigo de Libro Requerido.');</script>");
                return;
            }
            string[] respuesta = servicio.EliminarLibro(txtCodLibro.Text);
            Response.Write("<script>alert('" + respuesta[1] + "');</script>");
            Listar();
        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtCodLibro.Text.Equals("") || txtTitulo.Text.Equals("") || txtEditorial.Text.Equals(""))
            {
                Response.Write("<script>alert('Todos los campos requeridos');</script>");
                return;
            }
            string[] respuesta = servicio.ActualizarLibro(txtCodLibro.Text, txtTitulo.Text, txtEditorial.Text);
            Response.Write("<script>alert('" + respuesta[1] + "');</script>");
            Listar();
        }
        protected void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            gvLibros.DataSource = servicio.BuscarLibro(txtbuscarLibro.Text);
            gvLibros.DataBind();
        }
    }

}