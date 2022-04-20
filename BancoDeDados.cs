using System;
using MySql.Data.MySqlClient;

namespace Jamesmo.MySQL
{
    class BancoDeDados
    {
        MySqlConnection conexao;
        public BancoDeDados()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            string stringConexao;
            string server, port, database, uid, password;

            //Informações de conexão com o banco
            server = ("localhost");
            port = ("3306");
            database = ("dbjamesmo");
            uid = ("root");
            password = ("");

            //String de conexão com o banco de dados baseado nas variáveis acima
            stringConexao = ($"SERVER={server};PORT={port};DATABASE={database};UID={uid};PASSWORD={password}");

            //Atribuindo a string de conexão ao objeto de conexão MySQL
            conexao = new MySqlConnection(stringConexao);
        }

        public void Inserir(string aMarca, string aModelo, string aAno)
        {
            //Comando insert e atribuição dos parametros do comando
            MySqlCommand comando = new MySqlCommand("INSERT INTO tbveiculos (marcaVeiculo, modeloVeiculo, anoVeiculo) VALUES (@MARCA,@MODELO,@ANO)", conexao);
            comando.Parameters.AddWithValue("@MARCA", aMarca);
            comando.Parameters.AddWithValue("@MODELO", aModelo);
            comando.Parameters.AddWithValue("@ANO", aAno);
            //Tentiva de conexão e execução do comando, tratamento de erro se necessário
            try
            {
                //Conecta e executa o comando
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                //Exibe mensagem de erro se acontecer algum
                Console.WriteLine("\n\n" + ex.Message);
                Console.ReadLine();
            }
        }

        public void Deletar(string aModelo)
        {
            //Comando delete e atribuição dos parametros do comando
            MySqlCommand comando = new MySqlCommand("DELETE FROM tbveiculos WHERE modeloVeiculo=@MODELO", conexao);
            comando.Parameters.AddWithValue("@MODELO", aModelo);
            //Tentiva de conexão e execução do comando, tratamento de erro se necessário
            try
            {
                //Conecta e executa o comando
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                //Exibe mensagem de erro se acontecer algum
                Console.WriteLine("\n\n " + ex.Message);
                Console.ReadLine();
            }
        }

        public void Select()
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM tbveiculos", conexao);
            conexao.Open();
            MySqlDataReader dataReader = comando.ExecuteReader();

            Console.WriteLine(String.Format("{0,2} | {1,-15} | {2,10} | {3,2}", "ID", "Marca", "Modelo", "Ano"));
            Console.WriteLine("----------------------------------------");

            while (dataReader.Read())
            {
                int id = (int)dataReader["idVeiculo"];
                string marca = (string)dataReader["marcaVeiculo"];
                string modelo = (string)dataReader["modeloVeiculo"];
                string ano = (string)dataReader["anoVeiculo"];
                //Console.WriteLine(id+ "         " +marca+ "         " +modelo+ "            " +ano);
                Console.WriteLine(String.Format("{0,2} | {1,-15} | {2,10} | {3,2}", id, marca, modelo, ano));
            }
            Console.WriteLine("----------------------------------------");
            dataReader.Close();
            conexao.Close();
        }
    }
}
