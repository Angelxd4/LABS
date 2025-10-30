using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace AppPruebaGit.Datos
{
    public class ClConexion
    {
        SqlConnection oConex;

        public ClConexion()
        {
            oConex = new SqlConnection("Data Source=DESKTOP-HV9ISR7\\SQLEXPRESS;Initial Catalog=GitHub;Integrated Security=True;");
        }
        public SqlConnection MtAbrir()
        {
            oConex.Open();
            return oConex;

        }
        public void MtCerrar()
        {
            oConex.Close();
        
        }
        
        

    }
}