
namespace Matrizes
{
    internal class Exercicio1
    {
        public static void MetodoPrincipal()
        {
            Console.WriteLine("EXERCÍCIO 1:\n\nEnunciado: Neste exercício, forneça o tamanho de sua matriz e os números a serem inseridos nela, " +
                "após isso, o programa fará a soma de todos os termos da matriz.");

            Console.Write("Informe o número de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());

            Console.Write("Informe o número de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = LerMatriz(linhas, colunas);

            Console.WriteLine($"A soma de todos os elementos da matriz é: {SomaMatriz(matriz)}");
        }

        private static int[,] LerMatriz(int linhas, int colunas)
        {
            int[,] matriz = new int[linhas, colunas];

            string[] elementos;

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

            int contador = 0;

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matriz[i, j] = int.Parse(elementos[contador]);
                    contador++;
                }
            }

            return matriz;
        }

        private static int SomaMatriz(int[,] matriz)
        {
            return matriz.Cast<int>().Sum(); // Usando a função Sum para calcular a soma
        }
    }
}
