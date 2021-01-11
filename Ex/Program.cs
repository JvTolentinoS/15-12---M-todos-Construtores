using System;
using _15_12___M_todos_Construtores.classes;

namespace _15_12___M_todos_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine($"Digite seu sobrenome");
            string sobreNome = Console.ReadLine();
            
            Pessoa pessoa = new Pessoa(nome, sobreNome);

        }
    }
}
