using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Presentacion
{
    internal class Menu
    {
     public void VerPrincipal(int l, int t)
        {
            

            int op;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();

                Console.SetCursorPosition(l + 65, t + 22);
                Console.WriteLine("-------------------------------------------------------------------------------");

                Console.SetCursorPosition(l, t - 2); Console.WriteLine("BIENVENIDOS AL MENU DE ESTUDIANTES");
                Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. ESTUDIANTES PREGRADO");
                Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. ESTUDIANTES PROGRADO");
                Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. PROMEDIO POR PROGRAMA");
                Console.SetCursorPosition(l, t + 5); Console.WriteLine("4. ESTUDIANTES DESTACADOS");
                Console.SetCursorPosition(l, t + 7); Console.WriteLine("5. SALIR");
                Console.SetCursorPosition(l, t + 9); Console.WriteLine("ELIGA una opcion: ");
                Console.SetCursorPosition(l + 19, t + 9); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        break;
                    case 2:
                        
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:
                        Console.Clear();
                        Console.SetCursorPosition(l, t - 2); Console.WriteLine("-------------");
                        Console.SetCursorPosition(l + 22, t - 2); Console.ReadKey();
                        break;
                }

            } while (op != 5);
        }
    }
}
