using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaDiagnostica
{
    public class Solucao
    {
        public void Ex1()
        {
            int cp1, qp1;
            float pu1;
            int cp2, qp2;
            float pu2;
            float vlrPagar;
            Console.WriteLine("exercicio 1\n");
            Console.WriteLine("Peça 1\n");
            cp1 = int.Parse(Console.ReadLine());
            qp1 = int.Parse(Console.ReadLine());
            pu1 = float.Parse(Console.ReadLine());
           
            Console.WriteLine("peça 2\n");
            cp2 = int.Parse(Console.ReadLine());
            qp2 = int.Parse(Console.ReadLine());
            pu2 = float.Parse(Console.ReadLine());

            vlrPagar = (qp1 * pu1) + (qp2 * pu2);
            Console.WriteLine("Valor a ser pago:{0:f2} ", vlrPagar);
        }
        public void Ex2()
        
        {
            Console.WriteLine("exercicio 2\n");
        }
    }
}
