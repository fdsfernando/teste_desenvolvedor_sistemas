using System;

namespace Exercicio2_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracao das Variaveis
            int valor;
            int numAnterior, numAtual = 0;            
            int numProximo = 1;
            int indice;
            bool numEncontrado = false;

            //Informa ao usuario o proposito do programa
            Console.WriteLine("..........Sequência Fibonacci..........");
            Console.WriteLine("Digite um numero para verificar se existe na Sequência Fibonacci:");
            valor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            //Laco de repeticao para calcular os numeros da sequência Fibonacci
            do{
                //Mostra na tela o numero atual da sequencia
                Console.WriteLine("Numero Sequência Fibonacci: {0}", numAtual);

                //verifica se o numero digitado pertence a sequencia
                if(valor == numAtual)
                {
                    numEncontrado = true;
                }

                //Manipulacao das variaveis para calcular o proximo numero da sequencia
                numAnterior = numAtual;
                numAtual = numProximo;
                numProximo = numAnterior + numAtual;                
            }while(valor > numAtual);

            Console.WriteLine("");
            
            //Informa se o numero digitado existe ou nao na sequencia para o usuario
            if(numEncontrado == false)
            {
                Console.WriteLine("Número não encontrado na Sequência Fibonacci!");
            }
            else
            {
                Console.WriteLine("Número encontrado na Sequência Fibonacci!");
            }
        }
    }
}
