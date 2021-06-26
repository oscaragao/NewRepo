using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace Carregartabelas
{
    public partial class FrmCarregaTabelas : Form
    {
        private static string vname = "";
        public static bool primeivz = true;

        public FrmCarregaTabelas()
        {

          InitializeComponent();
            this.txtPathArquivo.Text = Program.connString;
            this.lblBanco.Text = Program.MeuCatalog;
            carregacombTabelas();
            // primeivz = true;
        }

      

        private void Form1_Load(object sender, System.EventArgs e) 
        {
            // InitializeComboBox();
            this.cboPatharquivo.Enabled = false;
        }


        private void InitializeComboBox()       
        {
            string[] diretorios = Directory.GetFiles(@"C:\Para_arq\vale_esta\", "*.*");
            foreach (string file in diretorios)
            {
                cboPatharquivo.Items.Add(file);
            }

       
        }


        public void carregacombTabelas()
        {

            // vamos obter a conexão com o banco de dados
            SqlConnection conn = CarTab.obterConexao();

            // a conexão foi efetuada com sucesso?
            if (conn == null)
            {
                MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");
            }
            else
            {

                string ssql = "SELECT TABLE_NAME FROM information_schema.tables where table_catalog ='" + Program.MeuCatalog + "'";


                SqlDataAdapter comando = new SqlDataAdapter(ssql, conn);
                DataTable dtResultado = new DataTable();
                dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)

                cmbTabelas.DataSource = null;
                comando.Fill(dtResultado);
                cmbTabelas.DataSource = dtResultado;
                cmbTabelas.ValueMember = "TABLE_NAME";
                // cmbTabelas.DisplayMember = "DS_EMP_ACAO";
                cmbTabelas.SelectedItem = "";

                this.cmbTabelas.Text = "";

            }

            // não precisamos mais da conexão? vamos fechá-la
            CarTab.fecharConexao();

            
        }


        private void CarregarText()
        {

            
           if (cboPatharquivo.SelectedItem.ToString() != null)
            {
                string vcarTexto = cboPatharquivo.SelectedItem.ToString();

                string subs = Path.GetExtension(vcarTexto);
                
                this.txtextensao.Text = subs;
                // this.txtArquivo.Text = "dbo.cad_acoes";
            }
         
        }


        private void button1_Click(object sender, EventArgs e)
        {
          

            var dllcartab = new CarTab();



            try
            {
         
                dllcartab.Carregar_Arquivo(vname, cboPatharquivo.SelectedItem.ToString(), txtextensao.Text);

                MessageBox.Show("Cadastro efetuado com sucesso!!!!", "Carregar Arquivos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                if (MessageBox.Show("Arquivo Não Gerado. Deseja reiniciar!!!", "Carregar Arquivos",  MessageBoxButtons.OKCancel,  MessageBoxIcon.Error) == DialogResult.OK)
                {
                    dllcartab.Carregar_Arquivo(vname, cboPatharquivo.SelectedItem.ToString(), txtextensao.Text);
                }
                else 
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!!!!", "Carregar Arquivos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void cboPatharquivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarText();
        }

        private void txtextensao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            string recebepath = "";

            try
            {
                fbdProc.SelectedPath = txtPathArquivo.Text;
                if (fbdProc.ShowDialog() == DialogResult.OK)
                {
                    recebepath = fbdProc.SelectedPath;
                }
            }
            catch
            {
                throw;
            }
            
            InitializeComboBox2(recebepath);
        }

        private void InitializeComboBox2(string patharquivo)
        {

             string patha2 = patharquivo.Replace(@"\\", @"\");

       
            string[] diretorios = Directory.GetFiles(patharquivo, @"*.*");
            foreach (string file in diretorios)
            {
                cboPatharquivo.Items.Add(file);
            }

            this.cboPatharquivo.Enabled = true;
        }

        private void txtPathArquivo_TextChanged(object sender, EventArgs e)
        {
            this.txtPathArquivo.Text = Program.connString;
        }

        private void txtArquivo_TextChanged(object sender, EventArgs e)
        {
            this.txtArquivo.Text = Program.MeuCatalog;
        }

        public void contacampostab(string patharquivo)
        {
            string ltlista;
            // vamos obter a conexão com o banco de dados
            SqlConnection conn = CarTab.obterConexao();

            // a conexão foi efetuada com sucesso?
            if (conn == null)
            {
                MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");
            }
            else
            {

                string ssql = "select count(1) as total, tabela from dbo.tbl_JK  where tabela = '" + patharquivo + "' group by tabela";


             

                SqlCommand cmd = new SqlCommand(ssql, conn);
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {

                   int  ltlista2 = reader.GetInt32(0);

                    ltlista = Convert.ToString(ltlista2);

                  this.lblQuantCampos.Text = ltlista + " campos" ;
                }


            }

            // não precisamos mais da conexão? vamos fechá-la
            CarTab.fecharConexao();


        }

        private void fbdProc_HelpRequest(object sender, EventArgs e)
        {

        }

        private void cmbTabelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.cmbTabelas.SelectedIndex;
            Object selectedItem = cmbTabelas.SelectedItem;

            if (primeivz != true)
            {
                vname = cmbTabelas.SelectedValue.ToString();

                contacampostab(vname);
            }
            else
            { 
                primeivz = false; 
            }

       
        }
    }
    
}
