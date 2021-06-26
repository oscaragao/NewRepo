using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Carregartabelas
{
    public partial class FrmAcesso : Form
    {
        public FrmAcesso()
        {
            InitializeComponent();
        }

        private void btnEntra_Click(object sender, EventArgs e)
        {

            PPconnString();
            this.textBox1.Text = Program.connString;
        

            if ((this.txtCatalago.Text != "") && (this.txtUser.Text != ""))
            {
                SqlConnection conn = CarTab.obterConexao();


                try
                { if (conn != null)
                    { 
                        FrmCarregaTabelas tela = new FrmCarregaTabelas();
                        tela.Show();
                    }
                    else if (conn == null)
                    {
                        MessageBox.Show("Nulo. Não foi possível obter a conexão. Veja o log de erros.");
                                               
                    }
                }
                catch (SqlException)
                {
                        MessageBox.Show("Erro SQL Exception. Veja o log de erros.", "Erro Carregar Banco e Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                }

            }
            else
            {
                MessageBox.Show("Obrigatorio Preenchimento de Campos!!!", "Erro Carregar Banco e Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CarTab.fecharConexao();

        }

 

        private void txtCatalago_TextChanged(object sender, EventArgs e)
        {

            Carregartabelas.Program.MeuCatalog = this.txtCatalago.Text;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

            Carregartabelas.Program.MyUser = this.txtUser.Text;
        }

        public void PPconnString()
        {
            Program.connString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog =" + Carregartabelas.Program.MeuCatalog + ";User ID=" + Carregartabelas.Program.MyUser + ";Data Source=localhost\\SQLEXPRESS;";
        }

        private void lblTexto_Click(object sender, EventArgs e)
        {

        }
    }
}
