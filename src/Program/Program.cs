using System;
using System.Threading;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tablero a = new Tablero();
            while(true)
            {
                Imprimirtablero.ImprimirTablero(a);
                //Logica.LogicaDeJuego();

            }

        }
    }
}
