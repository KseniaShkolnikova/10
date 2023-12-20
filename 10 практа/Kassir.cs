using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _10_практа
{
    internal class kassir
    {
        public kassiri Vibor = new kassiri();
        public void Read(string hh,int position, string login,string roli)
        {
            List<kassiri> kassir = SerilDesir.Desir<List<kassiri>>(hh) ?? new List<kassiri>();
            int sd = position - 3;
            hh = "kassir.json";
            while (position != (int)Enum.Escape)
            {
                Console.Clear();
                Console.SetCursorPosition(48, 0);
                Console.WriteLine($"Добро пожаловать {login}!                              Роль:{roli}");
                for (int i = 0; i < 119; i++)
                {
                    Console.SetCursorPosition(i, 1);
                    Console.WriteLine("-");
                }
                for (int i = 2; i < 20; i++)
                {
                    Console.SetCursorPosition(95, i);
                    Console.WriteLine("|");
                }
                Console.SetCursorPosition(0, 2);
                Console.WriteLine($"  ID: {kassir[sd].id}");
                Console.WriteLine($"  Имя: {kassir[sd].name}");
                Console.WriteLine($"  Цена за штуку: {kassir[sd].cena}");
                Console.WriteLine($"  Кол-во на складе: {kassir[sd].colvovsklad}");
                Console.WriteLine($"  Кол-во: {kassir[sd].pokupkolvo}");
                Console.SetCursorPosition(97, 3);
                Console.WriteLine("+ - Добавить товар");
                Console.SetCursorPosition(97, 4);
                Console.WriteLine("- - Убрать товар");
                Console.SetCursorPosition(97, 5);
                Console.WriteLine("Escape-Вернуться в меню");
                hh = "sklad.json";
                List<Sklad> skladik = SerilDesir.Desir<List<Sklad>>(hh) ?? new List<Sklad>();
                position = Strelka.strelka(2, 2, 6);
                if (skladik[sd].colvovsklad != 0)
                {
                    if (position == (int)Enum.OemMinus && kassir[sd].pokupkolvo != 0)
                    {
                        skladik[sd].colvovsklad = skladik[sd].colvovsklad + 1;
                        kassir[sd].pokupkolvo--;
                    }
                    if (position == (int)Enum.OemPlus && kassir[sd].pokupkolvo != skladik[sd].colvovsklad)
                    {
                        skladik[sd].colvovsklad = skladik[sd].colvovsklad - 1;
                        kassir[sd].pokupkolvo++;
                    }
                    SerilDesir.Serialize(skladik, hh);
                    kassir[sd].cumaitog = kassir[sd].pokupkolvo * kassir[sd].cena;
                    hh = "kassir.json";
                    SerilDesir.Serialize(kassir, hh);
                }
                else
                {
                    Console.SetCursorPosition(97, 6);
                    Console.WriteLine("Этого товара нет");
                }
            }
        }
        public void kassirs(string login, string roli)
        {
            
            string hh = "kassir.json";
            List<kassiri> list = SerilDesir.Desir<List<kassiri>>(hh) ?? new List<kassiri>();
            list.Clear();
            SerilDesir.Serialize(list, hh);
            int i;
            double cuma = 0;
            while (true)
            {

                Console.Clear();
                Console.SetCursorPosition(48, 0);
                Console.WriteLine($"Добро пожаловать {login}!                              Роль:{roli}");
                for (i = 0; i < 119; i++)
                {
                    Console.SetCursorPosition(i, 1);
                    Console.WriteLine("-");
                }
                for (i = 2; i < 20; i++)
                {
                    Console.SetCursorPosition(95, i);
                    Console.WriteLine("|");
                }
                Console.SetCursorPosition(97, 3);
                Console.WriteLine("S - Завершить покупку");
                Console.SetCursorPosition(97, 4);
                Console.WriteLine("Escape-Вернуться в меню");
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("     Id          Название          Цена за штуку               Количество       ");
                hh = "kassir.json";
                list = SerilDesir.Desir<List<kassiri>>(hh) ?? new List<kassiri>();
                SerilDesir.Serialize(list, hh);
                hh = "sklad.json";
                List<Sklad> skladda = SerilDesir.Desir<List<Sklad>>(hh) ?? new List<Sklad>();
                i = 0;
                foreach (var item1 in skladda) 
                {
                    kassiri sklad = new kassiri();
                    sklad.id = skladda[i].id;
                    sklad.name= skladda[i].name;
                    sklad.cena = skladda[i].cena;
                    sklad.colvovsklad = skladda[i].colvovsklad;
                    hh = "kassir.json";
                    list.Add(sklad);            
                    i++;
                }
                SerilDesir.Serialize(list, hh);
                double kk = 0;
                try
                {
                    hh = "kassir.json";
                    List<kassiri> Vibor12 = SerilDesir.Desir<List<kassiri>>(hh) ?? new List<kassiri>();
                    for ( i = 0; i < skladda.Count; i++)
                    {
                        Console.SetCursorPosition(5, i + 3);
                        Console.WriteLine(Vibor12[i].id);
                        Console.SetCursorPosition(19, i + 3);
                        Console.WriteLine(Vibor12[i].name);
                        Console.SetCursorPosition(39, i + 3);
                        Console.WriteLine(Vibor12[i].cena);
                        Console.SetCursorPosition(67, i + 3);
                        Console.WriteLine(Vibor12[i].pokupkolvo);
                        kk = Vibor12[i].cumaitog +kk;
                    }
                    for (int j = 0; j < 94; j++)
                    {
                        Console.SetCursorPosition(j, i + 3);
                        Console.WriteLine("-");
                    }
                    Console.WriteLine($"Итог: {kk}");

                }
                catch
                {
                    for (int j = 0; j < 94; j++)
                    {
                        Console.SetCursorPosition(j, 3);
                        Console.WriteLine("-");
                    }

                    Console.WriteLine($"Итог: {kk}");
                }
                int position = 0;
                try
                {

                    position = Strelka.strelka(3, 3, skladda.Count+ 2);
                }
                catch
                {
                    position = Strelka.strelka(3, 3, 3);
                }
                if (position == (int)Enum.Escape)
                {
                    break;
                }
                else if (position == (int)Enum.S)
                {
                    hh = "buxa.json";
                    List<Buxgalter> buxdes = SerilDesir.Desir<List<Buxgalter>>(hh) ?? new List<Buxgalter>();
                    Buxgalter buxgalter = new Buxgalter();
                    buxgalter.cuma = kk;
                    buxgalter.pribavka = true;
                    buxgalter.name ="Покупка" ;
                    buxgalter.vrema = DateTime.Now;
                    buxdes.Add(buxgalter);
                    SerilDesir.Serialize(buxdes,hh);
                    Console.Clear();
                    Console.SetCursorPosition(48, 0);
                    Console.WriteLine($"Добро пожаловать {login}!                              Роль:{roli}");
                    for (i = 0; i < 119; i++)
                    {
                        Console.SetCursorPosition(i, 1);
                        Console.WriteLine("-");
                    }
                    for (i = 2; i < 20; i++)
                    {
                        Console.SetCursorPosition(95, i);
                        Console.WriteLine("|");
                    }
                    Console.SetCursorPosition(50, 10);
                    Console.WriteLine("Заказ сохранен!");
                    Thread.Sleep(1000);
                    return;
                }
                else
                {
                    Read(hh, position, login,roli);
                }
            }
        }
    }
}
