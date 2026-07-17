
using System;

namespace Atividade06_ControleEstoque.Models
{

	public class Produto
	{
		public int Id { get; set; }
		public string Codigo { get; set; }
		public string Nome { get; set; }
		public int IdCategoria { get; set; }
		public string NomeCategoria { get; set; }
		public decimal PrecoCompra { get; set; }
		public decimal PrecoVenda { get; set; }
		public int Estoque { get; set; }
		public int EstoqueMinimo { get; set; }
		public bool Ativo { get; set; }
	}
}
