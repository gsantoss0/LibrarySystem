using MySql.Data.MySqlClient;

namespace CadastroClientes.Data
{
    public class Conexao
    {
        private readonly string stringConexao =
            "Server=localhost;" +
            "Database=ds_cadastro_clientes;" +
            "Uid=root;" +
        	"Pwd=;" ;

        public MySqlConnection CriarConexao()
        {
            return new MySqlConnection(stringConexao);
        }
    }
}