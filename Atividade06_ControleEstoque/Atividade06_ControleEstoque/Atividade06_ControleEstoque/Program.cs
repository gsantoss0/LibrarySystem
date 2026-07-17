using System;
using System.Windows.Forms;
using Atividade06_ControleEstoque.Forms; // Esta linha resolve o seu erro!

namespace Atividade06_ControleEstoque
{
    internal sealed class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            
            Application.Run(new FrmPrincipal());
        }
    }
}