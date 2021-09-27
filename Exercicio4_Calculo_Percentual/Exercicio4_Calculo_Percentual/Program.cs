using System;
using System.Globalization;

namespace Exercicio4_Calculo_Percentual
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracao das variaveis
            string[,] Estados = new string[5,3];
            int i,j;
            double soma = 0;
            double percentual;
            double fatEstado;

            //Populando a matriz com as informacoes necessarias
            Estados[0, 0] = "SP";
            Estados[0, 1] = "67836.43";
            Estados[0, 2] = "";
            Estados[1, 0] = "RJ";
            Estados[1, 1] = "36678.66";
            Estados[1, 2] = "";
            Estados[2, 0] = "MG";
            Estados[2, 1] = "29229.88";
            Estados[2, 2] = "";
            Estados[3, 0] = "ES";
            Estados[3, 1] = "27165.48";
            Estados[3, 2] = "";
            Estados[4, 0] = "Outros";
            Estados[4, 1] = "19849.53";
            Estados[4, 2] = "";

            //Informa ao usuraio o proposito do programa
            Console.WriteLine("Cálculo do Percentual do Faturamento por Estado!");

            Console.WriteLine("");

            //Laco de repeticao para calcular o percentual
            for (i = 0; i < 5; i++)
            {
                soma += Convert.ToDouble(Estados[i, 1]);
            }

            //Mostra a soma total do Faturamento
            Console.WriteLine("Soma total do Faturamento: {0}", soma.ToString("C", new CultureInfo("pt-br")));

            Console.WriteLine("");

            //Laco de repeticao para mostrar os percentuais por Estado
            for (i = 0; i < 5; i++)
            {
                for(j = 0; j < 1; j++)
                {
                    //Calcula o percentual de cada Estado e arredonda o valor para 2 casas decimais
                    percentual = Math.Round((Convert.ToDouble(Estados[i,1]) / soma) * 100, 2);

                    //Armazena o percentual na posicao correta da matriz em cada Estado
                    Estados[i,2] = Convert.ToString(percentual);

                    //Converte o valor apra Double para ser formatado como moeda posteriormente
                    fatEstado = Convert.ToDouble(Estados[i, 1]);

                    //Mostra ao usuario o percentual de cada Estado.
                    Console.WriteLine(Estados[i,0] + ", Faturamento Mensal: " + fatEstado.ToString("C", new CultureInfo("pt-br")) + ", Percentual: " + Estados[i,2] + "%.");
                }                
            }
        }
    }
}
