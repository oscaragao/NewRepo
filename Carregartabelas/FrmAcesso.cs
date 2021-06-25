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

            if ((this.txtCatalago.Text != "") && (this.txtUser.Text != ""))
            {
                SqlConnection conn = CarTab.obterConexao();


                if (conn == null)
                {
                    MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");
                   
                    CarTab.fecharConexao();
                }
                else
                {
                    FrmCarregaTabelas tela = new FrmCarregaTabelas();
                    tela.Show();
                }
            }
            else 
            {
                if (MessageBox.Show("Obrigatorio Preenchimento de Campos!!!", "Erro Carregar Banco e Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                   LimpaCampos();
                    CarTab.fecharConexao();
                }
            }
        }

        private void LimpaCampos() 
        {
            this.txtCatalago.Text = "";
            this.txtUser.Text = "";
            Carregartabelas.Program.MeuCatalog = "";
            Carregartabelas.Program.MyUser = "";

        }

        private void txtCatalago_TextChanged(object sender, EventArgs e)
        {
            Carregartabelas.Program.MeuCatalog = "";
            Carregartabelas.Program.MeuCatalog = this.txtCatalago.Text;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            Carregartabelas.Program.MyUser = "";
            Carregartabelas.Program.MyUser = this.txtUser.Text;
        }
    }
}
