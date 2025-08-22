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

        public ControlLivro()
        {
            this.livro = new Livro();//Conecta as classes
        }//fim do construtor

        public ControlLivro(int codigo, long ISBN, string titulo, 
                            DateTime ano, string editora, int codigoCategoria)
        {
            this.livro = new Livro(codigo, ISBN, titulo, ano, editora, codigoCategoria);
        }//fim do construtor

        public void Imprimir()
        {
            Console.WriteLine(this.livro.Imprimir());
        }//fim do método

        //Método Atualizar
        public void Atualizar(int opcao, string dado)
        {
            switch (opcao)
            {
                case 1:
                    this.livro.ModificarTitulo = dado;
                    Console.WriteLine("Dado Atualizado com sucesso!");
                    break;
                case 2:
                    this.livro.ModificarData = Convert.ToDateTime(dado);
                    Console.WriteLine("Dado Atualizado com sucesso!");
                    break;
                case 3:
                    this.livro.ModificarEditora = dado;
                    Console.WriteLine("Dado Atualizado com sucesso!");
                    break;
                case 4:
                    this.livro.ModificarCodigoCategoria = Convert.ToInt32(dado);
                    Console.WriteLine("Dado Atualizado com sucesso!");
                    break;
                default:
                    Console.WriteLine("Não é possível atualizar esse dado! Código Errado!");
                    break;
            }//fim do switch
        }//fim do método
    }//fim do classe
}//fim do projeto Biblioteca
