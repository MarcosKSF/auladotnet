using System;

namespace auladotnet
{
    class Program
    {

        static void Main(string[] args)
        {
         
            int nois =3;
            string[] lista = new string[10];
            //Console.WriteLine("Digite o nome do jogador");


            for (int i = 0; i < nois; i++)
            {
                Console.WriteLine("Digite o nome do jogador");
                lista[i] = Console.ReadLine();
            }

            Console.WriteLine("A lista de jogadores é:");

            for (int i = 0; i < nois; i++)
            {
                Console.WriteLine($" { lista[i]}");
            }
          


        }
    }
}
//            for (int i = 0; i<=lista.Length; i++)
