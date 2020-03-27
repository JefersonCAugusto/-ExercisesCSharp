using System;
using Exercicio2.Entities;
namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //dois comentários
            Comment c1 = new Comment("Que legal!!");
            Comment c2 = new Comment("Bacana, divirta-se!!!");


            Post p1 = new Post(DateTime.Parse("12/12/2020 12:32:38"),
                "viajando para nova zelândia",
                12, "Vou visitar o pais mais maravilhoso");
            p1.AddComent(c1);
            p1.AddComent(c2);



        }
    }
}
