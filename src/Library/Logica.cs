using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class Logica 
    {
        
        public static Tablero gameBoard = new Tablero();
        
        int boardWidth = gameBoard.getWidth();
        int boardHeight = gameBoard.getHeight();

        public static void LogicaDeJuego()
        {
            Tablero cloneboard = new Tablero();
            for (int x = 0; x < cloneboard.getWidth(); x++)
            {
                for (int y = 0; y < cloneboard.getHeight(); y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i<=x+1;i++)
                    {
                        for (int j = y-1;j<=y+1;j++)
                        {
                            if(i>=0 && i<cloneboard.getWidth() && j>=0 && j < cloneboard.getHeight() && cloneboard.getCelula(i, j) )
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(gameBoard.getCelula(x,y))
                    {
                        aliveNeighbors--;
                    }
                    if (gameBoard.getCelula(x,y) && aliveNeighbors < 2)
                    {
                        //Celula muere por baja población
                        cloneboard.setCelula(x,y, false);
                    }
                    else if (gameBoard.getCelula(x,y) && aliveNeighbors > 3)
                    {
                        //Celula muere por sobrepoblación
                        cloneboard.setCelula(x,y,false);
                    }
                    else if (!gameBoard.getCelula(x,y) && aliveNeighbors == 3)
                    {
                        //Celula nace por reproducción
                        cloneboard.setCelula(x,y,true); 
                    }
                    else
                    {
                    }
                }
            }
            gameBoard.ClonarTablero(cloneboard);
        }

    }

}