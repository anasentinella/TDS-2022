using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaSequencialEx
{
   public  class Exercicios
    {
        public void Ex1()
       {
            Int32 v1, v2;
            Console.Write("Valor 1: ");
            v1 = Int32.Parse(Console.ReadLine());
            Console.Write("Valor 2: ");
            v2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("SOMA = {0}", (v1 + v2));
        }

        public void Ex2()
        {
            Double raio = 0.0;
            Double area = 0.0;
            Console.Write("Raio : ");
            raio = Double.Parse(Console.ReadLine());
            area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine("Area : {0:F4}", area);
        
        }

        public void Ex3()
        {
            Int32 a, b, c, d;
            Console.Write("A : ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("B : ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("C : ");
            c = Int32.Parse(Console.ReadLine());
            Console.Write("D : ");
            d = Int32.Parse(Console.ReadLine());
            Console.WriteLine("DIFERENÇA = {0}", (a * b) - (c * d));
        }
       
        public void Ex4()
        {
            Int32 nrFunc;
            Double hrTrab;
            Double vlrHora;
            Console.Write("Numero do funcionario: ");
            nrFunc = Int32.Parse(Console.ReadLine());
            Console.Write("Qtde horas trabalhadas: ");
            hrTrab = Double.Parse(Console.ReadLine());
            Console.Write("Valor da hora: ");
            vlrHora = Double.Parse(Console.ReadLine());
            Console.WriteLine("NUMERO = {0}", nrFunc);
            Console.WriteLine("SALÁRIO = {0:F2}", hrTrab * vlrHora);
        }
     
        public void Ex5()
        {
            Int32 cp1, qp1;
            Double vp1;
            Int32 cp2, qp2;
            Double vp2;
            Console.Write("CÓDIGO PECA 1:");
            cp1 = Int32.Parse(Console.ReadLine());
            Console.Write("QUANTIDADE PECA 1:");
            qp1 = Int32.Parse(Console.ReadLine());
            Console.Write("VALOR DA PECA 1:");
            vp1 = Double.Parse(Console.ReadLine());
            Console.Write("CÓDIGO PECA 2:");
            cp2 = Int32.Parse(Console.ReadLine());
            Console.Write("QUANTIDADE PECA 2:");
            qp2 = Int32.Parse(Console.ReadLine());
            Console.Write("VALOR DA PECA 2:");
            vp2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("VALOR A PAGAR {0:F2}",(qp1*vp1)+(qp2*vp2));
        }
        public void Ex6()
        {
            Console.WriteLine("\n\n\t\t Exercicio 6 \n\n");
            float a, b, c;
            double result, pi = 3.14159;
            Console.WriteLine("\n insira o primeiro valor: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("\n insira o segundo valor: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("\n insira o terceiro valor: ");
            c = float.Parse(Console.ReadLine());
            result = (a * c) / 2;
            Console.WriteLine("\n\n Círculo (C como raio): \t\t\t {0:f3}", result);
            result = (a + b) / 2 * c;
            Console.WriteLine("\n\n Trapézio (A e B = base e C=altura): \t\t\t {0:f3}", result);
            result = b * b;
            Console.WriteLine("\n\n Quadrado (B = lado): \t\t\t {0:f3}", result);
            result = a * b;
            Console.WriteLine("\n\n Retângulo (A e B = lados): \t\t\t {0:f3}", result);
        }
    }
}
