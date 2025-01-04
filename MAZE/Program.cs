using System;
namespace Laberinto 
{
   class LaberintoGenerador 
   {

   }



    class Programa
    {
        static void Main ()
        {
            int[,] Maze = new int[3, 3];

int n = Maze.GetLength(0);
int m = Maze.GetLength(1);

for (int fila = 0; fila < n; fila++)
{
    for (int colum = 0; colum < m; colum++)
    {
        if (Maze[fila,colum] == 0)
        {
            Maze[fila,colum] = 1;

        } 
        }
}
        }
    }
}




        
    



