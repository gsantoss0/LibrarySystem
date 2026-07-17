using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using CadastroClientes.Models;

namespace CadastroClientes.Data
{
    public class ClienteDAO
    {
        private Conexao _conexao = new Conexao();

        public void Inserir(Cliente cliente)
        {
            using (MySqlConnection conn = _conexao.CriarConexao())
            {
                conn.Open();
                string sql = "INSERT INTO clientes (nome, cpf, email, telefone, cidade, ativo) VALUES (@nome, @cpf, @email, @telefone, @cidade, @ativo)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@cpf", cliente.CPF);
                    cmd.Parameters.AddWithValue("@email", cliente.Email);
                    cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
                    cmd.Parameters.AddWithValue("@ativo", cliente.Ativo ? 1 : 0);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Cliente cliente)
        {
            using (MySqlConnection conn = _conexao.CriarConexao())
            {
                conn.Open();
                string sql = "UPDATE clientes SET nome=@nome, cpf=@cpf, email=@email, telefone=@telefone, cidade=@cidade WHERE id=@id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", cliente.Id);
                    cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@cpf", cliente.CPF);
                    cmd.Parameters.AddWithValue("@email", cliente.Email);
                    cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AlterarSituacao(int id, bool ativo)
        {
            using (MySqlConnection conn = _conexao.CriarConexao())
            {
                conn.Open();
                string sql = "UPDATE clientes SET ativo=@ativo WHERE id=@id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@ativo", ativo ? 1 : 0);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (MySqlConnection conn = _conexao.CriarConexao())
            {
                conn.Open();
                string sql = "DELETE FROM clientes WHERE id=@id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            using (MySqlConnection conn = _conexao.CriarConexao())
            {
                conn.Open();
                string sql = "SELECT * FROM clientes ORDER BY nome";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(MapearCliente(reader));
                    }
                }
            }
            return lista;
        }

        public List<Cliente> PesquisarPorNome(string nome)
        {
            List<Cliente> lista = new List<Cliente>();
            using (MySqlConnection conn = _conexao.CriarConexao())
            {
                conn.Open();
                string sql = "SELECT * FROM clientes WHERE nome LIKE @nome ORDER BY nome";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(MapearCliente(reader));
                        }
                    }
                }
            }
            return lista;
        }

        private Cliente MapearCliente(MySqlDataReader reader)
        {
            return new Cliente
            {
                Id = Convert.ToInt32(reader["id"]),
                Nome = reader["nome"].ToString(),
                CPF = reader["cpf"].ToString(),
                Email = reader["email"].ToString(),
                Telefone = reader["telefone"].ToString(),
                Cidade = reader["cidade"].ToString(),
                Ativo = Convert.ToBoolean(reader["ativo"]),
                DataCadastro = Convert.ToDateTime(reader["data_cadastro"])
            };
        }
    }
}