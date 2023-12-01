
namespace Matrizes
{
    internal class Exercicio2
    {
        internal static void MetodoPrincipal()
        {
            Console.WriteLine("EXERCÍCIO 2:\n\nEnunciado: Neste exercício, forneça o tamanho de sua matriz e os números a serem inseridos nela, " +
                "após isso, o programa identificará se a matriz é do tipo identidade ou não.");

            Console.Write("Informe o número de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());

            Console.Write("Informe o número de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine());

            LerMatriz(linhas, colunas);
        }

        private static void LerMatriz(int linhas, int colunas)
        {
            int[,] matriz = new int[linhas, colunas];

            string[] elementos;

            bool verificador = true;

            if (linhas != colunas)
            {
                verificador = false;
            } else
            {
                while (true)
                {
                    Console.WriteLine("\n\nInforme abaixo os números que deseja inserir na matriz com um espaço.");

                    elementos = Console.ReadLine().Split(" ");

                    if (elementos.Length == linhas * colunas)
                    {
                        bool analise = true;
                        foreach (string str in elementos)
                        {
                            if (!int.TryParse(str, out int contadorvariavel))
                            {
                                analise = false;
                                break;
                            }
                        }

                        if (analise)
                        {
                            int contador = 0;

                            for (int i = 0; i < linhas; i++)
                            {
                                for (int j = 0; j < colunas; j++)
                                {
                                    matriz[i, j] = int.Parse(elementos[contador]);
                                    contador++;
                                }
                            }

                            ImprimirMatriz(matriz, linhas, colunas);

                            Verificador(MatrizIdentidade(matriz, linhas, colunas, verificador));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nA entrada fornecida não é formada apenas por números!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nO tamanho não corresponde ao tamanho da matriz informada!");
                    }
                }
            }

        }

        private static void Verificador(bool verificador)
        {
            if (verificador)
            {
                Console.WriteLine("A matriz acima é uma matriz identidade");
            } else
            {
                Console.WriteLine("A matriz informada não é uma matriz identidade");
            }
        }

        private static bool MatrizIdentidade(int[,] matriz, int linhas, int colunas, bool verificador)
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    int elemento = matriz[i, j];

                    if (i == j)
                    {
                        // Elementos na diagonal principal devem ser 1
                        if (elemento != 1)
                        {
                            verificador = false;
                            return verificador;
                        }
                    }
                    else
                    {
                        // Elementos fora da diagonal principal devem ser 0
                        if (elemento != 0)
                        {
                            verificador = false;
                            return verificador;
                        }
                    }
                }
            }

            return verificador;
        }

        private static void ImprimirMatriz(int[,] matriz, int linhas, int colunas)
        {
            Console.WriteLine("Matriz:");

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
