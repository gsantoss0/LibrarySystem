using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Atividade06_ControleEstoque.Models;

namespace Atividade06_ControleEstoque.Data
{
    public class ProdutoDAO
    {
        public void Inserir(Produto produto)
        {
            using (MySqlConnection conn = new Conexao().CriarConexao())
            {
                conn.Open();
                string sql = "INSERT INTO produtos (codigo, nome, id_categoria, preco_compra, preco_venda, estoque, estoque_minimo, ativo) " +
                             "VALUES (@codigo, @nome, @id_categoria, @preco_compra, @preco_venda, 0, @estoque_minimo, 1)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@codigo", produto.Codigo);
                    cmd.Parameters.AddWithValue("@nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@id_categoria", produto.IdCategoria);
                    cmd.Parameters.AddWithValue("@preco_compra", produto.PrecoCompra);
                    cmd.Parameters.AddWithValue("@preco_venda", produto.PrecoVenda);
                    cmd.Parameters.AddWithValue("@estoque_minimo", produto.EstoqueMinimo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Produto produto)
        {
            using (MySqlConnection conn = new Conexao().CriarConexao())
            {
                conn.Open();
                string sql = "UPDATE produtos SET codigo = @codigo, nome = @nome, id_categoria = @id_categoria, " +
                             "preco_compra = @preco_compra, preco_venda = @preco_venda, estoque_minimo = @estoque_minimo " +
                             "WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@codigo", produto.Codigo);
                    cmd.Parameters.AddWithValue("@nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@id_categoria", produto.IdCategoria);
                    cmd.Parameters.AddWithValue("@preco_compra", produto.PrecoCompra);
                    cmd.Parameters.AddWithValue("@preco_venda", produto.PrecoVenda);
                    cmd.Parameters.AddWithValue("@estoque_minimo", produto.EstoqueMinimo);
                    cmd.Parameters.AddWithValue("@id", produto.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AlterarSituacao(int id, bool ativo)
        {
            using (MySqlConnection conn = new Conexao().CriarConexao())
            {
                conn.Open();
                string sql = "UPDATE produtos SET ativo = @ativo WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ativo", ativo ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (MySqlConnection conn = new Conexao().CriarConexao())
            {
                conn.Open();
                string sql = "DELETE FROM produtos WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Produto BuscarPorId(int id)
        {
            using (MySqlConnection conn = new Conexao().CriarConexao())
            {
                conn.Open();
                string sql = "SELECT * FROM vw_produtos_completos WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new Produto {
                                Id = Convert.ToInt32(dr["id"]),
                                Codigo = dr["codigo"].ToString(),
                                Nome = dr["nome"].ToString(),
                                IdCategoria = Convert.ToInt32(dr["id_categoria"]),
                                NomeCategoria = dr["categoria"].ToString(),
                                PrecoCompra = Convert.ToDecimal(dr["preco_compra"]),
                                PrecoVenda = Convert.ToDecimal(dr["preco_venda"]),
                                Estoque = Convert.ToInt32(dr["estoque"]),
                                EstoqueMinimo = Convert.ToInt32(dr["estoque_minimo"]),
                                Ativo = Convert.ToBoolean(dr["ativo"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        public List<Produto> Listar()
        {
            List<Produto> lista = new List<Produto>();
            using (MySqlConnection conn = new Conexao().CriarConexao())
            {
                conn.Open();
                string sql = "SELECT * FROM vw_produtos_completos ORDER BY nome";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Produto {
                                Id = Convert.ToInt32(dr["id"]),
                                Codigo = dr["codigo"].ToString(),
                                Nome = dr["nome"].ToString(),
                                IdCategoria = Convert.ToInt32(dr["id_categoria"]),
                                NomeCategoria = dr["categoria"].ToString(),
                                PrecoCompra = Convert.ToDecimal(dr["preco_compra"]),
                                PrecoVenda = Convert.ToDecimal(dr["preco_venda"]),
                                Estoque = Convert.ToInt32(dr["estoque"]),
                                EstoqueMinimo = Convert.ToInt32(dr["estoque_minimo"]),
                                Ativo = Convert.ToBoolean(dr["ativo"])
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public List<Produto> Pesquisar(string termo)
        {
            List<Produto> lista = new List<Produto>();
            using (MySqlConnection conn = new Conexao().CriarConexao())
            {
                conn.Open();
                string sql = "SELECT * FROM vw_produtos_completos WHERE nome LIKE @termo OR codigo LIKE @termo ORDER BY nome";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@termo", "%" + termo + "%");
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Produto {
                                Id = Convert.ToInt32(dr["id"]),
                                Codigo = dr["codigo"].ToString(),
                                Nome = dr["nome"].ToString(),
                                IdCategoria = Convert.ToInt32(dr["id_categoria"]),
                                NomeCategoria = dr["categoria"].ToString(),
                                PrecoCompra = Convert.ToDecimal(dr["preco_compra"]),
                                PrecoVenda = Convert.ToDecimal(dr["preco_venda"]),
                                Estoque = Convert.ToInt32(dr["estoque"]),
                                EstoqueMinimo = Convert.ToInt32(dr["estoque_minimo"]),
                                Ativo = Convert.ToBoolean(dr["ativo"])
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}