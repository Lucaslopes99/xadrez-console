using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace tabuleiro
{
    class Peca
    {
        public Cor CorPeca { get; set; }
        public Posicao Posicao { get; set; }
        public int QtdMovimentos { get; set; }
        public Tabuleiro Tab { get; set; }

        public Peca (Posicao posicao, Tabuleiro tab, Cor corPeca)
        {
            Posicao = posicao;
            Tab = tab;
            CorPeca = CorPeca;
            QtdMovimentos = 0;
        }
    }
}
