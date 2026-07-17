using System;
using System.Windows.Forms;
using CadastroClientes.Forms; // Importa a pasta onde está o FrmClientes

namespace CadastroClientes
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Aqui nós dizemos para iniciar pelo FrmClientes
            Application.Run(new FrmClientes());
        }
    }
}