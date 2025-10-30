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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario");
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Usuario()
                {
                    documento = dr.GetString(0),
                    nombre = dr.GetString(1),
                    apellido = dr.GetString(2),
                    email = dr.GetString(3)
                });
            }
            return lista;


        }
    }
}