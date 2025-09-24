using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data; //Import do MySQL
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.EC.Endo;

namespace Biblioteca
{
    class DAOCategoria
    {
        public MySqlConnection conexao;//Criando uma chave para a classe MYSQLCONNECTION
        public string dados;
        public string comando;
        public int[] codigo;//Um vetor para cada coluna
        public string[] descricao;
        public int i;//Declaração global do contador
        public int contador;
        public string msg;//Variável acumuladora - Unir os dados da consulta

        public DAOCategoria()
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

        public void Inserir(string descricao)
        {
            try
            {
                dados = $"('','{descricao}')";
                comando = $"Insert into categoria(codigo, descricao) values{dados}";
                //Lançar os dados no banco
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                string resultado = "" + sql.ExecuteNonQuery();// Comando de inserção/Ações
                Console.WriteLine($"Inserido com sucesso! {resultado}");//Visualização do resultado
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Algo deu Errado!\n\n {erro}");
            }//Fim do catch
        }//Fim do inserir

        //Método para preencher o vetor
        public void PreencherVetor()
        {
            string query = "select * from categoria";//Comando SQL para acesso aos dados
            //Instanciar os vetores
            codigo = new int[100];
            descricao = new string[100];

            //Reafirmar o preenchimento dos vetores
            for(i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                descricao[i] = "";
            }//Fim do for

            //Executar o comando no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Leitura dos dados do banco - Por linha
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            //Buscar os dados do banco e preencher o vetor
            while(leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                descricao[i] = leitura["descricao"] + "";
                i++;//Ande pelo vetor
                contador++;//Contar exatamente quantos dados froam inseridos
            }//Fim do while

            //Fechar a leitura dos dados com o banco de dados
            leitura.Close();
        }//Fim do PreencherVetor

        public string ConsultarTudo()
        {
            //Preencher o vetor
            PreencherVetor();
            msg = "";//Instanciando a variável
            for(i=0; i < contador; i++)
            {
                msg += $"\nCódigo: {codigo[i]} \nDescrição: {descricao[i]}\n";
            }//Fim do for
           
            //Mostrar todos os dados do banco de dados
            return msg;
        }//Fim do ConsultarTudo

        public string ConsultarPorCodigo(int codigo)
        {
            PreencherVetor();
            msg = "";
            for(i=0; i < contador; i++)
            {
                if (this.codigo[i] == codigo)
                {
                    msg = $"\nCódigo: {this.codigo[i]} \nDescrição: {descricao[i]}\n";
                    return msg;
                }//Fim do if
            }//Fim do for
            return "\n\nCódigo informado não foi encontrado!";
        }//Fim do ConsultarCodigo

        public string Atualizar(int codigo, string campo, string novoDado)
        {
            try
            {
                string query = $"update categoria set {campo} = '{novoDado}' where codigo = '{codigo}'";
                //Executar o comando
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + " dado atualizado com sucesso!";
            }
            catch(Exception erro) 
            {
                return $"\nAlgo deu errado!\n\n {erro}";
            }
        }//Fim do Atualizar
        
        public string Deletar(int codigo)
        {
            try
            {
                string query = $"delete from categoria where codigo = '{codigo}'";
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + " dado excluído com sucesso!";
            }
            catch(Exception erro)
            {
                return $"Algo deu errado\n\n {erro}";
            }
        }//Fim do Deletar
    }//fim da classe
}//fim do Projeto
