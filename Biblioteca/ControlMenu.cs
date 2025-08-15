using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ControlMenu
    {
        //Declarar a Variável que representará as classes control
        private ControlLivro controleLivro;
        private int opcaoPrincipal;
        private int opcaoGeral;

        public ControlMenu()
        {
            controleLivro = new ControlLivro();
        }//fim do construtor

        //Métodos GETs e SETs
        public int ModificarOpcaoPrincipal
        {
            get { return opcaoPrincipal; }
            set { opcaoPrincipal = value; }
        }//fim do método

        public int ModificarOpcaoGeral
        {
            get { return opcaoGeral;}
            set { opcaoGeral = value; }
        }//fim do getSet

        //Mostrar Menu
        public void MostrarMenu()
        {
            Console.WriteLine("\n\n Menu \n\n"                  + 
                              "Escolha uma das opções abaixo: " +
                              "\n0. Sair"                       +
                              "\n1. Livro"                      +
                              "\n2. Autor"                      +
                              "\n3. Categoria");
            ModificarOpcaoPrincipal = Convert.ToInt32(Console.ReadLine());
        }//fim do método

        public void ExecutarMenuPrincipal()
        {
            //Mostrar Menu - Chamar o método do menu
            do
            {
                MostrarMenu();
                switch (ModificarOpcaoPrincipal)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;//fim de cada caso
                    case 1:
                        Console.WriteLine("Livro");
                        break;
                    case 2:
                        Console.WriteLine("Autor");
                        break;
                    case 3:
                        Console.WriteLine("Categoria");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }//fim do escolha
            } while (ModificarOpcaoPrincipal != 0);//fim do while
        }//fim do executar

        public void MenuGeral()
        {
            Console.WriteLine("\n\n Escolha uma das ações do CRUD" +
                             "\n0. Sair" +
                             "\n1. Cadastrar" +
                             "\n2. Consultar" +
                             "\n3. Atualizar" +
                             "\n4. Excluir");
            ModificarOpcaoGeral = Convert.ToInt32(Console.ReadLine());//Coleto a opção do usuário
        }//fim do método

        public void ExecutarLivro()
        {
            MenuGeral();//Escolher a opção correta
            switch(ModificarOpcaoGeral)
            {
                case 0:
                    Console.WriteLine("Obrigado - Livro");
                    break;
                case 1:
                    Console.WriteLine("\nCadastrar\n");
                    //Pegar os dados do livro
                    Console.WriteLine("\nInforme o código do livro: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nInforme o ISBN do livro: ");
                    long ISBN = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("\nInforme o Título do livro: ");
                    string titulo = Console.ReadLine();

                    Console.WriteLine("\nInforme o Ano de Lançamento do Livro: ");
                    DateTime ano = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("\nInforme a Editora do Livro: ");
                    string editora = Console.ReadLine();

                    Console.WriteLine("\nInforme a Categoria do Livro: ");
                    int codigoCategoria = Convert.ToInt32(Console.ReadLine());
                    //Chamar o livro
                    ControlLivro livro = new ControlLivro(codigo, ISBN, titulo, ano, editora, codigoCategoria);
                    //Finaliza
                    break;
                case 2:

            }//fim do switch
        }//fim do método ExecutarLivro
    }//fim da classe
}//fim do Projeto
