using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Autor
    {
        //Declaração de variáveis
        private int codigo;
        private string nome;
        private string nacionalidade;

        public Autor()
        {
            this.codigo = 0;
            this.nome = "";
            this.nacionalidade = "";
        }//fim do construtor

        public Autor(int codigo, string nome, string nacionalidade)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.nacionalidade = nacionalidade;
        }//fim do construtor

        //Métodos GETS e SETS
        public int ModificarCodigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }//fim do modificarCodigo

        public string ModificarNome
        { 
            get { return this.nome; } 
            set { this.nome = value; }
        }//fim do ModificarNome

        public string ModificarNacionalidade
        {
            get { return this.nacionalidade; }
            set { this.nacionalidade = value; }
        }//fim do ModificarNacionalidade

        public string Imprimir()
        {
            return "\nCódigo: " + ModificarCodigo +
                   "\nNome: " + ModificarNome +
                   "\nNacionalidade: " + ModificarNacionalidade;
        }//fim do Imprimir
    }//fim da classe
}//fim do projeto
