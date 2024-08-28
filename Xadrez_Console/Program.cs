using Tabuleiro;
using System;
using System.Data.Common;
using Xadrez_Console.Tabuleiro;
using Xadrez_Console.xadrez;



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

            tabuleiro tab = new tabuleiro(8, 8); // classe peça é instanciada para que a funçãp coloca peça coloque peças no tabuleiro 

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1,3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2,4));


            Tela.imprimirTabuleiro(tab);


            Console.ReadLine();
            

        }
    }
}