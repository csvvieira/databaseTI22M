using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ControlCategoria
    {
        private Categoria categoria;

        public ControlCategoria()
        {
            categoria = new Categoria();
        }//fim do construtor

        public ControlCategoria(int codigo, string descricao)
        {
            categoria = new Categoria(codigo, descricao);
        }//fim do construtor

        public void Imprimir()
        {
            Console.WriteLine(categoria.Imprimir());
        }//fim do imprimir
    }//fim da classe
}//fim do projeto
