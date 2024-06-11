using System;
using System.Collections.Generic;

namespace Menu
{
    class MenuPrincipal
    {
        public List<Menu> menu = new List<Menu>();
        int numeroMenu = 0;

        public MenuPrincipal(Dictionary<string, string[]> menus)
        {
            int fila = 1;
            int col = 1;
            // Recorro el diccionario
            //int pos = 1;
            foreach (var subMenu in menus)
            {
                menu.Add(new Menu(0, subMenu.Key, subMenu.Value, fila, col));
                col += subMenu.Key.Length + 2;
            }

        }

        public void dibujar()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;

            foreach (var cant in menu)
            {
                Console.SetCursorPosition(cant.columna, cant.fila++);
                if (cant == menu[numeroMenu])
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(cant.nombreMenu);
                    for (int i = 0; i < cant.items.Length; i++)
                    {
                        Console.SetCursorPosition(cant.columna, cant.fila++);
                        if (cant.items[i] == cant.items[cant.priItem])
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(cant.items[i]);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine(cant.items[i]);
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(cant.nombreMenu);
                    Console.SetCursorPosition(0, cant.items.Length + 1);
                }
                cant.fila = 1;
            }
        }
        public void arriba()
        {

            menu[numeroMenu].priItem--;

            if (menu[numeroMenu].priItem < 0)
                menu[numeroMenu].priItem = menu[numeroMenu].items.Length - 1;
            dibujar();
        }

        public void abajo()
        {

            menu[numeroMenu].priItem++;

            if (menu[numeroMenu].priItem >= menu[numeroMenu].items.Length)
                menu[numeroMenu].priItem = 0;
            dibujar();
        }

        public void izq()
        {
            numeroMenu--;

            if (numeroMenu < 0)
                numeroMenu = menu.Count - 1;
            dibujar();
        }

        public void der()
        {
            numeroMenu++;

            if (numeroMenu >= menu.Count)
                numeroMenu = 0;
            dibujar();
        }
    }
}