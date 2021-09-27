using System;
using System.Globalization;

namespace Exercicio3_Analise_Exploratoria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracao das Variaveis
            double[] dia = new double[30] { 22174.1664, 24537.6698, 26139.6134, 0.0, 0.0, 26742.6612, 0.0, 42889.2258, 46251.174, 11191.4722, 0.0, 0.0, 3847.4823, 373.7838, 2659.7563, 48924.2448, 18419.2614, 0.0, 0.0, 35240.1826, 43829.1667, 18235.6852, 4355.0662, 13327.1025, 0.0, 0.0, 25681.8318, 1718.1221, 13220.495, 8414.61};
            double soma = 0;
            double media = 0;
            double maiorValor = dia[0];
            double menorValor = dia[0];            
            int diasUteis = 0;
            int fatSupDiario = 0;

            //Informa ao usuario o objetivo do programa
            Console.WriteLine("Análise exploratória do faturamento diário!");

            //Laco de repeticao para calcular a soma, dias uteis, armazenar o maior e o menor valor
            for (int i = 0; i < dia.Length; i++)
            {
                if( dia[i] != 0)
                {
                    soma += dia[i];
                    diasUteis++;

                    //Armazena o maior valor
                    if (dia[i] > maiorValor)
                    {
                        maiorValor = dia[i];
                    }

                    //Armazena o menor valor
                    if (dia[i] < menorValor)
                    {
                        menorValor = dia[i];
                    }
                }
            }

            //Informa o valor da media mensal e o numero de dias considerados no calculo da media
            Console.WriteLine("");
            media = (soma / diasUteis);
            Console.WriteLine("Média Mensal: {0}", media.ToString("C", new CultureInfo("pt-br")) + ".");
            Console.WriteLine("Número de dias considerados no cálculo da média: {0}", diasUteis + ".");
            Console.WriteLine("");

            //Laco de repeticao para verificar a quantidade de dias com faturamento superior a media mensal
            for (int i = 0; i < dia.Length; i++)
            {
                if(dia[i] > media)
                {
                    fatSupDiario++;
                }
            }

            //Informa o menor vaor, maior valor e a quantidade de dias com faturamento superior a media mensal
            Console.WriteLine("");
            Console.WriteLine("Menor valor de faturamento: {0}", menorValor.ToString("C", new CultureInfo("pt-br")) + ".");
            Console.WriteLine("Maior valor de faturamento: {0}", maiorValor.ToString("C", new CultureInfo("pt-br")) + ".");
            Console.WriteLine("Número de dias com faturamento superior à média mensal: {0}", fatSupDiario + ".");
        }
    }
}
