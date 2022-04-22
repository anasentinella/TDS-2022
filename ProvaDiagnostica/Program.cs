using System;

namespace ProvaDiagnostica
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Solucao ProvaDiag = new Solucao();

            Console.WriteLine("Prova Diagnóstica!\n");
            ProvaDiag.Ex1();
            ProvaDiag.Ex1_2();
            ProvaDiag.Ex2();
            ProvaDiag.Ex2_2();
            ProvaDiag.Ex3();

        }
    }
}
