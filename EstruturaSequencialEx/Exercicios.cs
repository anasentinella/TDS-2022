using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaSequencialEx
{
   public  class Exercicios
    {
        
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
=======
        }
       
>>>>>>> 5c3699e56cb8bd5bf64db8412bc9bf8a8bcc1cb1

    }
}
