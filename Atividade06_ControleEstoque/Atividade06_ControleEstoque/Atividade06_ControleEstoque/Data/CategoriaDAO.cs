using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Atividade06_ControleEstoque.Models;

namespace Atividade06_ControleEstoque.Data
{
    public class CategoriaDAO
    {
        public void Inserir(Categoria categoria)
        {
            using (MySqlConnection conn = new Conexao().CriarConexao())
            {
                conn.Open();
                string sql = "INSERT INTO categorias (nome) VALUES (@nome)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", categoria.Nome);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Categoria categoria)
        {
            using (MySqlConnection conn = new Conexao().CriarConexao())
            {
                conn.Open();
                string sql = "UPDATE categorias SET nome = @nome WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", categoria.Nome);
                    cmd.Parameters.AddWithValue("@id", categoria.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (MySqlConnection conn = new Conexao().CriarConexao())
            {
                conn.Open();
                string sql = "DELETE FROM categorias WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            using (MySqlConnection conn = new Conexao().CriarConexao())
            {
                conn.Open();
                string sql = "SELECT * FROM categorias ORDER BY nome";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Categoria {
                                Id = Convert.ToInt32(dr["id"]),
                                Nome = dr["nome"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}