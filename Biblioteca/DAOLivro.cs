using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data; //Import do MySQL
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.Mozilla; //Import do MySql - Com métodos do crud

namespace Biblioteca
{
    class DAOLivro
    {
        public MySqlConnection conexao;//Criando uma chave para a classe MYSQLCONNECTION
        public string dados;
        public string comando;
        public int[] codigo;//Um vetor para cada coluna
        public long[] ISBN;
        public string[] titulo;
        public DateTime[] ano;
        public string[] editora;
        public int[] categoriaCodigo;
        public int i;//Declaração global do contador
        public int contador;
        public string msg;//Variável acumuladora - Unir os dados da consulta
        public DAOLivro()
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

        public void Inserir(long ISBN, string titulo, DateTime ano, string editora, int categoriaCodigo)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter();
                parameter.ParameterName = "@Date";
                parameter.MySqlDbType = MySqlDbType.Date;
                parameter.Value = $"{ano.Year}-{ano.Month}-{ano.Day}";
                dados = $"('','{ISBN}','{titulo}','{parameter.Value}','{editora}','{categoriaCodigo}')";
                comando = $"Insert into livro(codigo, isbn, titulo, ano, editora, categoriaCodigo) values{dados}";
                //Lançar os dados no banco
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                string resultado = "" + sql.ExecuteNonQuery();// Comando de inserção/Ações
                Console.WriteLine($"Inserido com sucesso! {resultado}");//Visualização do resultado
            }catch(Exception erro)
            {
                Console.WriteLine($"Algo deu Errado!\n\n {erro}");
            }//fim do catch
        }//fim do inserir

        public void PreencherVetorLivro()
        {
            string query = "select * from livro";//Comando SQL para acesso aos dados
            //Instanciar os vetores
            codigo = new int[100];
            ISBN = new long[100];
            titulo = new string[100];
            ano = new DateTime[100];
            editora = new string[100];
            categoriaCodigo = new int[100];

            //Reafirmar o preenchimento dos vetores
            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                ISBN[i] = 0;
                titulo[i] = "";
                ano[i] = new DateTime();
                editora[i] = "";
                categoriaCodigo[i] = 0;
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
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                ISBN[i] = Convert.ToInt64(leitura["ISBN"]);
                titulo[i] = leitura["titulo"] + "";
                ano[i] = Convert.ToDateTime(leitura["ano"]);
                editora[i] = leitura["editora"] + "";
                categoriaCodigo[i] = Convert.ToInt32(leitura["categoriaCodigo"]);
                i++;//Ande pelo vetor
                contador++;//Contar exatamente quantos dados froam inseridos
            }//Fim do while

            //Fechar a leitura dos dados com o banco de dados
            leitura.Close();
        }//Fim do PreencherVetor

        public string ConsultarTudoLivro()
        {
            //Preencher o vetor
            PreencherVetorLivro();
            msg = "";//Instanciando a variável
            for (i = 0; i < contador; i++)
            {
                msg += $"\nCódigo: {codigo[i]} \nISBN: {ISBN[i]} \nTítulo: {titulo[i]} \nAno: {ano[i]} \nEditora: {editora[i]} \nCodigo da Categoria: {categoriaCodigo[i]}";
            }//Fim do for

            //Mostrar todos os dados do banco de dados
            return msg;
        }//Fim do ConsultarTudo

        public string ConsultarPorCodigoLivro(int codigo)
        {
            PreencherVetorLivro();
            msg = "";
            for (i = 0; i < contador; i++)
            {
                if (this.codigo[i] == codigo)
                {
                    msg = $"\nCódigo: {this.codigo[i]} \nISBN:  {ISBN[i]}  \nTítulo:  {titulo[i]}  \nAno: {ano[i]} \nEditora: {editora[i]} \nCódigo da Categoria: {categoriaCodigo[i]}";
                    return msg;
                }//Fim do if
            }//Fim do for
            return "\n\nCódigo informado não foi encontrado!";
        }//Fim do ConsultarCodigo

        public string AtualizarLivro(int codigo, string campo, string novoDado)
        {
            try
            {
                string query = $"update livro set {campo} = '{novoDado}' where codigo = '{codigo}'";
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

        public string AtualizarLivro(int codigo, string campo, int novoDado)
        {
            try
            {
                string query = $"update livro set {campo} = '{novoDado}' where codigo = '{codigo}'";
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

        public string AtualizarLivro(int codigo, string campo, DateTime novoDado)
        {
            try
            {
                string query = $"update livro set {campo} = '{novoDado}' where codigo = '{codigo}'";
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

        public string AtualizarLivro(int codigo, string campo, long novoDado)
        {
            try
            {
                string query = $"update livro set {campo} = '{novoDado}' where codigo = '{codigo}'";
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

        public string DeletarLivro(int codigo)
        {
            try
            {
                string query = $"delete from livro where codigo = '{codigo}'";
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
