using System;
using System.Data;

namespace Apis_s.Classes
{
    class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string email, string senha, string cpf)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
        }

        public Cliente(int idCliente, string nome, string email, string senha, string cpf)
        {
            IdCliente = idCliente;
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
        }

        public void Cadrastrar_Cliente()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "cadrastrar_cliente";
            cmd.Parameters.AddWithValue("_idCliente", 0).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_email", Email);
            cmd.Parameters.AddWithValue("_senha", Senha);
            cmd.Parameters.AddWithValue("_cpf", Cpf);
            cmd.ExecuteNonQuery();
            IdCliente = Convert.ToInt32(cmd.Parameters["_idCliente"].Value);
        }
    }
}
