using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_практа
{
    internal class Strelka
    {
        public static int strelka(int position,int minStrelocka, int maxStrelochka)
        {
            ConsoleKeyInfo knopka;
            do
            {
                knopka = Console.ReadKey();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");
                if (knopka.Key == ConsoleKey.UpArrow && position != minStrelocka)
                {
                    position--;
                }
                else if (knopka.Key == ConsoleKey.DownArrow && position != maxStrelochka)
                {
                    position++;
                }
                else if (knopka.Key == ConsoleKey.Escape)
                {
                    return (int)Enum.Escape;
                }
                else if (knopka.Key == ConsoleKey.F1)
                {
                    return (int)Enum.F1;
                }
                else if (knopka.Key == ConsoleKey.F2)
                {
                    return (int)Enum.F2;
                }
                else if (knopka.Key == ConsoleKey.S)
                {
                    return (int)Enum.S;
                }
                else if (knopka.Key == ConsoleKey.F10)
                {
                    return (int)Enum.F10;
                }
                else if (knopka.Key == ConsoleKey.Delete)
                {
                    return (int)Enum.Del;
                }
                else if (knopka.Key == ConsoleKey.OemMinus)
                {
                    return (int)Enum.OemMinus;
                }
                else if (knopka.Key == ConsoleKey.OemPlus)
                {
                    return (int)Enum.OemPlus;
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
            } while (knopka.Key != ConsoleKey.Enter);
            return position;
        }
        public static int roli(int position, int minStrelocka, int maxStrelochka)
        {
            ConsoleKeyInfo knopk;
            do
            {
                knopk = Console.ReadKey();
                Console.SetCursorPosition(0, position);
                if (knopk.Key== ConsoleKey.D0)
                {
                    return (int)Enum.Adm;
                }
                if (knopk.Key == ConsoleKey.D1)
                {
                    return (int)Enum.kass;
                }
                if (knopk.Key == ConsoleKey.D2)
                {
                    return (int)Enum.Kadr;
                }
                if (knopk.Key == ConsoleKey.D3)
                {
                    return (int)Enum.Sklad;
                }
                if (knopk.Key == ConsoleKey.D4)
                {
                    return (int)Enum.Bux;
                }
            } while (knopk.Key != ConsoleKey.Enter);
            return position;
        }
    }
}

