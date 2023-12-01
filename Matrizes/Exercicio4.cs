using System;

namespace Matrizes
{
    internal class Exercicio4
    {
        internal static void MetodoPrincipal()
        {
            Console.WriteLine("EXERCÍCIO 4:\n\nEnunciado: Neste exercício, forneça o tamanho de sua matriz e os números a serem inseridos nela, " +
                "após isso, o programa retornará a soma das linhas e das colunas.");

            // Solicitando o tamanho da matriz do usuário
            Console.Write("Digite o número de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine());

            // Inicializando a matriz com os valores fornecidos pelo usuário
            int[,] matriz = new int[linhas, colunas];

            Console.WriteLine("Digite os elementos da matriz:");

            // Preenchendo a matriz com os valores fornecidos pelo usuário
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Matriz[{i + 1},{j + 1}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Chamando a função para calcular as somas
            int[] somasLinhas = CalcularSomasLinhas(matriz);
            int[] somasColunas = CalcularSomasColunas(matriz);

            // Exibindo os resultados
            Console.WriteLine("Somas das Linhas:");
            ImprimirArray(somasLinhas);

            Console.WriteLine("\nSomas das Colunas:");
            ImprimirArray(somasColunas);
        }

        private static int[] CalcularSomasLinhas(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            int[] somasLinhas = new int[linhas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    somasLinhas[i] += matriz[i, j];
                }
            }

            return somasLinhas;
        }

        private static int[] CalcularSomasColunas(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            int[] somasColunas = new int[colunas];

            for (int j = 0; j < colunas; j++)
            {
                for (int i = 0; i < linhas; i++)
                {
                    somasColunas[j] += matriz[i, j];
                }
            }

            return somasColunas;
        }

        private static void ImprimirArray(int[] array)
        {
            foreach (var elemento in array)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }
    }
}
