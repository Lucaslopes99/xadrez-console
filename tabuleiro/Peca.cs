using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace tabuleiro
{
    abstract class Peca
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

        public void IncromentarQtdMovimentos()
        {
            QtdMovimentos++;
        }

        public void DecrementarQtdMovimentos()
        {
            QtdMovimentos--;
        }

        public bool ExisteMovimentoPossivel()
        {
            bool[,] mat = MovimentosPossiveis();
            for(int i = 0; i <Tab.Linha; i++)
            {
                for(int j = 0; j <Tab.Coluna; j++)
                {
                    if(mat[i,j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool MovimentoPossivel(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }
        public abstract bool[,] MovimentosPossiveis();
        

        
    }
}
