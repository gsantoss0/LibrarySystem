using System;
using MySql.Data.MySqlClient;

namespace Atividade06_ControleEstoque.Data
{

	public class Conexao
	{
		private readonly string stringConexao = 
        "Server=localhost;" +
        "Database=ds_controle_estoque;" +
        "Uid=root;" +
		"Pwd=;"+
		"SslMode =none";

    public MySqlConnection CriarConexao()
    {
        return new MySqlConnection(stringConexao);
    }
    
	}
}
