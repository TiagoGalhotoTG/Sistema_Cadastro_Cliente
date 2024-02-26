using System.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastClient.DAO;
using CadastClient.Entid;

namespace CadastClient.DAO
{
    public class CadastDAO
    {
        public int Inserir(CadastEntid objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.cadast;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "INSERT INTO sistcadastclient ([nomecomplet]) VALUES (@nomecomplet)";
               
            }
        }
    }
}
