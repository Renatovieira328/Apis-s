namespace Apis_s.Classes
{
    public class Endereco
    {
        private readonly int idCliente;
        private readonly int idEmpresa;
        public int IdCliente { get { return IdCliente; } }
        public int IdEmpresa { get { return IdEmpresa; } }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

        public Endereco()
        {
        }

        public Endereco(int idCliente, int idEmpresa, string logradouro, string numero, string complemento, string cep, string bairro, string cidade, string uf)
        {
            this.idCliente = idCliente;
            this.idEmpresa = idEmpresa;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
        }

        public Endereco(string logradouro, string numero, string complemento, string cep, string bairro, string cidade, string uf)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
        }

        public void Cadrastrar_Endereco(int IdCliente, int IdEmpresa)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "cadrastrar_endereco";
            cmd.Parameters.AddWithValue("_cep", Cep);
            cmd.Parameters.AddWithValue("_logradouro", Logradouro);
            cmd.Parameters.AddWithValue("_complemento", Complemento);
            cmd.Parameters.AddWithValue("_bairro", Bairro);
            cmd.Parameters.AddWithValue("_cidade", Cidade);
            cmd.Parameters.AddWithValue("_uf", Uf);
            cmd.Parameters.AddWithValue("_idEmpresa", this.IdEmpresa);
            cmd.Parameters.AddWithValue("_idCliente", this.IdCliente);
            cmd.ExecuteNonQuery();
        }
    }
}
