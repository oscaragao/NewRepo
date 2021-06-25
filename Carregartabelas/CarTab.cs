using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Carregartabelas
{
    class CarTab
    {
        Encoding enc = Encoding.GetEncoding("us-ascii", new EncoderExceptionFallback(), new DecoderExceptionFallback());

     

        private static string connString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog =" + Carregartabelas.Program.MeuCatalog + ";User ID=" + Carregartabelas.Program.MyUser + ";Data Source=localhost\\SQLEXPRESS;";
        private static SqlConnection conn = null;

        // método que permite obter a conexão
        public static SqlConnection obterConexao()  
        {
            // vamos criar a conexão
            conn = new SqlConnection(connString);

            // a conexão foi feita com sucesso?
            try
            {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (SqlException)
            {
                conn = null;
                // ops! o que aconteceu?
                // uma boa idéia aqui é gravar a exceção em um arquivo de log
            }

            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        public void Carregar_Arquivo(string tabela, string arq, string exten )
        {

            int counter = 0;
            //arquivoExcel = arquivoExcel + exten;
            string linebanco;
            string vEmpresa;
            string vAtivo;
            string vAtivo33;
           // string vAtivo2;

   
            //***** falta colocar a tabela para o programa procurar os campos 

            // Read the file and display it line by line.  
           
            StreamReader file = new StreamReader(arq, Encoding.Default,true);
            
            vAtivo33 = tabela;

            //@"c:\test.txt");
            while ((linebanco = file.ReadLine()) != null)
            {
               if((counter != 0) || (linebanco == " "))
                    { 
                        vEmpresa = linebanco.Substring(0,31).Trim();
                        vAtivo   = linebanco.Substring(31,8).Trim();

                    ////Insert na s tabelas onbord
           
                    SqlConnection sqlConn  = new SqlConnection(connString);
                    sqlConn.Open();
                    SqlCommand  cmdsql = sqlConn.CreateCommand();
                    cmdsql.CommandText =@"Insert into " + vAtivo33 + @"(DS_EMP_ACAO ,NM_AT_ACAO )
                                                     values('" + vEmpresa + "','" + vAtivo + "')";
                                cmdsql.ExecuteNonQuery();                    
                    
                    sqlConn.Close();
                }
             
                counter++;
            }

            file.Close();

        }

       
       

        public sealed class GenericSingleton<T> where T : class, new()
        {
            private static T _instance;

            public static T Instance
            {
                get
                {
                    if (_instance == null)
                        _instance = new T();

                    return _instance;
                }
            }
        }


    }
}


  

