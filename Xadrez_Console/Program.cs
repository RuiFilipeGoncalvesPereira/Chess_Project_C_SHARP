using Tabuleiro;
using System;



namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Posicao P;
             P = new Posicao(3, 4);
             Console.WriteLine("Posição: " + P);
             Console.ReadLine();*/

            tabuleiro tab = new tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);




            Console.ReadLine();
            

        }
    }
}