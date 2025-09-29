using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ControlLivro
    {
        //Variáveis que se conectam
        private Livro livro;
        private DAOLivro dao;

        public ControlLivro()
        {
            this.livro = new Livro();//Conecta as classes
        }//fim do construtor

        public ControlLivro(long ISBN, string titulo, 
                            DateTime ano, string editora, int categoriaCodigo)
        {
            this.dao = new DAOLivro();//Construtor vazio - Abertura de conexão com o BD
            dao.Inserir(ISBN, titulo, ano, editora, categoriaCodigo);//insere o dado no banco
        }//fim do construtor

        public void Imprimir()
        {
            this.dao = new DAOLivro();
            Console.WriteLine(this.dao.ConsultarTudoLivro());
        }//fim do método

        //Método Atualizar
        public void ConsultarPorCodigoLivro()
        {
            this.dao = new DAOLivro();
            //Pedindo para o usuário digitar
            Console.WriteLine("Informe o código que deseja buscar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            //Acionar o método ConsultarPorCodigo da DAO
            Console.WriteLine(this.dao.ConsultarPorCodigoLivro(codigo));
        }//Fim do método

        public void AtualizarLivro()
        {
            //Criar a instância do banco de dados
            this.dao = new DAOLivro();
            Console.WriteLine("Escolha o que deseja atualizar: " +
                              "\n1. ISBN" +
                              "\n2. Título" +
                              "\n3. Data" +
                              "\n4. Editora" +
                              "\n5. Código da Categoria");
            int escolha = Convert.ToInt32(Console.ReadLine());
            //Pequeno escolha
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("\nAtualizar ISBN");
                    Console.WriteLine("Informe o código de onde vai atualizar");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    //Nova descrição
                    Console.WriteLine("Informe o novo ISBN: ");
                    long ISBN = Convert.ToInt64(Console.ReadLine());
                    //Atualizar
                    Console.WriteLine(this.dao.AtualizarLivro(codigo, "ISBN", ISBN));
                    break;
                case 2:
                    Console.WriteLine("\nAtualizar Título");
                    Console.WriteLine("Informe o código de onde vai atualizar");
                    int codigo1 = Convert.ToInt32(Console.ReadLine());
                    //Nova descrição
                    Console.WriteLine("Informe o novo título: ");
                    string titulo = Console.ReadLine();
                    //Atualizar
                    Console.WriteLine(this.dao.AtualizarLivro(codigo1, "titulo", titulo));
                    break;
                case 3:
                    Console.WriteLine("\nAtualizar Data");
                    Console.WriteLine("Informe o código de onde vai atualizar");
                    int codigo2 = Convert.ToInt32(Console.ReadLine());
                    //Nova descrição
                    Console.WriteLine("Informe a nova data: ");
                    DateTime ano = Convert.ToDateTime(Console.ReadLine());
                    //Atualizar
                    Console.WriteLine(this.dao.AtualizarLivro(codigo2, "ano", ano));
                    break;
                case 4:
                    Console.WriteLine("\nAtualizar Editora");
                    Console.WriteLine("Informe o código de onde vai atualizar");
                    int codigo3 = Convert.ToInt32(Console.ReadLine());
                    //Nova descrição
                    Console.WriteLine("Informe a nova editora: ");
                    string editora = Console.ReadLine();
                    //Atualizar
                    Console.WriteLine(this.dao.AtualizarLivro(codigo3, "editora", editora));
                    break;
                case 5:
                    Console.WriteLine("\nAtualizar Código da Categoria");
                    Console.WriteLine("Informe o código de onde vai atualizar");
                    int codigo4 = Convert.ToInt32(Console.ReadLine());
                    //Nova descrição
                    Console.WriteLine("Informe o código da outra categoria: ");
                    int codigoCategoria = Convert.ToInt32(Console.ReadLine());
                    //Atualizar
                    Console.WriteLine(this.dao.AtualizarLivro(codigo4, "codigoCategoria", codigoCategoria));
                    break;
                default:
                    Console.WriteLine("Impossível atualizar, algo deu errado!");
                    break;
            }//Fim do switch
        }//fim do atualizar

        public void ExcluirLivro()
        {
            this.dao = new DAOLivro();

            Console.WriteLine("Informe o código que deseja excluir: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            //Chama o método para excluir
            Console.WriteLine(this.dao.DeletarLivro(codigo));
        }//Fim do ExluirLivro
    }//fim do classe
}//fim do projeto Biblioteca
