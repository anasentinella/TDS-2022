using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaSequencialEx
{
   public  class Exercicios
    {
        public void Ex1()
       {
            int valor1;
            int valor2;
            float soma;
            Console.WriteLine(" Lista 1-Exercicio 1 \n");
            Console.WriteLine("Digite dois valores: ");
            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());
            soma = valor1 + valor2;
            Console.WriteLine ("A soma dos valores digitados é: \n" ,soma);
            }

        public void Ex2()
        {
            float raioc, area;
            Console.WriteLine(" Lista 1-Exercicio 2 \n");
            Console.WriteLine("Insira o valor do raio do círculo \n");
             raioc = float.Parse(Console.ReadLine());
            
            area= (float)(raioc *raioc*3.14159);
            Console.WriteLine("O valor do raio do círculo: \n",  raioc);
            Console.WriteLine("O valor da área do círculo é : \n",  area);
        }

        public void Ex3()
        {
            int a,b,c,d,prodab,prodcd,diferenca;
            Console.WriteLine(" Lista 1-Exercicio 3 ");
            Console.WriteLine("Digite o valor A,B e C: ");  
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            
            prodab=a*b;
            Console.WriteLine("O produto de A e B é: %d \n", prodab);
            prodcd = c * d;
            Console.WriteLine("O produto de C e D é: %d \n", prodcd);
            diferenca = prodab-prodcd;
            Console.WriteLine("A diferença do produto AB pelo produto BC é : %d \n", diferenca);
        }

         

    }
}
