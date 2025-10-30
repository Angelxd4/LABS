using AppPruebaGit.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace AppPruebaGit.Datos
{
    public class ClUsuarioD
    {
        Usuario user = new Usuario();
        ClConexion oConexion = new ClConexion();
        public List<Usuario> listar()
        {
            List<Usuario> lista = new List<Usuario>();
            SqlConnection conexion = oConexion.MtAbrir();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario", conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Usuario()
                {
                    idUsuario = dr.GetInt32(0),
                    documento = dr.GetString(1),
                    nombre = dr.GetString(2),
                    apellido = dr.GetString(3),
                    email = dr.GetString(4)
                });
            }
            dr.Close();
            conexion.Close();
            return lista;

        }
        public bool Registrar(Usuario usuario)
        {
            SqlConnection conexion = oConexion.MtAbrir();
            string consulta = "INSERT INTO Usuario VALUES (@Documento,@Nombre,@Apellido,@Email)";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@Documento", usuario.documento);
            cmd.Parameters.AddWithValue("@Nombre", usuario.nombre);
            cmd.Parameters.AddWithValue("@Apellido", usuario.apellido);
            cmd.Parameters.AddWithValue("@Email", usuario.email);
            conexion.Close();
            return cmd.ExecuteNonQuery() > 0;

        }
        public bool Editar(Usuario usuario)
        {
            SqlConnection conexion = oConexion.MtAbrir();
            string consulta = "UPDATE Usuario SET Nombre=@Nombre, Apellido=@Apellido, Email=@Email WHERE Documento=@Documento";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@Documento", usuario.documento);
            cmd.Parameters.AddWithValue("@Nombre", usuario.nombre);
            cmd.Parameters.AddWithValue("@Apellido", usuario.apellido);
            cmd.Parameters.AddWithValue("@Email", usuario.email);
            conexion.Close();
            return cmd.ExecuteNonQuery() > 0;

        }
        public bool Eliminar(int documento)
        {
            SqlConnection conexion = oConexion.MtAbrir();
            string consulta = "DELETE FROM Usuario WHERE Documento=@Documento";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@Documento", documento);
            conexion.Close();
            return cmd.ExecuteNonQuery() > 0;
        }
        public Usuario Buscar(int documento)
        {
            Usuario usuario = null;
            SqlConnection conexion = oConexion.MtAbrir();
            string consulta = "SELECT * FROM Usuario WHERE Documento=@Documento";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@Documento", documento);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new Usuario()
                {
                    idUsuario = dr.GetInt32(0),
                    documento = dr.GetString(1),
                    nombre = dr.GetString(2),
                    apellido = dr.GetString(3),
                    email = dr.GetString(4)
                };
            }
            dr.Close();
            conexion.Close();
            return usuario;

        }


    }
    

}