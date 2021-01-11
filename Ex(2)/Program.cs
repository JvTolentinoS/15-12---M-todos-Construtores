using System;
using Ex2.classes;

namespace Ex_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos produtos1 = new Produtos();
            produtos1.Codigo = 1;
            produtos1.Nome = "Refrigerante";
            produtos1.Descricao = "Refrigerante Zero 1L";
            produtos1.Estoque = 30;

            Console.WriteLine($"Produto 1 Código {produtos1.Codigo}, nome {produtos1.Nome}, Descrição {produtos1.Descricao}, Estoque {produtos1.Estoque}.");
            
            Produtos produtos2 = new Produtos();
            produtos2.Nome = "Suco";
            Console.WriteLine($"Codigo inserido {produtos2.Codigo}, nome {produtos2.Nome}");

            Produtos produtos3 = new Produtos(1, "Leite", "Desnatado", 100);
            Console.WriteLine($"Código {produtos3.Codigo}, nome {produtos3.Nome}, descrição {produtos3.Descricao} e estoque {produtos3.Estoque}.");
            
            
        }
    }
}
