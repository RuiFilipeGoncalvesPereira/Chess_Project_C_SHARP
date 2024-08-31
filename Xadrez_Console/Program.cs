using Tabuleiro;
using System;
using System.Data.Common;
using Xadrez_Console.Tabuleiro;
using Xadrez_Console.xadrez;
using xadrez;



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
            try
             {
                //tabuleiro tab = new tabuleiro(8, 8); // classe peça é instanciada para que a funçãp coloca peça coloque peças no tabuleiro 

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimentos(origem, destino);
                }




            }
            catch(TabuleiroException e)
             {
                 Console.WriteLine(e.Message);
             }

            /*PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();*/
            

        }
    }
}