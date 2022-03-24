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
        Console.WriteLine("\n Lista 1-Exercicio 1 \n");
        Console.WriteLine("Digite dois valores: ");
        valor1 = int.Parse(Console.ReadLine());
        valor2 = int.Parse(Console.ReadLine());
        soma = valor1 + valor2;
        Console.WriteLine("A soma dos valores digitados é: \n", soma);
    }

    public void Ex2()
    {
        float raioc, area;
        Console.WriteLine(" Lista 1-Exercicio 2 \n");
        Console.WriteLine("Insira o valor do raio do círculo \n");
        raioc = float.Parse(Console.ReadLine());
        Console.WriteLine("O valor do raio do círculo: \n", raioc);
        area = (float)(raioc * raioc * 3.14159);
        Console.WriteLine("O valor da área do círculo é : \n", area);

    }

    public void Ex3()
    {
        int a, b, c, d, prodab, prodcd, diferenca;
        Console.WriteLine(" Lista 1-Exercicio 3 ");
        Console.WriteLine("Digite o valor A,B,C e D: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());
        prodab = a * b;
        Console.WriteLine("O produto de A e B é:  \n", prodab);
        prodcd = c * d;
        Console.WriteLine("O produto de C e D é:  \n", prodcd);
        diferenca = prodab - prodcd;
        Console.WriteLine("A diferença do produto AB pelo produto BC é :  \n", diferenca);
    }
    public void Ex4()
        {
            int numerofunc;

            float horastrab, valorporhr, salariof;
            Console.WriteLine(" Lista 1-Exercicio 4 \n");
            Console.WriteLine("Digite o número de identificação do funcionário: \n");
            numerofunc = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a carga horária trabalhada pelo funcionário: \n");
            horastrab = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor por hora de trabalho: \n");
            valorporhr = float.Parse(Console.ReadLine());
            Console.WriteLine("O funcionário de N°: \n", numerofunc);
            salariof = horastrab * valorporhr;
            Console.WriteLine("Recebe um salário de R$: \n", salariof);
        }


        public void Ex5()
        {
            int cp1, qp1, cp2, qp2;
            float pu1, pu2, vlrPagar;
            Console.WriteLine(" Lista 1-Exercicio 5 \n ");
            Console.WriteLine("Peça 1\n");
            cp1 = int.Parse(Console.ReadLine());
            qp1 = int.Parse(Console.ReadLine());
            pu1 = float.Parse(Console.ReadLine());

            Console.WriteLine("peça 2\n");
            cp2 = int.Parse(Console.ReadLine());
            qp2 = int.Parse(Console.ReadLine());
            pu2 = float.Parse(Console.ReadLine());

            vlrPagar = (qp1 * pu1) + (qp2 * pu2);
            Console.WriteLine("Valor a ser pago: ", vlrPagar);

        }


        public void Ex6()
        {
            double a, b, c, r;
            float areaT, areaC, areaTr, areaQ, areaR;
            Console.WriteLine(" Lista 1-Exercicio 6  \n");

            Console.WriteLine("exercicio 6\n");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            r = float.Parse(Console.ReadLine());

            areaT = (float)(a * c);
            Console.WriteLine("área do triângulo ", areaT);
            areaC = (float)(3.14159 * r * r);
            Console.WriteLine("área do circulo ", areaC);
            areaTr = (float)((a + b) * c);
            Console.WriteLine("área do trapézio ", areaTr);
            areaQ = (float)(a * a);
            Console.WriteLine("área do quadrado: ", areaQ);
            areaR = (float)(a * b);
            Console.WriteLine("área do retângulo ", areaR);
        }
        }
     

    }
}
