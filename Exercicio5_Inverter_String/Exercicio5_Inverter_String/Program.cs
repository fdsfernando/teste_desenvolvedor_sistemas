using System;

namespace Exercicio5_Inverter_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracao das variaveis
            string frase, fraseInvertida = "";
            int tamanho = 0;
            int i;

            //Informa ao usuario o proposito do programa
            Console.WriteLine("Programa para inverter uma String!");
            Console.WriteLine("");
            //Solicita ao usuario para digitar uma string
            Console.WriteLine("Digite uma String:");
            //Armazena a string digitada
            frase = Console.ReadLine();

            //Armazena o tamanho da string
            tamanho = frase.Length;           

            //Laco de repeticão para percorrer a string digitada e armazenar a string invertida
            for(i = (tamanho - 1); i >= 0; i--)
            {
                fraseInvertida += frase[i];
            }

            //Mostra ao usuario a string digitada e a string invertida
            Console.WriteLine("String original: {0}", frase);
            Console.WriteLine("");
            Console.WriteLine("String invertida: {0}", fraseInvertida);
        }
    }
}
