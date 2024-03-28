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
                con.Open();
                cn.CommandText = "INSERT INTO pessoafisica ([nomecomplet],[dataincluscadast],[cpf], [rg], [profissao])" +
                    " VALUES (@nomecomplet, @dataincluscadast,@cpf, @rg, @profissao)";
                cn.Parameters.Add("dataincluscadast", SqlDbType.Date).Value = objTabela.Dataincluscadast;
                cn.Parameters.Add("nomecomplet", SqlDbType.VarChar).Value = objTabela.Nomecomplet;
                cn.Parameters.Add("cpf", SqlDbType.VarChar).Value = objTabela.Cpf;
                cn.Parameters.Add("rg", SqlDbType.VarChar).Value = objTabela.Rg;
                cn.Parameters.Add("profissao", SqlDbType.VarChar). Value = objTabela.Profissao;
                cn.Connection = con;
                int sn = cn.ExecuteNonQuery();
                return sn;
                
            }
        }
    }
}
