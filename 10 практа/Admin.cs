using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace _10_практа
{
    internal class Admin : CRUDS
    {
        public Porol Vibor = new Porol();
        public void Delete(string hh)
        {
            List<Porol> list2 = SerilDesir.Desir<List<Porol>>(hh);
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i].id == Vibor.id & list2[i].porol == Vibor.porol & list2[i].rol == Vibor.rol & list2[i].login == Vibor.login)
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
            Console.WriteLine($"  Логин: {Vibor.login}");
            Console.WriteLine($"  Пароль: {Vibor.porol}");
            Console.WriteLine($"  Роль: {Vibor.rol}");
            Console.SetCursorPosition(97, 3);
            Console.WriteLine("0 - Администратор");
            Console.SetCursorPosition(97, 4);
            Console.WriteLine("1 - Кассир");
            Console.SetCursorPosition(97, 5);
            Console.WriteLine("2 - Кадровик");
            Console.SetCursorPosition(97, 6);
            Console.WriteLine("3 - Склад-менеджер");
            Console.SetCursorPosition(97, 7);
            Console.WriteLine("4 - Бухгалтер");
            Console.SetCursorPosition(97, 9);
            Console.WriteLine("S - Сохранить изменения");
            Console.SetCursorPosition(97, 10);
            Console.WriteLine("Escape-Вернуться в меню");
            List<Porol> list2 = SerilDesir.Desir<List<Porol>>(hh);
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i].id == Vibor.id & list2[i].porol == Vibor.porol & list2[i].rol == Vibor.rol & list2[i].login == Vibor.login)
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
                        Console.SetCursorPosition(6, 2);
                        Console.WriteLine("                             ");
                        Console.SetCursorPosition(6, 2);
                        string id = Console.ReadLine();
                        Vibor.id = id;
                        break;
                    case 3:
                        Console.SetCursorPosition(9, 3);
                        Console.WriteLine("                             ");
                        Console.SetCursorPosition(9, 3);
                        string log = Console.ReadLine();
                        Vibor.login = log;
                        break;
                    case 4:
                        Console.SetCursorPosition(10, 4);
                        Console.WriteLine("                             ");
                        Console.SetCursorPosition(10, 4);
                        string por = Console.ReadLine();
                        Vibor.porol = por;
                        break;
                    case 5:
                        while (true)
                        {
                            Console.SetCursorPosition(8, 5);
                            Console.WriteLine("                                                 ");
                            Console.SetCursorPosition(8, 5);
                            position = Strelka.roli(8, 8, 8);
                            if (position == 0 || position == 1 || position == 2 || position == 3 || position == 4 )
                            {
                                Vibor.rol = position;
                                break;
                            }
                            else
                            {
                                Console.SetCursorPosition(8, 5);
                                Console.WriteLine("Внимательнее ознакомтесь со списком ролей");
                                Thread.Sleep(1500);
                            }
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
            Console.WriteLine("0 - Администратор");
            Console.SetCursorPosition(97, 4);
            Console.WriteLine("1 - Кассир");
            Console.SetCursorPosition(97, 5);
            Console.WriteLine("2 - Кадровик");
            Console.SetCursorPosition(97, 6);
            Console.WriteLine("3 - Склад-менеджер");
            Console.SetCursorPosition(97, 7);
            Console.WriteLine("4 - Бухгалтер");
            Console.SetCursorPosition(97, 9);
            Console.WriteLine("5 - Сохранить изменения");
            Console.SetCursorPosition(97, 10);
            Console.WriteLine("Escape-Вернуться в меню");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("  ID: ");
            Console.WriteLine("  Логин: ");
            Console.WriteLine("  Пороль: ");
            Console.WriteLine("  Роль: ");
            Porol adm = new Porol();
            int position = 0;
            while (position != (int)Enum.S)
            {
                position = Strelka.strelka(2, 2, 5);
                switch (position)
                {
                    case 2:
                        Console.SetCursorPosition(6, 2);
                        string id = Console.ReadLine();
                        adm.id = id;
                        break;
                    case 3:
                        Console.SetCursorPosition(9, 3);
                        string login = Console.ReadLine();
                        adm.login = login;
                        break;
                    case 4:
                        Console.SetCursorPosition(10, 4);
                        string porol = Console.ReadLine();
                        adm.porol = porol;
                        break;
                    case 5:
                        while (true)
                        {
                            Console.SetCursorPosition(8, 5);
                            Console.WriteLine("                                                 ");
                            Console.SetCursorPosition(8, 5);
                            position = Strelka.roli(8, 8, 8);
                            if (position == 0 || position == 1 || position == 2 || position == 3 || position == 4)
                            {
                                adm.rol = position;
                                break;
                            }
                            else
                            {
                                Console.SetCursorPosition(8, 5);
                                Console.WriteLine("Внимательнее ознакомтесь со списком ролей");
                                Thread.Sleep(3000);
                            }
                        }
                        break;
                    case 100:
                        return;
                }
            }
            string hh = "admin.json";
            List<Porol> list = SerilDesir.Desir<List<Porol>>(hh) ?? new List<Porol>();
            list.Add(adm);
            SerilDesir.Serialize(list, hh);
        }
        public void Read(int position, string hh, string login,string roli)
        {
            while (true)
            {

                List<Porol> admins = SerilDesir.Desir<List<Porol>>(hh);
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

                    Vibor.porol = admins[position - 3].porol;
                    Vibor.login = admins[position - 3].login;
                    Vibor.rol = admins[position - 3].rol;
                    Vibor.id = admins[position - 3].id;
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine($"  ID: {Vibor.id}");
                    Console.WriteLine($"  Логин: {Vibor.login}");
                    Console.WriteLine($"  Пароль: {Vibor.porol}");
                    Console.WriteLine($"  Роль: {Vibor.rol}");
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
                position = Strelka.strelka(2, 2, 5);
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
            for ( i = 0; i < 119; i++)
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
            Console.WriteLine("  ID\n  Логин\n  Пороль\n  Роль");
            int position = Strelka.strelka(3, 3, 6);
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("Введите значение для поиска: ");
            var znach = Console.ReadLine();
            Porol kk = new Porol();
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
            Console.WriteLine("     Id              Логин              Пороль              Роль");
            i = 0;
            switch (position)
            {
                case 3:
                    List<Porol> list2 = SerilDesir.Desir<List<Porol>>(hh);
                    foreach (var item in list2)
                    {
                        if (item.id == znach)
                        {           
                            kk.id = item.id;
                            kk.porol = item.porol;
                            kk.login = item.login;
                            kk.rol=item.rol;
                            Console.SetCursorPosition(5, i+3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(23, i +3);
                            Console.WriteLine(kk.login);
                            Console.SetCursorPosition(43, i+3);
                            Console.WriteLine(kk.porol);
                            Console.SetCursorPosition(61, i+3);
                            Console.WriteLine(kk.rol);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i+2);
                    Read(position, hh, login, roli);
                    break;
                case 4:
                    List<Porol> list3 = SerilDesir.Desir<List<Porol>>(hh);
                    foreach (var item in list3)
                    {
                        if (item.login == znach)
                        {
                            kk.id = item.id;
                            kk.porol = item.porol;
                            kk.login = item.login;
                            kk.rol = item.rol;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(23, i + 3);
                            Console.WriteLine(kk.login);
                            Console.SetCursorPosition(43, i + 3);
                            Console.WriteLine(kk.porol);
                            Console.SetCursorPosition(61, i + 3);
                            Console.WriteLine(kk.rol);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
                case 5:
                    List<Porol> list4 = SerilDesir.Desir<List<Porol>>(hh);
                    foreach (var item in list4)
                    {
                        if (item.porol == znach)
                        {
                            kk.id = item.id;
                            kk.porol = item.porol;
                            kk.login = item.login;
                            kk.rol = item.rol;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(23, i + 3);
                            Console.WriteLine(kk.login);
                            Console.SetCursorPosition(43, i + 3);
                            Console.WriteLine(kk.porol);
                            Console.SetCursorPosition(61, i + 3);
                            Console.WriteLine(kk.rol);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
                case 6:
                    List<Porol> list5 = SerilDesir.Desir<List<Porol>>(hh);
                    foreach (var item in list5)
                    {
                        int znach1 = Convert.ToInt16(znach);
                        if (item.rol == znach1)
                        {
                            kk.id = item.id;
                            kk.porol = item.porol;
                            kk.login = item.login;
                            kk.rol = item.rol;
                            Console.SetCursorPosition(5, i + 3);
                            Console.WriteLine(kk.id);
                            Console.SetCursorPosition(23, i + 3);
                            Console.WriteLine(kk.login);
                            Console.SetCursorPosition(43, i + 3);
                            Console.WriteLine(kk.porol);
                            Console.SetCursorPosition(61, i + 3);
                            Console.WriteLine(kk.rol);
                            i++;
                        }
                    }
                    position = Strelka.strelka(3, 3, i + 2);
                    Read(position, hh, login, roli);
                    break;
            }
        }
        public void admin(string login, string roli)
        {
            do
            {
                string hh = "admin.json";
                List<Porol> adm = SerilDesir.Desir<List<Porol>>(hh);
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
                Console.WriteLine("     Id              Логин              Пороль              Роль");
                try
                {

                    for (int i = 0; i < adm.Count; i++)
                    {
                        Console.SetCursorPosition(5, i + 3);
                        Console.WriteLine(adm[i].id);
                        Console.SetCursorPosition(23, i + 3);
                        Console.WriteLine(adm[i].login);
                        Console.SetCursorPosition(43, i + 3);
                        Console.WriteLine(adm[i].porol);
                        Console.SetCursorPosition(61, i + 3);
                        Console.WriteLine(adm[i].rol);
                    }
                }
                catch
                {

                }
                int position = 0;
                try
                {
                    position = Strelka.strelka(3, 3, adm.Count + 2);
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
                    for (int i= 0; i < 119; i++)
                    {
                        Console.SetCursorPosition(i, 1);
                        Console.WriteLine("-");
                    }
                    for (int i = 2; i < 15; i++)
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
                    Serch(login,hh,roli);
                }
                else
                {
                    Read(position, hh, login,roli);
                }
            } while (true);
        }
    }
    //Porol Vibor = new Porol();
    //public void Update(string hh, string login)
    //{
    //    Console.Clear();
    //    Console.SetCursorPosition(48, 0);
    //    Console.WriteLine($"Добро пожаловать {login}!");
    //    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
    //    for (int i = 2; i < 15; i++)
    //    {
    //        Console.SetCursorPosition(95, i);
    //        Console.WriteLine("|");
    //    }
    //    Console.SetCursorPosition(0, 2);
    //    Console.WriteLine($"  ID: {Vibor.id}");
    //    Console.WriteLine($"  Логин: {Vibor.login}");
    //    Console.WriteLine($"  Пароль: {Vibor.porol}");
    //    Console.WriteLine($"  Роль: {Vibor.rol}");
    //    Console.SetCursorPosition(97, 3);
    //    Console.WriteLine("0 - Администратор");
    //    Console.SetCursorPosition(97, 4);
    //    Console.WriteLine("1 - Кассир");
    //    Console.SetCursorPosition(97, 5);
    //    Console.WriteLine("2 - Кадровик");
    //    Console.SetCursorPosition(97, 6);
    //    Console.WriteLine("3 - Склад-менеджер");
    //    Console.SetCursorPosition(97, 7);
    //    Console.WriteLine("4 - Бухгалтер");
    //    Console.SetCursorPosition(97, 9);
    //    Console.WriteLine("5 - Сохранить изменения");
    //    Console.SetCursorPosition(97, 10);
    //    Console.WriteLine("Escape-Вернуться в меню");
    //    var cs = Vibor.id;
    //    List<Porol> list2 = SerilDesir.Desir<List<Porol>>(hh);
    //    for (int i = 0; i < list2.Count; i++)
    //    {
    //        if (list2[i].id == Vibor.id & list2[i].porol == Vibor.porol & list2[i].rol == Vibor.rol & list2[i].login == Vibor.login)
    //        {
    //            list2.Remove(list2[i]);
    //        }
    //    }
    //    int position = 1;
    //    while (position != (int)Enum.S)
    //    {
    //        position = Strelka.strelka(2, 2, 5);
    //        switch (position)
    //        {
    //            case 2:
    //                Console.SetCursorPosition(6, 2);
    //                Vibor.id = null;                 
    //                string id = Console.ReadLine();
    //                Vibor.id = id;
    //                break;
    //            case 3:
    //                Console.SetCursorPosition(9, 3);
    //                string log = Console.ReadLine();
    //                Vibor.login = log;
    //                break;
    //            case 4:
    //                Console.SetCursorPosition(10, 4);
    //                string por = Console.ReadLine();
    //                Vibor.porol = por;
    //                break;
    //            case 5:
    //                Console.SetCursorPosition(8, 5);
    //                string rols = Console.ReadLine();
    //                Vibor.rol = rols;
    //                break;
    //            case 100:
    //                return;
    //        }
    //    }
    //    list2.Add(Vibor);
    //    SerilDesir.Serialize(list2, hh);
    //}
    //public void Delete(string hh)
    //{
    //    List<Porol> list2 = SerilDesir.Desir<List<Porol>>(hh);
    //    for (int i =0;i<list2.Count;i++)
    //    {
    //        if (list2[i].id == Vibor.id & list2[i].porol == Vibor.porol & list2[i].rol==Vibor.rol & list2[i].login == Vibor.login)
    //        {
    //            list2.Remove(list2[i]);
    //        }
    //    }
    //    SerilDesir.Serialize(list2, hh);
    //}
    //public void Create()
    //{
    //    Console.SetCursorPosition(97, 3);
    //    Console.WriteLine("0 - Администратор");
    //    Console.SetCursorPosition(97, 4);
    //    Console.WriteLine("1 - Кассир");
    //    Console.SetCursorPosition(97, 5);
    //    Console.WriteLine("2 - Кадровик");
    //    Console.SetCursorPosition(97, 6);
    //    Console.WriteLine("3 - Склад-менеджер");
    //    Console.SetCursorPosition(97, 7);
    //    Console.WriteLine("4 - Бухгалтер");
    //    Console.SetCursorPosition(97, 9);
    //    Console.WriteLine("S - Сохранить изменения");
    //    Console.SetCursorPosition(97, 10);
    //    Console.WriteLine("Escape-Вернуться в меню");
    //    Console.SetCursorPosition(0, 2);
    //    Console.WriteLine("  Введите id: ");
    //    Console.SetCursorPosition(0, 3);
    //    Console.WriteLine("  Введите логин: ");
    //    Console.SetCursorPosition(0, 4);
    //    Console.WriteLine("  Введите пороль: ");
    //    Console.SetCursorPosition(0, 5);
    //    Console.WriteLine("  Введите роль: ");
    //    Porol porol = new Porol();
    //    int position = 0;
    //    while (position != (int)Enum.S)
    //    {
    //        position = Strelka.strelka(2, 2, 5);
    //        switch (position)
    //        {
    //            case 2:
    //                Console.SetCursorPosition(15, 2);

    //                string id = Console.ReadLine();
    //                porol.id = id;
    //                break;
    //            case 3:
    //                Console.SetCursorPosition(16, 3);
    //                string log = Console.ReadLine();
    //                porol.login = log;
    //                break;
    //            case 4:
    //                Console.SetCursorPosition(17, 4);
    //                string por = Console.ReadLine();
    //                porol.porol = por;
    //                break;
    //            case 5:
    //                Console.SetCursorPosition(15, 5);
    //                string rols = Console.ReadLine();
    //                porol.rol = rols;
    //                break;
    //            case 100:
    //                return;
    //        }
    //    }
    //    string hh = "gg.json";
    //    List<Porol> list = SerilDesir.Desir<List<Porol>>(hh);
    //    list.Add(porol);
    //    SerilDesir.Serialize(list, hh);
    //}
    //public void Serch(string login, string hh)
    //{
    //    Console.Clear();
    //    Console.SetCursorPosition(48, 0);
    //    Console.WriteLine($"Добро пожаловать {login}!");
    //    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
    //    for (int i = 2; i < 15; i++)
    //    {
    //        Console.SetCursorPosition(95, i);
    //        Console.WriteLine("|");
    //    }
    //    Console.SetCursorPosition(0, 2);
    //    Console.WriteLine("Выберите, по какому пункту вы хотите произвести поиск:");
    //    Console.WriteLine("  ID\n  Логин\n  Пороль\n  Роль");
    //    int position = Strelka.strelka(3, 3, 6);
    //    Console.SetCursorPosition(0, 8);
    //    Console.WriteLine("Введите значение для поиска: ");
    //    var znach = Console.ReadLine();
    //    switch (position)
    //    {
    //        case 3:
    //            List<Porol> list2 = SerilDesir.Desir<List<Porol>>(hh);
    //            for (int i = 0; i < list2.Count; i++)
    //            {
    //                if (list2[i].id == znach)
    //                {
    //                    Console.WriteLine(list2[i].id);
    //                }
    //            }
    //            break; 
    //        case 4:
    //            break; 
    //        case 5:
    //            break;
    //        case 6:
    //            break;
    //    }
    //}
    //public void Read(int position, string hh, string login)
    //{
    //    List<Porol> admins = SerilDesir.Desir<List<Porol>>(hh);
    //    Console.Clear();
    //    Console.SetCursorPosition(48, 0);
    //    Console.WriteLine($"Добро пожаловать {login}!");
    //    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
    //    for (int i = 2; i < 15; i++)
    //    {
    //        Console.SetCursorPosition(95, i);
    //        Console.WriteLine("|");
    //    }
    //    Vibor.porol = admins[position - 3].porol;
    //    Vibor.login = admins[position - 3].login;
    //    Vibor.rol = admins[position - 3].rol;
    //    Vibor.id = admins[position - 3].id;
    //    Console.SetCursorPosition(0, 2);
    //    Console.WriteLine($"  ID: {Vibor.id}");
    //    Console.WriteLine($"  Логин: {Vibor.login}");
    //    Console.WriteLine($"  Пароль: {Vibor.porol}");
    //    Console.WriteLine($"  Роль: {Vibor.rol}");
    //    Console.SetCursorPosition(97, 3);
    //    Console.WriteLine("F10-Изменить пункт");
    //    Console.SetCursorPosition(97, 4);
    //    Console.WriteLine("Del-Удалить запись");
    //    Console.SetCursorPosition(97, 5);
    //    Console.WriteLine("Escape-Вернуться в меню");
    //    position = Strelka.strelka(2, 2, 5);
    //    if (position == (int)Enum.F10)
    //    {
    //        Update(hh, login);
    //    }
    //    else if (position == (int)Enum.Del)
    //    {
    //        Delete(hh);
    //    }
    //    else if (position == (int)Enum.Escape)
    //    {

    //    }
    //}
    //public void admin(string login,  string rol)
    //{
    //    string hh = "gg.json";
    //    int position;
    //    List<Porol> admins = SerilDesir.Desir<List<Porol>>(hh);
    //    do
    //    {
    //        Console.Clear();
    //        Console.SetCursorPosition(48, 0);
    //        Console.WriteLine($"Добро пожаловать {login}!");
    //        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
    //        for (int i = 2; i < 15; i++)
    //        {
    //            Console.SetCursorPosition(95, i);
    //            Console.WriteLine("|");
    //        }
    //        Console.SetCursorPosition(97, 3);
    //        Console.WriteLine("F1 - добавить запись");
    //        Console.SetCursorPosition(97, 4);
    //        Console.WriteLine("F2 - Найти запись");
    //        Console.SetCursorPosition(0, 2);
    //        Console.WriteLine("     Id               Логин                   Пороль                 Роль");
    //        for (int i = 0; i < admins.Count;i++)
    //        {

    //                Console.SetCursorPosition(5, i+3);
    //                Console.WriteLine(admins[i].id);
    //                Console.SetCursorPosition(23, i+3);
    //                Console.WriteLine(admins[i].login);
    //                Console.SetCursorPosition(46, i + 3);
    //                Console.WriteLine(admins[i].porol);
    //                Console.SetCursorPosition(68, i + 3);
    //                Console.WriteLine(admins[i].rol);
    //        }
    //        position = Strelka.strelka(3, 3, admins.Count + 2);
    //        if (position == (int)Enum.F1)
    //        {
    //            Console.Clear();
    //            Console.SetCursorPosition(58,0);
    //            Console.SetCursorPosition(48, 0);
    //            Console.WriteLine($"Добро пожаловать {login}!");
    //            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
    //            for (int i = 2; i < 15; i++)
    //            {
    //                Console.SetCursorPosition(95, i);
    //                Console.WriteLine("|");
    //            }
    //            Create();
    //        }
    //        else if (position == (int)Enum.Enter)
    //        {
    //            Read(position,hh,login);
    //        }
    //        else if(position == (int)Enum.F2)
    //        {
    //            Serch(login,hh);
    //        }
    //    } while (true);
    //}
}


