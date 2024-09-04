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
                    try
                    {
                        Console.Clear();
                        //Tela.imprimirTabuleiro(partida.tab);
                        Tela.imprimirPatida(partida);
                        Console.WriteLine();
                        //Console.WriteLine("Turno: " + partida.turno);
                        //Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoOrigem(origem);


                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDestino(origem, destino);


                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
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