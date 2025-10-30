using AppPruebaGit.Logica;
using AppPruebaGit.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppPruebaGit.Vista
{
    public partial class Usuarios : System.Web.UI.Page
    {
        ClUsuarioL logica = new ClUsuarioL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarUsuarios();
            }
        }
        public void CargarUsuarios()
        {
            gvUsuarios.DataSource = logica.Listar();
            gvUsuarios.DataBind();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario()
            {
                documento = txtDocumento.Text,
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                email = txtEmail.Text
            };
            logica.Registrar(u);
            CargarUsuarios();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario()
            {
                documento = txtDocumento.Text,
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                email = txtEmail.Text
            };
            logica.Editar(u);
            CargarUsuarios();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            logica.Eliminar(int.Parse(txtDocumento.Text));
            CargarUsuarios();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            var usuario = logica.Buscar(int.Parse(txtDocumento.Text));
            if (usuario != null)
            {
                txtNombre.Text = usuario.nombre;
                txtApellido.Text = usuario.apellido;
                txtEmail.Text = usuario.email;
            }
        }
    }
}