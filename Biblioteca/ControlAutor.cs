using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ControlAutor
    {
        private Autor autor;

        public ControlAutor()
        {
            autor = new Autor();
        }//fim do construtor

        public ControlAutor(int codigo, string nome, string nacionalidade)
        {
            autor = new Autor(codigo, nome, nacionalidade);
        }//fim do construtor

        public void Imprimir()
        {
            Console.WriteLine(autor.Imprimir());
        }//fim do imprimir
    }//fim da classe
}//fim do projeto
