using System;

namespace Exercicio1_Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mensagem ao Usuario
            Console.WriteLine("Calculando a Soma... Aguarde por favor!");

            //Declaração das variaveis
            int Indice = 13;
            int Soma = 0;
            int k = 0;

            //Laco de repeticao para calcular a soma
            while (k < Indice)
            {
                k = k + 1;
                Soma = Soma + k;
            }

            //Exibe o resultado para o usuario
            Console.WriteLine("O Resultado da Soma é: {0}", Soma);
        }
    }
}
