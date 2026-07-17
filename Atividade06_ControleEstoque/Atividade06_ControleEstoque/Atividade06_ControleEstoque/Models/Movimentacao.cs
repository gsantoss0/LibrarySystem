using System;

namespace Atividade06_ControleEstoque.Models
{
	public class Movimentacao
	{
    	public int Id { get; set; }
    	public int IdProduto { get; set; }
    	public string NomeProduto { get; set; } 
    	public string Tipo { get; set; } 
    	public int Quantidade { get; set; }
    	public DateTime DataMovimentacao { get; set; }
    	public string Observacao { get; set; }
	}
}
