using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_практа
{
    internal class Buxgalteryo: CRUDS
    {
        public Buxgalter Vibor = new Buxgalter();
        public void Delete(string hh)
        {
            List<Buxgalter> list2 = SerilDesir.Desir<List<Buxgalter>>(hh);
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i].id == Vibor.id & list2[i].name == Vibor.name & list2[i].cuma == Vibor.cuma & list2[i].vrema == Vibor.vrema & list2[i].pribavka == Vibor.pribavka)
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
            Console.WriteLine($"  Сумма: {Vibor.cuma}");
            Console.WriteLine($"  Время записи: {Vibor.vrema}");
            Console.WriteLine($"  Прибавка?: {Vibor.pribavka}");
            Console.SetCursorPosition(97, 3);
            Console.WriteLine("S - Сохранить изменения");
            Console.SetCursorPosition(97, 4);
            Console.WriteLine("Escape-Вернуться в меню");
            List<Buxgalter> list2 = SerilDesir.Desir<List<Buxgalter>>(hh);
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i].id == Vibor.id & list2[i].name == Vibor.name & list2[i].cuma == Vibor.cuma & list2[i].vrema == Vibor.vrema & list2[i].pribavka == Vibor.pribavka)
                {
                    list2.Remove(list2[i]);
                }
            }
            double kk = 0;
            int position = 1;
            while (position != (int)Enum.S)
            {
                position = Strelka.strelka(2, 2, 6);
                switch (position)
                {
                    case 2:
                        Console.SetCursorPosition(6, 2);
                        Console.WriteLine("                                   ");
                        Console.SetCursorPosition(6, 2);
                        string id = Console.ReadLine();
                        Vibor.id = id;
                        break;
                    case 3:
                        Console.SetCursorPosition(12, 3);
                        Console.WriteLine("                                   ");
                        Console.SetCursorPosition(12, 3);
                        string name = Console.ReadLine();
                        Vibor.name = name;
                        break;
                    case 4:
                        Console.SetCursorPosition(9, 4);
                        Console.WriteLine("                                   ");
                        Console.SetCursorPosition(9, 4);
                        double cumma = Convert.ToDouble(Console.ReadLine());
                        Vibor.cuma = cumma;
                        break;
                    case 6:
                        Console.SetCursorPosition(13, 6);
                        Console.WriteLine("                                   ");
                        Console.SetCursorPosition(13, 6);
                        bool pribav = Convert.ToBoolean(Console.ReadLine());
                        Vibor.pribavka = pribav;

                        List<Buxgalter> bux = SerilDesir.Desir<List<Buxgalter>>(hh) ?? new List<Buxgalter>();
                        foreach (var item in bux)
                        {
                            if (item.pribavka == false)
                            {
                                item.itog = item.itog - item.cuma;

                            }
                            else if (item.pribavka == true)
                            {
                                item.itog = item.itog + item.cuma;
                            }
                            kk = item.itog;
                        }
                        break;
                    case 100:
                        return;
                }
                Console.SetCursorPosition(15, 5);
                Vibor.vrema = DateTime.Now;
                Vibor.itog = kk;
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
            Console.WriteLine("  Название: ");
            Console.WriteLine("  Сумма: ");
            Console.WriteLine("  Время записи: ");
            Console.WriteLine("  Прибавка?: ");
            Buxgalter buxa = new Buxgalter();
            int position = 0;
            double kk = 0;
            string hh = "buxa.json";
            while (position != (int)Enum.S)
            {
                position = Strelka.strelka(2, 2, 6);
                switch (position)
                {
                    case 2:
                        Console.SetCursorPosition(6, 2);
                        Console.WriteLine("                                   ");
                        Console.SetCursorPosition(6, 2);
                        string id = Console.ReadLine();
                        buxa.id = id;
                        break;
                    case 3:
                        Console.SetCursorPosition(12, 3);
                        Console.WriteLine("                                   ");
                        Console.SetCursorPosition(12, 3);
                        string name = Console.ReadLine();
                        buxa.name = name;
                        break;
                    case 4:
                        Console.SetCursorPosition(9, 4);
                        Console.WriteLine("                                   ");
                        Console.SetCursorPosition(9, 4);
                        double cumma = Convert.ToDouble(Console.ReadLine());
                        buxa.cuma = cumma;
                        break;
                    case 6:
                        Console.SetCursorPosition(13, 6);
                        Console.WriteLine("                                   ");
                        Console.SetCursorPosition(13, 6);
                        bool pribav = Convert.ToBoolean(Console.ReadLine());
                        buxa.pribavka = pribav;
                        
                        List<Buxgalter> bux = SerilDesir.Desir<List<Buxgalter>>(hh) ?? new List<Buxgalter>();
                        foreach (var item in bux)
                        {
                            if (item.pribavka == false)
                            {
                                item.itog = item.itog - item.cuma;

                            }
                            else if (item.pribavka == true)
                            {
                                item.itog = item.itog + item.cuma;
                            }
                            kk = item.itog;
                        }
                        break;
                    case 100:
                        return;
                }
                Console.SetCursorPosition(15, 5);
                buxa.vrema = DateTime.Now;
                buxa.itog = kk;
            }
            List<Buxgalter> list = SerilDesir.Desir<List<Buxgalter>>(hh) ?? new List<Buxgalter>(); ;
            list.Add(buxa);
            SerilDesir.Serialize(list, hh);
        }
        public void Read(int position, string hh, string login, string roli)
        {
            while (true)
            {
                List<Buxgalter> sklad = SerilDesir.Desir<List<Buxgalter>>(hh);
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
                    Vibor.cuma = sklad[position - 3].cuma;
                    Vibor.vrema = sklad[position - 3].vrema;
                    Vibor.pribavka = sklad[position - 3].pribavka;
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine($"  ID: {Vibor.id}");
                    Console.WriteLine($"  Имя: {Vibor.name}");
                    Console.WriteLine($"  Сумма: {Vibor.cuma}");
                    Console.WriteLine($"  Время записи: {Vibor.vrema}");
                    Console.WriteLine($"  Прибавка?: {Vibor.pribavka}");
                    Console.SetCursorPosition(97, 3);
                    Console.WriteLine("F10-Изменить пункт");
                    Console.SetCursorPosition(97, 4);
                    Console.WriteLine("Del-Удалить запись");
                    Console.SetCursorPosition(97, 5);
                    Console.WriteLine("Escape-Вернуться в меню");
                }
                catch
                {
                    return;
                }
                position = Strelka.strelka(2, 2, 6);
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
            Console.WriteLine("  ID\n  Название\n  Сумма\n  Прибавка?");
            int position = Strelka.strelka(3, 3, 6);
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("Введите значение для поиска: ");
            var znach = Console.ReadLine();
            Buxgalter kk = new Buxgalter();
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
            Console.WriteLine("     Id          Название          Сумма         Время записи              Прибавка?");
            i = 0;
            switch (position)
            {
                case 3:
                    List<Buxgalter> list2 = SerilDesir.Desir<List<Buxgalter>>(hh);
                    foreach (var item in list2)
                    {
                        if (item.id == znach)
                        {
                            kk.id = item.id;
                            kk.name = item.name;
                            kk.cuma = item.cuma;
                            kk.vrema = item.vrema;
                            kk.pribavka = item.pribavka;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(20, i + 3);
                            Console.WriteLine(kk.name);
                            Console.SetCursorPosition(37, i + 3);
                            Console.WriteLine(kk.cuma);
                            Console.SetCursorPosition(45, i + 3);
                            Console.WriteLine(kk.vrema);
                            Console.SetCursorPosition(78, i + 3);
                            Console.WriteLine(kk.pribavka);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
                case 4:
                    List<Buxgalter> list3 = SerilDesir.Desir<List<Buxgalter>>(hh);
                    foreach (var item in list3)
                    {
                        if (item.name == znach)
                        {
                            kk.id = item.id;
                            kk.name = item.name;
                            kk.cuma = item.cuma;
                            kk.vrema = item.vrema;
                            kk.pribavka = item.pribavka;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(23, i + 3);
                            Console.WriteLine(kk.name);
                            Console.SetCursorPosition(43, i + 3);
                            Console.WriteLine(kk.cuma);
                            Console.SetCursorPosition(61, i + 3);
                            Console.WriteLine(kk.vrema);
                            Console.SetCursorPosition(69, i + 3);
                            Console.WriteLine(kk.pribavka);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
                case 5:
                    double znach1 = Convert.ToDouble(znach);
                    List<Buxgalter> list1 = SerilDesir.Desir<List<Buxgalter>>(hh);
                    foreach (var item in list1)
                    {
                        if (item.cuma == znach1)
                        {
                            kk.id = item.id;
                            kk.name = item.name;
                            kk.cuma = item.cuma;
                            kk.vrema = item.vrema;
                            kk.pribavka = item.pribavka;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(23, i + 3);
                            Console.WriteLine(kk.name);
                            Console.SetCursorPosition(43, i + 3);
                            Console.WriteLine(kk.cuma);
                            Console.SetCursorPosition(61, i + 3);
                            Console.WriteLine(kk.vrema);
                            Console.SetCursorPosition(69, i + 3);
                            Console.WriteLine(kk.pribavka);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
                case 6:
                    bool znach2 = Convert.ToBoolean(znach);
                    List<Buxgalter> list0 = SerilDesir.Desir<List<Buxgalter>>(hh);
                    foreach (var item in list0)
                    {
                        if (item.pribavka == znach2)
                        {
                            kk.id = item.id;
                            kk.name = item.name;
                            kk.cuma = item.cuma;
                            kk.vrema = item.vrema;
                            kk.pribavka = item.pribavka;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(23, i + 3);
                            Console.WriteLine(kk.name);
                            Console.SetCursorPosition(43, i + 3);
                            Console.WriteLine(kk.cuma);
                            Console.SetCursorPosition(61, i + 3);
                            Console.WriteLine(kk.vrema);
                            Console.SetCursorPosition(69, i + 3);
                            Console.WriteLine(kk.pribavka);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
            }
        }

        public void Buxa(string login, string roli)
        {
            do
            {
                string hh = "buxa.json";
                List<Buxgalter> bux = SerilDesir.Desir<List<Buxgalter>>(hh) ?? new List<Buxgalter>();
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
                Console.WriteLine("     Id          Название          Сумма         Время записи              Прибавка?");
                try
                {
                    int i = 0;
                    for (i = 0; i < bux.Count;)
                    {
                        Console.SetCursorPosition(5, i + 3);
                        Console.WriteLine(bux[i].id);
                        Console.SetCursorPosition(20, i + 3);
                        Console.WriteLine(bux[i].name);
                        Console.SetCursorPosition(37, i + 3);
                        Console.WriteLine(bux[i].cuma);
                        Console.SetCursorPosition(46, i + 3);
                        Console.WriteLine(bux[i].vrema);
                        Console.SetCursorPosition(77, i + 3);
                        Console.WriteLine(bux[i].pribavka);
                        i++;
                    }
                    List<Buxgalter> buxa = SerilDesir.Desir<List<Buxgalter>>(hh) ?? new List<Buxgalter>();
                    double kk = 0;
                    foreach (var item in buxa)
                    {
                        if (item.pribavka == false)
                        {
                            item.itog = item.itog - item.cuma;

                        }
                        else if (item.pribavka == true)
                        {
                            item.itog = item.itog + item.cuma;
                        }
                        kk = item.itog;
                    }
                    for (int j = 0; j < 94; j++)
                    {
                        Console.SetCursorPosition(j,i+3);
                        Console.WriteLine("-");
                    }
                    Console.WriteLine($"Итог: {kk}");

                }
                catch
                {
                    for (int j = 0; j < 94; j++)
                    {
                        Console.SetCursorPosition(j,3);
                        Console.WriteLine("-");
                    }
                    double kk = 0;
                    Console.WriteLine($"Итог: {kk}");
                }
                int position = 0;
                try
                {

                    position = Strelka.strelka(3, 3, bux.Count + 2);
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
                else if (position== (int)Enum.F2)
                {
                    Serch(login, hh,roli);
                }
                else
                {
                    Read(position, hh, login,roli);
                }
            }while (true);
        }
    }
}

