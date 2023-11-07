using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha) 
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        /// <summary>
        /// LINHA Como linha é igual a 1, a primeira parte da conta será 8 - 1, que é igual a 7. 
        /// Isso representa o número da linha em uma matriz bidimensional, onde as linhas são numeradas de 0 a 7.
        /// 
        ///COLUNA - 'a': Neste caso, coluna é 'c' e 'a' é o caractere 'a'.
        ///Os valores ASCII de 'c' e 'a' são 99 e 97, respectivamente.Portanto,
        ///a segunda parte da conta será 99 - 97, que é igual a 2. Isso representa
        ///o índice da coluna em uma matriz bidimensional, onde as colunas são numeradas de 0 a 7,
        ///da esquerda para a direita.
        /// </summary>
        /// <returns></returns>
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return $"{coluna}{linha}";
        }
    }
}
