using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace _10_практа
{
    internal class skladik : CRUDS
    {
        public Sklad Vibor = new Sklad();
        public void Delete(string hh)
        {
            List<Sklad> list2 = SerilDesir.Desir<List<Sklad>>(hh);
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i].id == Vibor.id & list2[i].name == Vibor.name & list2[i].cena == Vibor.cena & list2[i].colvovsklad  == Vibor.colvovsklad)
                {
                    list2.Remove(list2[i]);
                }
            }
            SerilDesir.Serialize(list2, hh);
        }
        public void Update(string hh, string login, string roli)
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
            Console.WriteLine($"  ID: {Vibor.id}");
            Console.WriteLine($"  Название: {Vibor.name}");
            Console.WriteLine($"  Цена за штуку: {Vibor.cena}");
            Console.WriteLine($"  Кол-во на складе: {Vibor.colvovsklad}");
            Console.SetCursorPosition(97, 3);
            Console.WriteLine("S - Сохранить изменения");
            Console.SetCursorPosition(97, 4);
            Console.WriteLine("Escape-Вернуться в меню");
            List<Sklad> list2 = SerilDesir.Desir<List<Sklad>>(hh);
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i].id == Vibor.id & list2[i].name == Vibor.name & list2[i].cena == Vibor.cena & list2[i].colvovsklad == Vibor.colvovsklad)
                {
                    list2.Remove(list2[i]);
                }
            }
            int position = 1;
            while (position != (int)Enum.S)
            {
                position = Strelka.strelka(2, 2, 5);
                switch (position)
                {
                    case 2:
                        Console.SetCursorPosition(7, 2);
                        Console.WriteLine("                                         ");
                        Console.SetCursorPosition(7, 2);
                        string id = Console.ReadLine();
                        Vibor.id = id;
                        break;
                    case 3:
                        Console.SetCursorPosition(12, 3);
                        Console.WriteLine("                                         ");
                        Console.SetCursorPosition(12, 3);
                        string name = Console.ReadLine();
                        Vibor.name = name;
                        break;
                    case 4:
                        while (true)
                        {
                            double skvazimabzazabza = 0;
                            Console.SetCursorPosition(17, 4);
                            Console.WriteLine("                                     ");
                            Console.SetCursorPosition(17, 4);
                            try
                            {
                                skvazimabzazabza = Convert.ToDouble(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.SetCursorPosition(17, 4);
                                Console.WriteLine("Нужно вводить число");
                                Thread.Sleep(1000);
                            }
                            Vibor.cena = skvazimabzazabza;

                        }
                        break;
                    case 5:                       
                        while (true)
                        {
                            int skvazimabzazabza = 0;
                            Console.SetCursorPosition(20, 5);
                            Console.WriteLine("                                         ");
                            Console.SetCursorPosition(20, 5);
                            try
                            {
                                skvazimabzazabza = Convert.ToInt16(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.SetCursorPosition(20, 5);
                                Console.WriteLine("Нужно вводить число");
                                Thread.Sleep(1000);
                            }
                            Vibor.colvovsklad = skvazimabzazabza;

                        }
                        break;
                    case 100:
                        return;
                }
            }
            list2.Add(Vibor);
            SerilDesir.Serialize(list2, hh);
        }
        public void Create()
        {

            Console.SetCursorPosition(97, 3);
            Console.WriteLine("S - Сохранить изменения");
            Console.SetCursorPosition(97, 4);
            Console.WriteLine("Escape-Вернуться в меню");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("  ID: ");
            Console.WriteLine("  Имя: ");
            Console.WriteLine("  Цена за штуку: ");
            Console.WriteLine("  Кол-во на складе: ");
            Sklad skla = new Sklad();
            int position = 0;
            while (position != (int)Enum.S)
            {
                position = Strelka.strelka(2, 2, 5);
                switch (position)
                {
                    case 2:
                        Console.SetCursorPosition(7, 2);
                        Console.WriteLine("                                         ");
                        Console.SetCursorPosition(7, 2);
                        string id = Console.ReadLine();
                        skla.id = id;
                        break;
                    case 3:
                        Console.SetCursorPosition(12, 3);
                        Console.WriteLine("                                         ");
                        Console.SetCursorPosition(7, 3);
                        string name = Console.ReadLine();
                        skla.name = name;
                        break;
                    case 4:
                        while (true)
                        {
                            double skvazimabzazabza = 0;
                            Console.SetCursorPosition(17, 4);
                            Console.WriteLine("                                     ");
                            Console.SetCursorPosition(17, 4);
                            try
                            {
                                skvazimabzazabza = Convert.ToDouble(Console.ReadLine());
                                skla.cena = skvazimabzazabza;
                                break;
                            }
                            catch
                            {
                                Console.SetCursorPosition(17, 4);
                                Console.WriteLine("Нужно вводить число");
                                Thread.Sleep(1000);
                            }
                           

                        }
                        break;
                    case 5:
                        while (true)
                        {
                            int skvazimabzazabza = 0;
                            Console.SetCursorPosition(20, 5);
                            Console.WriteLine("                                         ");
                            Console.SetCursorPosition(20, 5);
                            try
                            {
                                skvazimabzazabza = Convert.ToInt16(Console.ReadLine());
                                skla.colvovsklad = skvazimabzazabza;
                                break;
                            }
                            catch
                            {
                                Console.SetCursorPosition(20, 5);
                                Console.WriteLine("Нужно вводить число");
                                Thread.Sleep(1000);
                            }
                            

                        }
                        break;
                    case 100:
                        return;
                }
            }
            string hh = "sklad.json";
            List<Sklad> list = SerilDesir.Desir<List<Sklad>>(hh) ?? new List<Sklad>();
            list.Add(skla);
            SerilDesir.Serialize(list, hh);
        }
        public void Read(int position, string hh, string login, string roli)
        {
            while (true)
            {
                List<Sklad> sklad = SerilDesir.Desir<List<Sklad>>(hh);
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
                try
                {

                    Vibor.id = sklad[position - 3].id;
                    Vibor.name = sklad[position - 3].name;
                    Vibor.cena = sklad[position - 3].cena;
                    Vibor.colvovsklad = sklad[position - 3].colvovsklad;
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine($"  ID: {Vibor.id}");
                    Console.WriteLine($"  Имя: {Vibor.name}");
                    Console.WriteLine($"  Цена за штуку: {Vibor.cena}");
                    Console.WriteLine($"  Кол-во на складе: {Vibor.colvovsklad}");
                    Console.SetCursorPosition(97, 3);
                    Console.WriteLine("F10-Изменить пункт");
                    Console.SetCursorPosition(97, 4);
                    Console.WriteLine("Del-Удалить запись");
                    Console.SetCursorPosition(97, 5);
                    Console.WriteLine("Escape-Вернуться в меню");
                    position = Strelka.strelka(2, 2, 5);
                }
                catch
                {
                    return;
                }
                if (position == (int)Enum.F10)
                {
                    Update(hh, login, roli);
                }
                else if (position == (int)Enum.Del)
                {
                    Delete(hh);
                }
                else if (position == (int)Enum.Escape)
                {
                    return;
                }
            }
        }
        public void Serch(string login, string hh, string roli)
        {
            int i = 0;
            Console.Clear();
            Console.SetCursorPosition(48, 0);
            Console.WriteLine($"Добро пожаловать {login}!");
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
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Выберите, по какому пункту вы хотите произвести поиск:");
            Console.WriteLine("  ID\n  Название\n  Цена за штуку\n  Кол-во на складе");
            int position = Strelka.strelka(3, 3, 6);
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("Введите значение для поиска: ");
            var znach = Console.ReadLine();
            Sklad kk = new Sklad();
            i = 0;
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
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("     Id          Название          Цена за штуку         Количество на складе");
            i = 0;
            switch (position)
            {
                case 3:
                    List<Sklad> list2 = SerilDesir.Desir<List<Sklad>>(hh);
                    foreach (var item in list2)
                    {
                        if (item.id == znach)
                        {
                            kk.id = item.id;
                            kk.name = item.name;
                            kk.cena = item.cena;
                            kk.colvovsklad = item.colvovsklad;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(23, i + 3);
                            Console.WriteLine(kk.name);
                            Console.SetCursorPosition(43, i + 3);
                            Console.WriteLine(kk.cena);
                            Console.SetCursorPosition(61, i + 3);
                            Console.WriteLine(kk.cena);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
                case 4:
                    List<Sklad> list3 = SerilDesir.Desir<List<Sklad>>(hh);
                    foreach (var item in list3)
                    {
                        if (item.name == znach)
                        {
                            kk.id = item.id;
                            kk.name = item.name;
                            kk.cena = item.cena;
                            kk.colvovsklad = item.colvovsklad;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(23, i + 3);
                            Console.WriteLine(kk.name);
                            Console.SetCursorPosition(43, i + 3);
                            Console.WriteLine(kk.cena);
                            Console.SetCursorPosition(61, i + 3);
                            Console.WriteLine(kk.cena);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
                case 5:
                    double znach1 = Convert.ToDouble(znach);
                        List<Sklad> list1 = SerilDesir.Desir<List<Sklad>>(hh);
                        foreach (var item in list1)
                        {
                            if (item.cena == znach1)
                            {
                                kk.id = item.id;
                                kk.name = item.name;
                                kk.cena = item.cena;
                                kk.colvovsklad = item.colvovsklad;
                                Console.SetCursorPosition(5, i + 3);
                                Console.WriteLine(kk.id);
                                Console.SetCursorPosition(23, i + 3);
                                Console.WriteLine(kk.name);
                                Console.SetCursorPosition(43, i + 3);
                                Console.WriteLine(kk.cena);
                                Console.SetCursorPosition(61, i + 3);
                                Console.WriteLine(kk.cena);
                                i++;
                            }
                        }
                        position = Strelka.strelka(3, 3, i + 2);
                        Read(position, hh, login, roli);
                        break;
                case 6:
                    int znach2 = Convert.ToInt32(znach);
                    List<Sklad> list5 = SerilDesir.Desir<List<Sklad>>(hh);
                    foreach (var item in list5)
                    {
                        if (item.colvovsklad == znach2)
                        {
                            kk.id = item.id;
                            kk.name = item.name;
                            kk.cena = item.cena;
                            kk.colvovsklad = item.colvovsklad;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(23, i + 3);
                            Console.WriteLine(kk.name);
                            Console.SetCursorPosition(43, i + 3);
                            Console.WriteLine(kk.cena);
                            Console.SetCursorPosition(61, i + 3);
                            Console.WriteLine(kk.cena);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
            }
        }
        public void sklad(string login, string roli)
        {
            do
            {
                string hh = "sklad.json";
                List<Sklad> sklad = SerilDesir.Desir<List<Sklad>>(hh) ?? new List<Sklad>();
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
                Console.SetCursorPosition(97, 3);
                Console.WriteLine("F1 - добавить запись");
                Console.SetCursorPosition(97, 4);
                Console.WriteLine("F2 - Найти запись");
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("     Id          Название          Цена за штуку         Количество на складе");
                try
                {

                    for (int i = 0; i < sklad.Count; i++)
                    {
                        Console.SetCursorPosition(5, i + 3);
                        Console.WriteLine(sklad[i].id);
                        Console.SetCursorPosition(20, i + 3);
                        Console.WriteLine(sklad[i].name);
                        Console.SetCursorPosition(38, i + 3);
                        Console.WriteLine(sklad[i].cena);
                        Console.SetCursorPosition(64, i + 3);
                        Console.WriteLine(sklad[i].colvovsklad);
                    }
                }
                catch
                {

                }
                int position = 0;
                try
                {

                    position = Strelka.strelka(3, 3, sklad.Count + 3);
                }
                catch
                {
                    position = Strelka.strelka(3, 3, 3);
                }
                if (position == (int)Enum.F1)
                {
                    Console.Clear();
                    Console.SetCursorPosition(58, 0);
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
                    Create();
                }
                else if (position == (int)Enum.Escape)
                {
                    break;
                }
                else if (position == (int)Enum.F2)
                {
                    Serch(login, hh,roli);
                }
                else
                {
                    Read(position, hh, login, roli);
                }

            }while (true);
        }
    }
}

