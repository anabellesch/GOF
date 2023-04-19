using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablero tablero= new Tablero();
            while (true) {

                MostrarTablero.printTablero(Tablero);
                logica.nuevaGeneracion(Tablero);
                Thread.sleep(300); //DETIENE LA EJECUCION DURANTE 300 MILISEGUNDOS
            }
        }
    }
}

