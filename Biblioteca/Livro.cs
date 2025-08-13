using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Livro
    {
        //Variável Global
        //Encapsulamento
        private int codigo;
        private long ISBN;
        private string titulo;
        private DateTime anoLancamento;
        private string editora;
        private int codigoCategoria;

        //Primeiro Grande Método - Método Construtor
        //Instancia as variáveis na memória do equipamento
        public Livro()
        {
            ModificarCodigo = 0;
            ModificarISBN = 0;
            ModificarTitulo = "";
            ModificarData = new DateTime();
            ModificarEditora = "";
            ModificarCodigoCategoria = 0;
        }//Fim do construtor

        public Livro(int codigo, long ISBN, string titulo, 
                     DateTime anoLancamento,string editora, int codigoCategoria)
        {
            ModificarCodigo          = codigo;
            ModificarISBN            = ISBN;
            ModificarTitulo          = titulo;
            ModificarData            = anoLancamento;
            ModificarEditora         = editora;
            ModificarCodigoCategoria = codigoCategoria;
        }//Fim do construtor

        //Métodos GETs e SETs
        //Métodos de acesso e modificação
        public int ModificarCodigo
        {
            get
            {
                return this.codigo;
            }//fim do get
            set
            {
                this.codigo = value;
            }//fim do set
        }//fim do modificarCodigo

        public long ModificarISBN
        {
            get { return this.ISBN; }
            set { this.ISBN = value; }
        }//fim do ModificarISBN

        public string ModificarTitulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }//fim do ModificarTitulo

        public DateTime ModificarData
        {
            get { return this.anoLancamento; }
            set { this.anoLancamento = value;}
        }//fim do método

        public string ModificarEditora
        {
            get { return this.editora; }
            set { this.editora = value; }
        }//fim do método

        public int ModificarCodigoCategoria
        {
            get { return this.codigoCategoria;}
            set { this.codigoCategoria = value; }
        }//fim do método

        public string Imprimir()
        {
            return "\nCódigo: "    + ModificarCodigo  +
                   "\nISBN: "      + ModificarISBN    +
                   "\nTitulo: "    + ModificarTitulo  +
                   "\nData: "      + ModificarData    +
                   "\nEditora: "   + ModificarEditora +
                   "\nCategoria: " + ModificarCodigoCategoria;
        }//fim do imprimir








    }//fim da classe
}//fim do projeto
