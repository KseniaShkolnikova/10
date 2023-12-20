using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_практа
{
    internal class Kadrovik : CRUDS
    {
        public Kladmen Vibor = new Kladmen();
        public void Delete( string hh)
        {
            List<Kladmen> list2 = SerilDesir.Desir<List<Kladmen>>(hh);
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i].id == Vibor.id & list2[i].name == Vibor.name & list2[i].zp == Vibor.zp & list2[i].dolznost == Vibor.dolznost)
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
            Console.WriteLine($"  Фамилия: {Vibor.surname}");
            Console.WriteLine($"  Имя: {Vibor.name}");
            Console.WriteLine($"  Отчество: {Vibor.midlename}");
            Console.WriteLine($"  День рождения: {Vibor.dr}");
            Console.WriteLine($"  Серия и номер паспорта: {Vibor.passport}");
            Console.WriteLine($"  Должность: {Vibor.dolznost}");
            Console.WriteLine($"  Зарплата: {Vibor.zp}");
            Console.WriteLine($"  Аккаунт сотрудника: {Vibor.akk}");
            Console.SetCursorPosition(97, 3);
            Console.WriteLine("S - Сохранить изменения");
            Console.SetCursorPosition(97, 4);
            Console.WriteLine("Escape-Вернуться в меню");
            List<Kladmen> list2 = SerilDesir.Desir<List<Kladmen>>(hh);
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i].id == Vibor.id & list2[i].name == Vibor.name & list2[i].zp == Vibor.zp & list2[i].dolznost == Vibor.dolznost)
                {
                    list2.Remove(list2[i]);
                }
            }
            int position = 1;
            while (position != (int)Enum.S)
            {
                position = Strelka.strelka(2, 2, 10);
                switch (position)
                {
                    case 2:
                        Console.SetCursorPosition(6, 2);
                        Console.WriteLine("                                     ");
                        Console.SetCursorPosition(6, 2);
                        string id = Console.ReadLine();
                        Vibor.id = id;
                        break;
                    case 3:
                        Console.SetCursorPosition(11, 3);
                        Console.WriteLine("                                     ");
                        Console.SetCursorPosition(11, 3);
                        string surname = Console.ReadLine();
                        Vibor.surname = surname;
                        break;
                    case 4:
                        Console.SetCursorPosition(7, 4);
                        Console.WriteLine("                                     ");
                        Console.SetCursorPosition(7, 4);
                        string name = Console.ReadLine();
                        Vibor.name = name;
                        break;
                    case 5:
                        Console.SetCursorPosition(12, 5);
                        Console.WriteLine("                                     ");
                        Console.SetCursorPosition(12, 5);
                        string midlename = Console.ReadLine();
                        Vibor.midlename = midlename;
                        break;
                    case 6:
                        Console.SetCursorPosition(17, 6);
                        Console.WriteLine("                                     ");
                        Console.SetCursorPosition(17, 6);
                        string dr = Console.ReadLine();
                        Vibor.dr = dr;
                        break;
                    case 7:
                        Console.SetCursorPosition(26, 7);
                        Console.WriteLine("                                     ");
                        Console.SetCursorPosition(26, 7);
                        string pasport = Console.ReadLine();
                        Vibor.passport = pasport;
                        break;
                    case 8:
                        Console.SetCursorPosition(13, 8);
                        Console.WriteLine("                                     ");
                        Console.SetCursorPosition(13, 8);
                        string dolznost = Console.ReadLine();
                        Vibor.dolznost = dolznost;
                        break;
                    case 9:
                        while (true)
                        {
                            double skvazimabzazabza = 0;
                            Console.SetCursorPosition(12, 9);
                            Console.WriteLine("                                     ");
                            Console.SetCursorPosition(12, 9);
                            try
                            {
                                skvazimabzazabza = Convert.ToDouble(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.SetCursorPosition(12, 9);
                                Console.WriteLine("Нужно вводить число");
                                Thread.Sleep(1000);
                            }
                            Vibor.zp = skvazimabzazabza;

                        }
                        break;
                    case 10:
                        string akk = "";
                        while (true)
                        {
                            Console.SetCursorPosition(22, 10);
                            Console.WriteLine("                                     ");
                            Console.SetCursorPosition(22, 10);
                            akk = Console.ReadLine();
                            List<Porol> admin = SerilDesir.Desir<List<Porol>>("admin.json");
                            List<Kladmen> klad = SerilDesir.Desir<List<Kladmen>>("kadrovik.json");
                            foreach (var item1 in admin)
                            {
                                foreach(var item in klad)
                                {

                                    if (Vibor.akk == akk || akk == item.akk )
                                    {
                                        Console.SetCursorPosition(22, 10);
                                        Console.WriteLine("Аккаунт уже привязан");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("                                     ");
                                    }
                                }
                                
                            }
                            Vibor.akk = akk;
                            break;                            
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
            Console.WriteLine("  Фамилия: ");
            Console.WriteLine("  Имя: ");
            Console.WriteLine("  Отчество: ");
            Console.WriteLine("  День рождения: ");
            Console.WriteLine("  Серия и номер паспорта: ");
            Console.WriteLine("  Должность: ");
            Console.WriteLine("  Зарплата: ");
            Console.WriteLine("  Аккаунт сотрудника: ");
            Kladmen kladovik = new Kladmen();
            int position = 0;
            while (position != (int)Enum.S)
            {
                position = Strelka.strelka(2, 2, 10);
                switch (position)
                {
                    case 2:
                        Console.SetCursorPosition(6, 2);
                        Console.WriteLine("                                     ");
                        Console.SetCursorPosition(6, 2);
                        string id = Console.ReadLine();
                        kladovik.id = id;
                        break;
                    case 3:
                        Console.SetCursorPosition(11, 3);
                        Console.WriteLine("                                     ");
                        Console.SetCursorPosition(11, 3);
                        string surname = Console.ReadLine();
                        kladovik.surname = surname;
                        break;
                    case 4:
                        Console.SetCursorPosition(7, 4);
                        Console.WriteLine("                                     ");
                        Console.SetCursorPosition(7, 4);
                        string name = Console.ReadLine();
                        kladovik.name = name;
                        break;
                    case 5:
                        Console.SetCursorPosition(12, 5);
                        Console.WriteLine("                                     ");
                        Console.SetCursorPosition(12, 5);
                        string midlename = Console.ReadLine();
                        kladovik.midlename = midlename;
                        break;
                    case 6:
                        Console.SetCursorPosition(17, 6);
                        Console.WriteLine("                                     ");
                        Console.SetCursorPosition(17, 6);
                        string dr = Console.ReadLine();
                        kladovik.dr = dr;
                        break;
                    case 7:
                        Console.SetCursorPosition(26, 7);
                        Console.WriteLine("                                     ");
                        Console.SetCursorPosition(26, 7);
                        string pasport = Console.ReadLine();
                        kladovik.passport = pasport;
                        break;
                    case 8:
                        Console.SetCursorPosition(13, 8);
                        Console.WriteLine("                                     ");
                        Console.SetCursorPosition(13, 8);
                        string dolznost = Console.ReadLine();
                        kladovik.dolznost = dolznost;
                        break;
                    case 9:
                        Console.SetCursorPosition(12, 9);
                        Console.WriteLine("                                     ");
                        Console.SetCursorPosition(12, 9);
                        double zp = Convert.ToDouble(Console.ReadLine());
                        kladovik.zp = zp;
                        break;
                    case 10:
                        string akk = "";
                        while (true)
                        {
                            Console.SetCursorPosition(22, 10);
                            Console.WriteLine("                                     ");
                            Console.SetCursorPosition(22, 10);
                            akk = Console.ReadLine();
                            List<Porol> admin = SerilDesir.Desir<List<Porol>>("admin.json");
                            List<Kladmen> klad = SerilDesir.Desir<List<Kladmen>>("kadrovik.json");
                            foreach (var item1 in admin)
                            {
                                foreach (var item in klad)
                                {

                                    if (Vibor.akk == akk || akk == item.akk)
                                    {
                                        Console.SetCursorPosition(22, 10);
                                        Console.WriteLine("Аккаунт уже привязан");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("                                     ");
                                    }
                                }

                            }
                            kladovik.akk = akk;
                            break;
                        }
                        break;
                    case 100:
                        return;
                }
            }
            string hh = "kadrovik.json";
            List<Kladmen> list = SerilDesir.Desir<List<Kladmen>>(hh) ?? new List<Kladmen>();
            list.Add(kladovik);
            SerilDesir.Serialize(list, hh);
        }
        public void Read(int position, string hh, string login,string roli)
        {
            while (true)
            {

                List<Kladmen> klad = SerilDesir.Desir<List<Kladmen>>(hh);
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

                    Vibor.id = klad[position - 3].id;
                    Vibor.surname = klad[position - 3].surname;
                    Vibor.name = klad[position - 3].name;
                    Vibor.midlename = klad[position - 3].midlename;
                    Vibor.dr = klad[position - 3].dr;
                    Vibor.passport = klad[position - 3].passport;
                    Vibor.dolznost = klad[position - 3].dolznost;
                    Vibor.zp = klad[position - 3].zp;
                    Vibor.akk = klad[position - 3].akk;
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine($"  ID: {Vibor.id}");
                    Console.WriteLine($"  Фамилия: {Vibor.surname}");
                    Console.WriteLine($"  Имя: {Vibor.name}");
                    Console.WriteLine($"  Отчество: {Vibor.midlename}");
                    Console.WriteLine($"  День рождения: {Vibor.dr}");
                    Console.WriteLine($"  Серия и номер паспорта: {Vibor.passport}");
                    Console.WriteLine($"  Должность: {Vibor.dolznost}");
                    Console.WriteLine($"  Зарплата: {Vibor.zp}");
                    Console.WriteLine($"  Аккаунт сотрудника: {Vibor.akk}");
                    Console.SetCursorPosition(97, 3);
                    Console.WriteLine("F10-Изменить пункт");
                    Console.SetCursorPosition(97, 4);
                    Console.WriteLine("Del-Удалить запись");
                    Console.SetCursorPosition(97, 5);
                    Console.WriteLine("Escape-Вернуться в меню");
                }
                catch
                {
                    break;
                }
                position = Strelka.strelka(2, 2, 10);
                if (position == (int)Enum.F10)
                {
                    Update(hh, login, roli);
                }
                else if (position == (int)Enum.Del)
                {
                    Delete( hh);
                }
                else if (position == (int)Enum.Escape)
                {
                    break;
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
            Console.WriteLine("  ID\n  Фамилия\n  Имя\n  Отчество\n  День рождения\n  Серия и номер паспорта\n  Должность\n  Зарплата\n  Аккаунт сотрудника");
            int position = Strelka.strelka(3, 3,12);
            Console.SetCursorPosition(0, 13);
            Console.WriteLine("Введите значение для поиска: ");
            var znach = Console.ReadLine();
            Kladmen kk = new Kladmen();
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
            Console.WriteLine("     Id          Фамилия          Имя         Отчество        Должность");
            i = 0;
            double znach1 = 0;
            switch (position)
            {
                case 3:
                    List<Kladmen> list2 = SerilDesir.Desir<List<Kladmen>>(hh);
                    foreach (var item in list2)
                    {
                        if (item.id == znach)
                        {
                            kk.id = item.id;
                            kk.surname = item.surname;
                            kk.name = item.name;
                            kk.midlename = item.midlename;
                            kk.akk = item.akk;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(20, i + 3);
                            Console.WriteLine(kk.surname);
                            Console.SetCursorPosition(35, i + 3);
                            Console.WriteLine(kk.name);
                            Console.SetCursorPosition(48, i + 3);
                            Console.WriteLine(kk.midlename);
                            Console.SetCursorPosition(65, i + 3);
                            Console.WriteLine(kk.akk);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
                case 4:
                    List<Kladmen> list3 = SerilDesir.Desir<List<Kladmen>>(hh);
                    foreach (var item in list3)
                    {
                        if (item.surname == znach)
                        {
                            kk.id = item.id;
                            kk.surname = item.surname;
                            kk.name = item.name;
                            kk.midlename = item.midlename;
                            kk.akk = item.akk;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(20, i + 3);
                            Console.WriteLine(kk.surname);
                            Console.SetCursorPosition(35, i + 3);
                            Console.WriteLine(kk.name);
                            Console.SetCursorPosition(48, i + 3);
                            Console.WriteLine(kk.midlename);
                            Console.SetCursorPosition(65, i + 3);
                            Console.WriteLine(kk.akk);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
                case 5:
                    List<Kladmen> list4 = SerilDesir.Desir<List<Kladmen>>(hh);
                    foreach (var item in list4)
                    {
                        if (item.name == znach)
                        {
                            kk.id = item.id;
                            kk.surname = item.surname;
                            kk.name = item.name;
                            kk.midlename = item.midlename;
                            kk.akk = item.akk;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(20, i + 3);
                            Console.WriteLine(kk.surname);
                            Console.SetCursorPosition(35, i + 3);
                            Console.WriteLine(kk.name);
                            Console.SetCursorPosition(48, i + 3);
                            Console.WriteLine(kk.midlename);
                            Console.SetCursorPosition(65, i + 3);
                            Console.WriteLine(kk.akk);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
                case 6:
                    List<Kladmen> list5 = SerilDesir.Desir<List<Kladmen>>(hh);
                    foreach (var item in list5)
                    {
                        if (item.midlename == znach)
                        {
                            kk.id = item.id;
                            kk.surname = item.surname;
                            kk.name = item.name;
                            kk.midlename = item.midlename;
                            kk.akk = item.akk;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(20, i + 3);
                            Console.WriteLine(kk.surname);
                            Console.SetCursorPosition(35, i + 3);
                            Console.WriteLine(kk.name);
                            Console.SetCursorPosition(48, i + 3);
                            Console.WriteLine(kk.midlename);
                            Console.SetCursorPosition(65, i + 3);
                            Console.WriteLine(kk.akk);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
                case 7:
                    List<Kladmen> list6 = SerilDesir.Desir<List<Kladmen>>(hh);
                    foreach (var item in list6)
                    {
                        if (item.dr == znach)
                        {
                            kk.id = item.id;
                            kk.surname = item.surname;
                            kk.name = item.name;
                            kk.midlename = item.midlename;
                            kk.akk = item.akk;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(20, i + 3);
                            Console.WriteLine(kk.surname);
                            Console.SetCursorPosition(35, i + 3);
                            Console.WriteLine(kk.name);
                            Console.SetCursorPosition(48, i + 3);
                            Console.WriteLine(kk.midlename);
                            Console.SetCursorPosition(65, i + 3);
                            Console.WriteLine(kk.akk);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
                case 8:
                    List<Kladmen> list7 = SerilDesir.Desir<List<Kladmen>>(hh);
                    foreach (var item in list7)
                    {
                        if (item.passport == znach)
                        {
                            kk.id = item.id;
                            kk.surname = item.surname;
                            kk.name = item.name;
                            kk.midlename = item.midlename;
                            kk.akk = item.akk;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(20, i + 3);
                            Console.WriteLine(kk.surname);
                            Console.SetCursorPosition(35, i + 3);
                            Console.WriteLine(kk.name);
                            Console.SetCursorPosition(48, i + 3);
                            Console.WriteLine(kk.midlename);
                            Console.SetCursorPosition(65, i + 3);
                            Console.WriteLine(kk.akk);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
                case 9:
                    List<Kladmen> listh = SerilDesir.Desir<List<Kladmen>>(hh);
                    foreach (var item in listh)
                    {
                        if (item.dolznost == znach)
                        {
                            kk.id = item.id;
                            kk.surname = item.surname;
                            kk.name = item.name;
                            kk.midlename = item.midlename;
                            kk.akk = item.akk;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(20, i + 3);
                            Console.WriteLine(kk.surname);
                            Console.SetCursorPosition(35, i + 3);
                            Console.WriteLine(kk.name);
                            Console.SetCursorPosition(48, i + 3);
                            Console.WriteLine(kk.midlename);
                            Console.SetCursorPosition(65, i + 3);
                            Console.WriteLine(kk.akk);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
                case 10:
                    List<Kladmen> lith = SerilDesir.Desir<List<Kladmen>>(hh);
                    foreach (var item in lith)
                    {
                        if (item.zp == znach1)
                        {
                            kk.id = item.id;
                            kk.surname = item.surname;
                            kk.name = item.name;
                            kk.midlename = item.midlename;
                            kk.akk = item.akk;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(20, i + 3);
                            Console.WriteLine(kk.surname);
                            Console.SetCursorPosition(35, i + 3);
                            Console.WriteLine(kk.name);
                            Console.SetCursorPosition(48, i + 3);
                            Console.WriteLine(kk.midlename);
                            Console.SetCursorPosition(65, i + 3);
                            Console.WriteLine(kk.akk);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
                case 11:
                    List<Kladmen> litha = SerilDesir.Desir<List<Kladmen>>(hh);
                    foreach (var item in litha)
                    {
                        if (item.akk == znach)
                        {
                            kk.id = item.id;
                            kk.surname = item.surname;
                            kk.name = item.name;
                            kk.midlename = item.midlename;
                            kk.akk = item.akk;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(20, i + 3);
                            Console.WriteLine(kk.surname);
                            Console.SetCursorPosition(35, i + 3);
                            Console.WriteLine(kk.name);
                            Console.SetCursorPosition(48, i + 3);
                            Console.WriteLine(kk.midlename);
                            Console.SetCursorPosition(65, i + 3);
                            Console.WriteLine(kk.akk);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
            }
        }
        public void kladmen(string login, string roli)
        {
            do
            {
                string hh = "kadrovik.json";
                List<Kladmen> klad = SerilDesir.Desir<List<Kladmen>>(hh);
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
                Console.WriteLine("     Id          Фамилия          Имя         Отчество        Должность");
                try
                {

                    for (int i = 0; i < klad.Count; i++)
                    {
                        Console.SetCursorPosition(5, i + 3);
                        Console.WriteLine(klad[i].id);
                        Console.SetCursorPosition(18, i + 3);
                        Console.WriteLine(klad[i].surname);
                        Console.SetCursorPosition(34, i + 3);
                        Console.WriteLine(klad[i].name);
                        Console.SetCursorPosition(48, i + 3);
                        Console.WriteLine(klad[i].midlename);
                        Console.SetCursorPosition(66, i + 3);
                        Console.WriteLine(klad[i].dolznost);
                    }
                }
                catch
                {

                }
                int position = 0;
                try
                {

                    position = Strelka.strelka(3, 3, klad.Count+2);
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
                    Serch(login,hh,roli);
                }
                else
                {
                    Read(position, hh, login, roli);
                }

            } while (true);
        }
    }
}
