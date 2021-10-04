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
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

             
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                    
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab,posicoesPossiveis);

                Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem,destino);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            Console.ReadLine();
        }
    }
}
