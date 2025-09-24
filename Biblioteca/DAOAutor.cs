using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class DAOAutor
    {
        public MySqlConnection conexao;//Criando uma chave para a classe MYSQLCONNECTION
        public string dados;
        public string comando;
        public int[] codigo1;
        public string[] nome;
        public string[] nacionalidade;
        public int i;
        public int contador;
        public string msg;

        public DAOAutor()
        {
            //Conectar com o banco
            conexao = new MySqlConnection("server=localhost;DataBase=biblioteca;Uid=root;Password=;Convert Zero DateTime=True");
            try
            {
                conexao.Open();//Tenta abrir a conexao com o Banco de Dados
                Console.WriteLine("Conectado Sucesso!");
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Algo deu errado!\n\n {erro}");
                conexao.Close();//Fechar a conexao
            }//fim do try_catch
        }//fim do construtor

        public void Inserir(string nome, string nacionalidade)
        {
            try
            {
                dados = $"('','{nome}', '{nacionalidade}')";
                comando = $"Insert into autor(codigo, nome, nacionalidade) values{dados}";
                //Lançar os dados no banco
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                string resultado = "" + sql.ExecuteNonQuery();// Comando de inserção/Ações
                Console.WriteLine($"Inserido com sucesso! {resultado}");//Visualização do resultado
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Algo deu Errado!\n\n {erro}");
            }//fim do catch
        }//fim do inserir

        //Método para preencher o vetor
        public void PreencherVetorAutor()
        {
            string query = "select * from autor";//Comando SQL para acesso aos dados
            //Instanciar os vetores
            codigo1 = new int[100];
            nome = new string[100];
            nacionalidade = new string[100];

            //Reafirmar o preenchimento dos vetores
            for (i = 0; i < 100; i++)
            {
                codigo1[i] = 0;
                nome[i] = "";
                nacionalidade[i] = "";
            }//Fim do for

            //Executar o comando no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Leitura dos dados do banco - Por linha
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            //Buscar os dados do banco e preencher o vetor
            while (leitura.Read())
            {
                codigo1[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = leitura["nome"] + "";
                nacionalidade[i] = leitura["nacionalidade"] + "";
                i++;//Ande pelo vetor
                contador++;//Contar exatamente quantos dados froam inseridos
            }//Fim do while

            //Fechar a leitura dos dados com o banco de dados
            leitura.Close();
        }//Fim do PreencherVetor


        public string ConsultarTudoAutor()
        {
            //Preencher o vetor
            PreencherVetorAutor();
            msg = "";//Instanciando a variável
            for (i = 0; i < contador; i++)
            {
                msg += $"\nCódigo: {codigo1[i]} \nNome: {nome[i]} \nNacionalidade: {nacionalidade[i]}\n";
            }//Fim do for

            //Mostrar todos os dados do banco de dados
            return msg;
        }//Fim do ConsultarTudo

        public string ConsultarPorCodigoAutor(int codigo)
        {
            PreencherVetorAutor();
            msg = "";
            for (i = 0; i < contador; i++)
            {
                if (this.codigo1[i] == codigo)
                {
                    msg = $"\nCódigo: {this.codigo1[i]} \nNome: {nome[i]} \nNacionalidade: {nacionalidade[i]}\n";
                    return msg;
                }//Fim do if
            }//Fim do for
            return "\n\nCódigo informado não foi encontrado!";
        }//Fim do ConsultarCodigo

        public string AtualizarAutor(int codigo, string campo, string novoDado)
        {
            try
            {
                string query = $"update autor set {campo} = '{novoDado}' where codigo = '{codigo}'";
                //Executar o comando
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + " dado atualizado com sucesso!";
            }
            catch (Exception erro)
            {
                return $"\nAlgo deu errado!\n\n {erro}";
            }
        }//Fim do Atualizar

        public string DeletarAutor(int codigo)
        {
            try
            {
                string query = $"delete from autor where codigo = '{codigo}'";
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + " dado excluído com sucesso!";
            }
            catch (Exception erro)
            {
                return $"Algo deu errado\n\n {erro}";
            }
        }//Fim do Deletar

    }//fim da classe
}//fim do projeto
