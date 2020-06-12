using System;

namespace Aula16MetodoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
        //Instância sem argumentos
           Produto sapato = new Produto();
           sapato.Nome = "Vizzano.";
           sapato.Descricao = "O sapato é da cor vermelha.";
           sapato.Estoque = 300;
           System.Console.WriteLine("O nome do sapato é:\n"+sapato.Nome);
           System.Console.WriteLine("Descrição do produto:\n"+sapato.Descricao);
           System.Console.WriteLine("Quantidade no estoque:\n"+sapato.Estoque);
           
        //Instância com um argumento
           Produto chinelo = new Produto(35788);
           System.Console.WriteLine("O código do chinelo é: "+chinelo.Codigo);
        //Instância com todos os atriburotos, com argumentos
           Produto camisa = new Produto(3787874, "Nike", "preta", 800);
           System.Console.WriteLine("O código ca camiseta é :"+camisa.Codigo);
           System.Console.WriteLine("A marca da camiseta é :" +camisa.Nome);
           System.Console.WriteLine("A cor da camiseta é " +camisa.Descricao);
           System.Console.WriteLine("Quantidade no estoque: " +camisa.Estoque);

        }
    }
}
