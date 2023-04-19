using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class Tablero
    {
        public bool[,] tablero {get; set;}
        public Tablero()
        {
            this.tablero=DibujarTablero.Tablero();
        }
        public  void ClonarTablero(Tablero nuevo)
        {
            this.tablero = nuevo.tablero;
        }
        public int getHeight()
        {
          return this.tablero.GetLength(1);
        }

        public int getWidth()
        {
           return this.tablero.GetLength(0);
        }

        public bool getCelula(int x, int y) 
        {
            return tablero[x,y];
        }

        public void setCelula(int x,int y,bool alive)
        {
            tablero[x,y] = alive;
        }

       
    }
}