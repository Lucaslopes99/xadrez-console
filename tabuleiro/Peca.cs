using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace tabuleiro
{
    class Peca
    {
        public Cor CorPeca { get; protected set; }
        public Posicao Posicao { get; set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca (Tabuleiro tab, Cor corPeca)
        {
            Posicao = null;
            Tab = tab;
            CorPeca = corPeca;
            QtdMovimentos = 0;
        }
    }
}
