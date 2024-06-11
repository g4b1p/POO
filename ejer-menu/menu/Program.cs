using System;
using System.Collections.Generic;

namespace Menu
{
    internal class Program
    {
        class Item
        {
            string opcion;
        }
        static void Main(string[] args)
        {
            MenuPrincipal menu;

            string[] menu1 = { "Nuevo Cliente", "Modificar Cliente", "Listar Clientes", "Salir" };
            string[] menu2 = { "Nuevo Producto", "Modificar Producto", "Eliminar Producto", "Listar Producto", "Salir." };

            var menus = new Dictionary<string, string[]>
            {
                { "Archivo", menu1 }, { "Editar", menu2 },
            };

            Console.Clear();
            menu = new MenuPrincipal(menus);

            ConsoleKeyInfo tecla;

            menu.dibujar();
            do
            {
                tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    case ConsoleKey.UpArrow:
                        menu.arriba();
                        break;
                    case ConsoleKey.DownArrow:
                        menu.abajo();
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        menu.izq();
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        menu.der();
                        break;
                }
            } while (tecla.Key != ConsoleKey.Enter);

            Console.ReadKey();
        }
    }
}