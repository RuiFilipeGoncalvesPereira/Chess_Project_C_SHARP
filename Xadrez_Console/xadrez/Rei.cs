using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Console.Tabuleiro;
using Tabuleiro;
using System.Net.Http.Headers;

namespace Xadrez_Console.xadrez
{
    class Rei : Peca
    {
        private PartidaDeXadrez partida;
        public Rei(tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        {
            this.partida = partida;
        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        private bool testeTorreParaRoque(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null && p is Torre && p.cor == cor && p.qteMovimentos == 0;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.definirValores(posicao.Linha - 1, posicao.Coluna);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //ne
            pos.definirValores(posicao.Linha - 1, posicao.Coluna +1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //direita
            pos.definirValores(posicao.Linha, posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }


            //se
            pos.definirValores(posicao.Linha + 1, posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //abaixo
            pos.definirValores(posicao.Linha + 1, posicao.Coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //so
            pos.definirValores(posicao.Linha + 1, posicao.Coluna -1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //esquerda
            pos.definirValores(posicao.Linha, posicao.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //no
            pos.definirValores(posicao.Linha -1, posicao.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //# jogadaespecial roque pequeno
            if(qteMovimentos==0 && !partida.xeque)
            {
                Posicao posT1 = new Posicao(posicao.Linha, posicao.Coluna + 3); // torre
                if (testeTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(posicao.Linha, posicao.Coluna + 1);
                    Posicao p2 = new Posicao(posicao.Linha, posicao.Coluna + 2);
                    if(tab.peca(p1)== null && tab.peca(p2) == null)
                    {
                        mat[posicao.Linha, posicao.Coluna + 2] = true;
                    }
                }
            }

            //# jogadaespecial roque grande
            Posicao posT2 = new Posicao(posicao.Linha, posicao.Coluna - 4); // torre
             if (testeTorreParaRoque(posT2))
              {
                Posicao p1 = new Posicao(posicao.Linha, posicao.Coluna - 1); // Rei
                Posicao p2 = new Posicao(posicao.Linha, posicao.Coluna - 2); //Rei
                Posicao p3 = new Posicao(posicao.Linha, posicao.Coluna - 3); //Rei
                if (tab.peca(p1) == null && tab.peca(p2) == null && tab.peca(p3) == null)
                 {
                     mat[posicao.Linha, posicao.Coluna - 2] = true;
                }
              }

            return mat;

        }


    }
}
