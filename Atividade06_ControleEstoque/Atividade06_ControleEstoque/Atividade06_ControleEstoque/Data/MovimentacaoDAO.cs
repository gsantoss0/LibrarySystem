using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Atividade06_ControleEstoque.Models;

namespace Atividade06_ControleEstoque.Data
{
    public class MovimentacaoDAO
    {
        public void Registrar(Movimentacao mov)
        {
            using (MySqlConnection conn = new Conexao().CriarConexao())
            {
                conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Inserir o registro de movimentação
                        string sqlMov = "INSERT INTO movimentacoes (id_produto, tipo, quantidade, observacao) " +
                                        "VALUES (@id_produto, @tipo, @quantidade, @observacao)";
                        using (MySqlCommand cmdMov = new MySqlCommand(sqlMov, conn, trans))
                        {
                            cmdMov.Parameters.AddWithValue("@id_produto", mov.IdProduto);
                            cmdMov.Parameters.AddWithValue("@tipo", mov.Tipo);
                            cmdMov.Parameters.AddWithValue("@quantidade", mov.Quantidade);
                            cmdMov.Parameters.AddWithValue("@observacao", mov.Observacao);
                            cmdMov.ExecuteNonQuery();
                        }

                        // 2. Atualizar saldo físico no produto
                        string sqlProd = "";
                        if (mov.Tipo == "ENTRADA")
                            sqlProd = "UPDATE produtos SET estoque = estoque + @quantidade WHERE id = @id";
                        else
                            sqlProd = "UPDATE produtos SET estoque = estoque - @quantidade WHERE id = @id";

                        using (MySqlCommand cmdProd = new MySqlCommand(sqlProd, conn, trans))
                        {
                            cmdProd.Parameters.AddWithValue("@quantidade", mov.Quantidade);
                            cmdProd.Parameters.AddWithValue("@id", mov.IdProduto);
                            cmdProd.ExecuteNonQuery();
                        }

                        trans.Commit();
                    }
                    catch (Exception)
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        public List<Movimentacao> ListarTodos()
        {
            List<Movimentacao> lista = new List<Movimentacao>();
            using (MySqlConnection conn = new Conexao().CriarConexao())
            {
                conn.Open();
                string sql = "SELECT * FROM vw_movimentacoes_completas ORDER BY data_movimentacao DESC";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Movimentacao {
                                Id = Convert.ToInt32(dr["id"]),
                                IdProduto = Convert.ToInt32(dr["id_produto"]),
                                NomeProduto = dr["produto"].ToString(),
                                Tipo = dr["tipo"].ToString(),
                                Quantidade = Convert.ToInt32(dr["quantidade"]),
                                DataMovimentacao = Convert.ToDateTime(dr["data_movimentacao"]),
                                Observacao = dr["observacao"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}