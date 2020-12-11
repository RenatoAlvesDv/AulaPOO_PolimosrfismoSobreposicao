using System;
using AulaPOO_PolimosrfismoSobreposicao.classes;

namespace AulaPOO_PolimosrfismoSobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan jogador = new MegaMan();
            Console.WriteLine($"Jogador 1 = {jogador.Correr()}");
            
            zero jogador2 = new zero ();

            Console.WriteLine($"Jogador 2 = {jogador2.Correr()}");
        }
    }
}
