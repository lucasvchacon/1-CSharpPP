using System;

namespace AluraPP
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade = 32;
            int idade2 = 29;
            double salario = 1200.70;
            long idade3 = 13000000;
            short quantidadeProdutos = 1500;
            char letra= 'a';
            string titulo = " Aqui é um texto" + 2020;

            Console.WriteLine(titulo);
            Console.WriteLine(idade3);
            Console.WriteLine(letra);
            Console.WriteLine(salario);
            Console.WriteLine(quantidadeProdutos);


            Console.WriteLine("sua idade é: " +idade);
            Console.WriteLine(idade2);


            Console.WriteLine("Programa 1");
            Console.WriteLine( "A Execução acabou tecle enter pra continuar...3");

            // Usando o IF
                int idadeJoao = 16;
                if (idadeJoao >= 18 )
                {
                    Console.WriteLine("Maior de idade");
                }

                else 
                {
                    Console.WriteLine("menor de idade");

                }

            // Usando While 

                double valorInvestido = 1000;
                int contadorMes = 1;

                while (contadorMes <= 12)
                {
                    valorInvestido = valorInvestido +  valorInvestido * 0.0036;
                    Console.WriteLine( " Após " + contadorMes + " meses, você terá" + valorInvestido);
                    contadorMes ++;

                }

                

                //valorInvestido = valorInvestido + valorInvestido * 0.0036;
               // Console.WriteLine("Após 1 mês, você terá R$" + valorInvestido);



            Console.ReadLine();
       }
    }
}
