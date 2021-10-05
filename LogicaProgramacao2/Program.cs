using System;

namespace LogicaProgramacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estrutura de Dados
            //pilha - Last In, First Out (LIFO)
            //fila - First In, First Out (FIFO)
            //lista - Lista não-organizada


            //pilha - Last In, First Out (LIFO)
            int[] numeros = new int[10];

            //Estrutua de Dados
            for (int i = 0; i < 10; i++)
            {
                numeros[i] = i;
            }

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }


            //fila - First In, First Out (FIFO)
            //int[] numeros = new int[10];

            //Estrutua de Dados
            //for (int i = 0; i < 10; i++)
            //{
            //    numeros[i] = i;
            //}
            //Estrutura de impressão de dados

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            //lista - Lista não-organizada
            //int[] numeros = new int[5];
            //numeros[3] = 1;
            //numeros[4] = 10;
            //Console.WriteLine(numeros[3]);
            //Console.WriteLine(numeros[4]);










            //Estrutura de repetição

            //int resposta = 0;
            //int erro = 0;
            //int count = 1;

            //while (resposta != 2)
            //{
            //    if (count >= 2)
            //        erro++;

            //    Console.WriteLine("Qual o nome do Presidente atual do Brasil");
            //    Console.WriteLine("1 - Fernando Henrique Cardoso");
            //    Console.WriteLine("2 - Jair Messias Bolsonaro");
            //    Console.WriteLine("3 - Luíz Inácio Lula da Silva");
            //    Console.WriteLine("4 - Tancredo Neves");
            //    Console.WriteLine("5 - Dilma");
            //    Console.WriteLine("6 - Castelo Branco");
            //    Console.WriteLine("7 - Sarney");

            //    resposta = Convert.ToInt32(Console.ReadLine());

            //    count++;
            //}

            //double nota = 10;

            //if (erro > 0)
            //    nota = nota / erro;

            //Console.WriteLine($"Venceu Sua nota é: {nota}");


            //Estrutura de repetição
            //For

            //Console.WriteLine("Digite o número inicial:");
            //int inicial = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite o número final:");
            //int final = Convert.ToInt32(Console.ReadLine());

            //if (final <= inicial)
            //    Console.WriteLine("Erro: o número Final não pode ser menor do que o número inicial.");
            //else
            //{
            //    Console.WriteLine("número ímpares(I) ou número pares(P):");
            //    string tipo = Console.ReadLine();

            //    switch (tipo.ToLower())
            //    {
            //        case "p":
            //            for (int i = inicial; i <= final; i++)
            //                if (i % 2 == 0)
            //                    Console.WriteLine(i);

            //            break;
            //        case "i":

            //            for (int i = inicial; i <= final; i++)
            //                if (i % 2 == 1)
            //                    Console.WriteLine(i);

            //            break;
            //        default:
            //            Console.WriteLine("Você não digitou o tipo de número correto!");
            //            break;

            //int numero = 1;
            //while (numero % 2 == 1) //impar
            //{
            //    Console.WriteLine("Digite um número par:");
            //   numero = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("obrigado po digitar um número par!");

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 2 == 0) //par

            //    Console.WriteLine(i);
            //}


            //While
            //int inteiro = 0;

            //while (inteiro <10)
            //{
            //    Console.WriteLine(inteiro);
            //    inteiro = inteiro + 1;
            //}



        }
    }
}
