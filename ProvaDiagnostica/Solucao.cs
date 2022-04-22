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
            float vu1;
            int cp2, qp2;
            float vu2;
            float vlrPagar;
            Console.WriteLine("exercicio 1\n");
            Console.WriteLine("Peça 1\n");
            Console.WriteLine("Digite o código da peça 1 : \n");
            cp1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peça 1 : \n");
            qp1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valorunitário da peça 1 : \n");
            vu1 = float.Parse(Console.ReadLine());

            Console.WriteLine("peça 2\n");
            Console.WriteLine("Digite o código da peça 2 : \n");
            cp2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peça 2 : \n");
            qp2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valorunitário da peça 2 : \n");
            vu2 = float.Parse(Console.ReadLine());

            vlrPagar = (qp1 * vu1) + (qp2 * vu2);
            Console.WriteLine("Valor a ser pago: {0:f2} ", vlrPagar);
        }
        public void Ex1_2()

        {
            double raio;
            double area;
            Console.WriteLine("exercicio 1.2\n");
            Console.WriteLine(" Digite o valor do raio do círculo : \n");
            raio = float.Parse(Console.ReadLine());
            area = (raio * raio) * 3.14159;
            Console.WriteLine("Valor da área do circulo: {0:f4",area);

        }
        public void Ex2()
        {
            int cod;
            int qtd;
            double total;
            Console.WriteLine("exercicio 2\n");
            Console.WriteLine("Cachorro Quente - Cod 1 \n" + "Frango - Cod 2 \n" + "X bancon - Cod 3 \n " + "Coca Cola - Cod 4 \n " + " Suco de Laranja - Cod 5 \n");
            Console.WriteLine("Digite o Código do produto escolhido: \n");
            cod = int.Parse(Console.ReadLine());

            if (cod == 1)
            {
                Console.WriteLine("Digite a quantidade do produto: ");
                qtd = int.Parse(Console.ReadLine());
                total = qtd * 16.00;
                Console.WriteLine("Total a pagar: {0:f2} ", total);
            }

            else if (cod == 2)
            {
                Console.WriteLine("Digite a quantidade do produto: ");
                qtd = int.Parse(Console.ReadLine());
                total = qtd * 25.00;
                Console.WriteLine("Total a pagar: {0:f2} ", total);
            }
            else if (cod == 3)
            {
                Console.WriteLine("Digite a quantidade do produto: ");
                qtd = int.Parse(Console.ReadLine());
                total = qtd * 20.00;
                Console.WriteLine("Total a pagar: {0:f2} ", total);
            }
            else if (cod == 4)
            {
                Console.WriteLine("Digite a quantidade do produto: ");
                qtd = int.Parse(Console.ReadLine());
                total = qtd * 6.50;
                Console.WriteLine("Total a pagar: {0:f2} ", total);
            }
            else if (cod == 5)
            {
                Console.WriteLine("Digite a quantidade do produto: ");
                qtd = int.Parse(Console.ReadLine());
                total = qtd * 25.00;
                Console.WriteLine("Total a pagar: {0:f2} ", total);
            }
            else
            {
                Console.WriteLine("Esse produto não existe");
            }

        }

        public void Ex2_2()
        {
            Console.WriteLine("Exercicío 2.2 \n");








        }

        public void Ex3()
        {
            int senha;
            Console.WriteLine("Exercicío 3 \n");
            while (senha != cotil)
                
            {
                Console.WriteLine("Digite a senha: \n");
                senha= int.Parse(Console.ReadLine());

                if (senha==cotil)
                {
                    Console.WriteLine("Senha correta - Acesso Permitido \n");
                }
                else
                    Console.WriteLine("Senha incorreta - Acesso Negado \n");
            }
        }
    }
}
