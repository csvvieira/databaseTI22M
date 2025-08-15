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
            livro = new Livro();//Conecta as classes
        }//fim do construtor

        public ControlLivro(int codigo, long ISBN, string titulo, 
                            DateTime ano, string editora, int codigoCategoria)
        {
            livro = new Livro(codigo, ISBN, titulo, ano, editora, codigoCategoria);
        }//fim do construtor

        public void Imprimir()
        {
            Console.WriteLine(livro.Imprimir());
        }//fim do método
    }//fim do classe
}//fim do projeto Biblioteca
