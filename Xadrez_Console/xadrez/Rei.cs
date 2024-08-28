using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Console.Tabuleiro;
using Tabuleiro;

namespace Xadrez_Console.xadrez
{
    class Rei : Peca
    {
         public Rei(tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }

    }
}
