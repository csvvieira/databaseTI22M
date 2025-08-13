using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {       
        static void Main(string[] args)
        {
            //Testar
            Console.Write("Informe seu nome: ");//Escreva
            //Declaração Local de Variáveis
            string nome = Console.ReadLine();//Coletando o que o usuário está digitando
            //Mostrar na tela
            Console.WriteLine("\n\n\n\nBem - Vindo(a) " + nome);


            Console.ReadLine();//Leia - Manter a tela aberta(Por enquanto)
        }//Fim do método
    }//Fim da classe
}//Fim do projeto
