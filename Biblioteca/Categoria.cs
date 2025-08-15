using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Categoria
    {
        //Declarei as variáveis
        private int codigo;
        private string descricao;

        public Categoria()
        {
            this.codigo = 0;
            this.descricao = "";
        }//fim do contrutor

        public Categoria(int codigo, string descricao)
        {
            this.codigo = codigo;
            this.descricao = descricao;
        }//fim do Contrutor categoria
        
        //Métodos GETS e SETS
        public int ModificarCodigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }//fim do ModificarCodigo

        public string ModificarDescricao
        {
            get { return this.descricao; }
            set { this.descricao = value;}
        }//fim do ModificarDescricao

        public string Imprimir()
        {
            return "\nCódigo: "    + ModificarCodigo     +
                   "\nDescrição: " + ModificarDescricao;
        }//fim do imprimir
    }//fim da Classe
}//fim da projeto
