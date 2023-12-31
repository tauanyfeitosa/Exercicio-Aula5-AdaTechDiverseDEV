﻿namespace Matrizes
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Informe abaixo qual atividade deseja acessar:\n");

                string[] exercicios = {
                "Soma de Elementos de Matriz de Inteiros",
                "Matriz Identidade",
                "Multiplicação de Matrizes",
                "Soma de linhas e colunas em matrizes"
            };

                int escolhaUsuario = ObterEscolhaUsuario(exercicios);
                if (escolhaUsuario == 5) break;
                SelecionarExercicio(escolhaUsuario);

            }
            
        }

        private static int ObterEscolhaUsuario(string[] exercicios)
        {
            for (int i = 0; i < exercicios.Length; i++) Console.WriteLine($"{i+1} - {exercicios[i]}");
            Console.WriteLine($"{exercicios.Length+1} - Sair");
            int escolha;

            do
            {
                Console.WriteLine("\nSelecione dentre os números acima, não utlize caracteres fora do escopo.");
            } while (!int.TryParse(Console.ReadLine(), out escolha) ||escolha < 1 || escolha > exercicios.Length+1 );

            return escolha;
        }

        private static void SelecionarExercicio (int escolha)
        {
            switch (escolha)
            {
                case 1:
                    Exercicio1.MetodoPrincipal();
                    break;
                case 2:
                    Exercicio2.MetodoPrincipal();
                    break;
                case 3:
                    Exercicio3.MetodoPrincipal();
                    break;
                case 4:
                    Exercicio4.MetodoPrincipal();
                    break;
            }
        }
    }

}
