
namespace Matrizes
{
    internal class Exercicio3
    {
        internal static void MetodoPrincipal()
        {
            Console.WriteLine("EXERCÍCIO 3:\n\nEnunciado: Neste exercício, forneça duas matrizes. O programa retornará a " +
                "multiplicação entre elas.");

            Console.Write("Informe o número de linhas da matriz 1: ");
            int linhas = int.Parse(Console.ReadLine());

            Console.Write("Informe o número de colunas da matriz 2: ");
            int colunas = int.Parse(Console.ReadLine());

            // Inicializando a matriz com os valores fornecidos pelo usuário
            int[,] matrizA = new int[linhas, colunas];

            Console.WriteLine("Digite os elementos da matriz:");

            // Preenchendo a matriz com os valores fornecidos pelo usuário
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Matriz[{i + 1},{j + 1}]: ");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Informe o número de linhas da matriz 1: ");
            int linhas2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o número de colunas da matriz 2: ");
            int colunas2 = int.Parse(Console.ReadLine());

            // Inicializando a matriz com os valores fornecidos pelo usuário
            int[,] matrizB = new int[linhas, colunas];

            Console.WriteLine("Digite os elementos da matriz:");

            // Preenchendo a matriz com os valores fornecidos pelo usuário
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Matriz[{i + 1},{j + 1}]: ");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz A:");
            ImprimirMatriz(matrizA);

            Console.WriteLine("\nMatriz B:");
            ImprimirMatriz(matrizB);

            if (MatrizesSaoCompativeisParaMultiplicacao(matrizA, matrizB))
            {
                int[,] resultado = MultiplicarMatrizes(matrizA, matrizB);

                Console.WriteLine("\nResultado da Multiplicação:");
                ImprimirMatriz(resultado);
            }
            else
            {
                Console.WriteLine("\nAs matrizes não são compatíveis para multiplicação.");
            }
        }

        static bool MatrizesSaoCompativeisParaMultiplicacao(int[,] matrizA, int[,] matrizB)
        {
            int colunasA = matrizA.GetLength(1);
            int linhasB = matrizB.GetLength(0);

            return colunasA == linhasB;
        }

        static int[,] MultiplicarMatrizes(int[,] matrizA, int[,] matrizB)
        {
            int linhasA = matrizA.GetLength(0);
            int colunasA = matrizA.GetLength(1);
            int linhasB = matrizB.GetLength(0);
            int colunasB = matrizB.GetLength(1);

            int[,] resultado = new int[linhasA, colunasB];

            for (int i = 0; i < linhasA; i++)
            {
                for (int j = 0; j < colunasB; j++)
                {
                    for (int k = 0; k < colunasA; k++)
                    {
                        resultado[i, j] += matrizA[i, k] * matrizB[k, j];
                    }
                }
            }

            return resultado;
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
