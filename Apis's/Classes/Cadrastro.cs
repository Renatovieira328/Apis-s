using System;
using System.Data;

namespace Apis_s.Classes
{
    class Cadrastro
    {
        public int IdEmpresa { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public string Senha { get; set; }

        public Cadrastro()
        {
        }

        public Cadrastro(string nome, string telefone, string email, string cnpj, string senha)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Cnpj = cnpj;
            Senha = senha;
        }

        public Cadrastro(int idEmpresa, string nome, string telefone, string email, string cnpj, string senha)
        {
            IdEmpresa = idEmpresa;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Cnpj = cnpj;
            Senha = senha;
        }

        public void Cadrastrar_Empresa()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "cadrastrar_empresa";
            cmd.Parameters.AddWithValue("_idEmpresa", 0).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_telefone", Telefone);
            cmd.Parameters.AddWithValue("_email", Email);
            cmd.Parameters.AddWithValue("_cnpj", Cnpj);
            cmd.Parameters.AddWithValue("_senha", Senha);
            cmd.ExecuteNonQuery();
            IdEmpresa = Convert.ToInt32(cmd.Parameters["_idEmpresa"].Value);
        }

    }
}
