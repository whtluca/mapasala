using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using model.Entidade;

namespace mapasala.DAO
{
    public class ProfessorDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsql;";
        private SqlConnection Conexao;
        public ProfessorDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(ProfessoresEntidade professor)
        {
            Conexao.Open();
            string query = "Insert into Professores";
        }

    }
}
