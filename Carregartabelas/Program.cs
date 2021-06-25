using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carregartabelas
{
    static class Program
    {
        public static string MeuCatalog;
        public static string MyUser;
        public static string connString;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);  
            Application.Run(new FrmAcesso());
        }
    }
}
