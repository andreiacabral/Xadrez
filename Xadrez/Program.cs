using System;
using TabuleiroXadrez;
using Xadrez.Pecas;
using Xadrez.TabuleiroXadrez;


namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());
            
            ////
            //Tabuleiro tab = new Tabuleiro(8, 8);

            //tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //tab.colocarPeca(new Torre(tab, Cor.Preta),new Posicao(1, 3));
            //tab.colocarPeca(new Rei(tab, Cor.Preta),new Posicao(2, 4));



            //Tela.ImprimirTabuleiro(tab);


            Console.ReadLine();
        }
    }
}
