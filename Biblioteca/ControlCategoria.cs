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
        private DAOCategoria dao;

        public ControlCategoria()
        {
            categoria = new Categoria();
        }//fim do construtor

        public ControlCategoria(string descricao)
        {
            this.dao = new DAOCategoria();
            this.dao.Inserir(descricao);
        }//fim do construtor

        //Método que realiza o consultar tudo
        public void Imprimir()
        {
            this.dao = new DAOCategoria();
            Console.WriteLine(this.dao.ConsultarTudo());
        }//fim do imprimir

        //Método para consulta por código
        public void ConsultarPorCodigo()
        {
            this.dao = new DAOCategoria();
            //Pedindo para o usuário digitar
            Console.WriteLine("Informe o código que deseja buscar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            //Acionar o método ConsultarPorCodigo da DAO
            Console.WriteLine(this.dao.ConsultarPorCodigo(codigo));
        }//Fim do método

        public void Atualizar()
        {
            //Criar a instância do banco de dados
            this.dao = new DAOCategoria();
            Console.WriteLine("Escolha o que deseja atualizar: " +
                              "\n1. Descrição");
            int escolha = Convert.ToInt32(Console.ReadLine());
            //Pequeno escolha
            switch(escolha)
            {
                case 1:
                    Console.WriteLine("\nAtualizar descrição");
                    Console.WriteLine("Informe o código de onde vai atualizar");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    //Nova descrição
                    Console.WriteLine("Informe a nova descrição: ");
                    string descricao = Console.ReadLine();
                    //Atualizar
                    Console.WriteLine(this.dao.Atualizar(codigo, "descricao", descricao));
                    break;
                default:
                    Console.WriteLine("Impossível atualizar, algo deu errado!");
                    break;
            }//Fim do switch
        }//fim do atualizar

        public void Excluir()
        {
            this.dao = new DAOCategoria();

            Console.WriteLine("Informe o código que deseja excluir: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            //Chama o método para excluir
            Console.WriteLine(this.dao.Deletar(codigo));
        }//Fim do Excluir
    }//fim da classe
}//fim do projeto
