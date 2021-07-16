using System;
using System.Data;

namespace Apis_s.Classes
{
    public class Funcionario
    {
        private readonly int idEmpresa;
        public int IdEmpresa { get { return idEmpresa; } }
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public Funcionario(int idEmpresa, int idFuncionario, string nome, string email, string senha)
        {
            this.idEmpresa = idEmpresa;
            IdFuncionario = idFuncionario;
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public void Cadrastrar_Funcionario()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "cadrastrar_funcionario";
            cmd.Parameters.AddWithValue("_idFuncionario", 0).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_email", Email);
            cmd.Parameters.AddWithValue("_senha", Senha);
            cmd.Parameters.AddWithValue("_empresa_idEmpresa", this.IdEmpresa);

            cmd.ExecuteNonQuery();
            IdFuncionario = Convert.ToInt32(cmd.Parameters["_idFuncionario"].Value);
        }
    }
}
