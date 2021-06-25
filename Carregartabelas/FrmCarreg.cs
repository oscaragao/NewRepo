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


namespace Carregartabelas
{
    public partial class FrmCarregaTabelas : Form
    {
        public FrmCarregaTabelas()
        {

          InitializeComponent();

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

        private void CarregarText()
        {

            
           if (cboPatharquivo.SelectedItem.ToString() != null)
            {
                string vcarTexto = cboPatharquivo.SelectedItem.ToString();

                string subs = Path.GetExtension(vcarTexto);
                
                this.txtextensao.Text = subs;
                this.txtArquivo.Text = "dbo.cad_acoes";
            }
         
        }


        private void button1_Click(object sender, EventArgs e)
        {
          

            var dllcartab = new CarTab();



            try
            {
         
                dllcartab.Carregar_Arquivo(txtArquivo.Text, cboPatharquivo.SelectedItem.ToString(), txtextensao.Text);

                MessageBox.Show("Cadastro efetuado com sucesso!!!!", "Carregar Arquivos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                if (MessageBox.Show("Arquivo Não Gerado. Deseja reiniciar!!!", "Carregar Arquivos",  MessageBoxButtons.OKCancel,  MessageBoxIcon.Error) == DialogResult.OK)
                {
                    dllcartab.Carregar_Arquivo(txtArquivo.Text, cboPatharquivo.SelectedItem.ToString(), txtextensao.Text);
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
            try
            {
                fbdProc.SelectedPath = txtPathArquivo.Text;
                if (fbdProc.ShowDialog() == DialogResult.OK)
                {
                     txtPathArquivo.Text = fbdProc.SelectedPath;
                    

                }
            }
            catch
            {
                throw;
            }

             
            InitializeComboBox2(txtPathArquivo.Text);


        }

        private void InitializeComboBox2(string patharquivo)
        {

            string patha2 = patharquivo.Replace(@"\\", @"\");

       
            string[] diretorios = Directory.GetFiles(patha2, @"*.*");
            foreach (string file in diretorios)
            {
                cboPatharquivo.Items.Add(file);
            }

            this.cboPatharquivo.Enabled = true;
        }

        private void txtPathArquivo_TextChanged(object sender, EventArgs e)
        {
            this.txtPathArquivo.Text = Carregartabelas.Program.MeuCatalog;
        }
    }
}
