using AppPruebaGit.Datos;
using AppPruebaGit.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppPruebaGit.Logica
{
    public class ClUsuarioL
    {
        ClUsuarioD datos = new ClUsuarioD();

        public List<Usuario> Listar()
        {
            return datos.listar();
        }
        public bool Registrar(Usuario u)
        {
            return datos.Registrar(u);
        }
        public bool Editar(Usuario u)
        {
            return datos.Editar(u);
        }
        public bool Eliminar(int documento)
        {
            return datos.Eliminar(documento);
        }
        public Usuario Buscar(int documento)
        {
            return datos.Buscar(documento);
        }

    }
}