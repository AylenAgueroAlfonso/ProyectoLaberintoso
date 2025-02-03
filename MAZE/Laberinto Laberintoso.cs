using System;
using System.Security.Cryptography.X509Certificates;

namespace Laberinto 
{
    struct Node{
        int x; 
        int y;
    };
    
   class LaberintoGenerador 
   {
public LaberintoGenerador() {

}

static void DFS (int[,] Matriz, int x)
{
    int [] fil = [0, 1, 0, -1];

}

   }

// Separación para no confundirme xdddd

    class Laberinto
    {

        public Laberinto (int [,] Maze)
        {
        
        }
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
            
                    } 
                }
            }
        }

    }



}

namespace Jugador 
{
    
    class Jugador
    {

                static void Jugar ()
        {
            Console.WriteLine("Qué deseas hacer ahora?");
            Console.WriteLine("(i) INFO");
            Console.WriteLine("(m) MOVER FICHA");
            Console.WriteLine("(p) USAR PODER");

            string respuesta1 = Console.ReadLine();

            if (respuesta1 == "i"){

            }

            if (respuesta1 == "m"){
                
            }

            if (respuesta1 == "p"){
                
            }

            if (respuesta1 != "i" || respuesta1 != "m" || respuesta1 != "p"){
                Jugador.Jugar();
            }


        }


    }
        
    
    class Info 
    {
       public Info ()
       {
        string h = Console.ReadLine();
        
       }

        static void Información (string help, int i)
        {

            

        }

    }
}

//Quiero disculparme con todos los profesores de programación. Gracias por su tiempo.