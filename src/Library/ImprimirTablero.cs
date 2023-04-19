using System;
using System.Text;
using System.Threading;
namespace PII_Game_Of_Life
{
    public class Imprimirtablero
    {
        public static void ImprimirTablero(Tablero tablero)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<tablero.getHeight();y++)
            {
                for (int x = 0; x<tablero.getWidth(); x++)
                {
                    if(tablero.getCelula(x,y))
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
                }
            s.Append("\n");
            }
        Console.WriteLine(s.ToString());
        //=================================================
        //Invocar método para calcular siguiente generación
        //=================================================
        Thread.Sleep(300);
        }
    }
}
