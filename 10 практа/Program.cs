namespace _10_практа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                string[] roli = { "Администратор", "Кассир", "Кадровик", "Склад-менеджер", "Бухгалтер" };
                Console.WriteLine("-----------------------------------------'Продуктовый магазин'Десяточка'-----------------------------------------");
                Console.WriteLine("  Логин: ");
                Console.WriteLine("  Пороль: ");
                Console.WriteLine("  Авторизоваться");
                List<char> list = new List<char>();
                List<char> list1 = new List<char>();
                int position = 0;
                while (position != 3)
                {
                    position = Strelka.strelka(1, 1, 3);
                    if (position == (int)Enum.Escape)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(55, 7);
                        Console.WriteLine("пПока пока!");
                        Environment.Exit(0);
                    }
                    else if (position == 1)
                    {
                        for (int i = 9; i < 100;)
                        {
                            Console.SetCursorPosition(i, 1);
                            ConsoleKeyInfo uservvodit = Console.ReadKey();
                            if (uservvodit.Key == ConsoleKey.Backspace)
                            {
                                try
                                {

                                    list1.Remove(list1.Last());
                                    i = i - 1;
                                    Console.SetCursorPosition(i, 1);
                                    Console.WriteLine(" ");
                                }
                                catch
                                {
                                    Console.SetCursorPosition(9, 1);
                                    Console.WriteLine("                    ");
                                    Console.SetCursorPosition(9, 1);
                                    Console.WriteLine("Слишком много стираете");
                                    Thread.Sleep(1000);
                                    Console.SetCursorPosition(9, 1);
                                    Console.WriteLine("                    ");
                                   
                                }
                            }
                            else if (uservvodit.Key == ConsoleKey.Enter)
                            {
                                break;
                            }
                            else
                            {
                                char kk = Convert.ToChar(uservvodit.KeyChar);
                                list1.Add(kk);
                                i = i + 1;
                            }
                        }
                    }
                    else if (position == 2)
                    {                   
                        for (int i = 10; i < 100;)
                        {
                            Console.SetCursorPosition(i, 2);
                            ConsoleKeyInfo uservvodit1 = Console.ReadKey(true);
                            if (uservvodit1.Key == ConsoleKey.Backspace)
                            {
                                try
                                {

                                    list.Remove(list.Last());
                                    i = i - 1;
                                    Console.SetCursorPosition(i, 2);
                                    Console.WriteLine(" ");
                                }
                                catch
                                {
                                    Console.SetCursorPosition(10, 2);
                                    Console.WriteLine("                    ");
                                    Console.SetCursorPosition(10, 2);
                                    Console.WriteLine("Слишком много стираете");
                                    Thread.Sleep(1000);
                                    Console.SetCursorPosition(10, 2);
                                    Console.WriteLine("                    ");
                                    
                                }
                            }

                            else if (uservvodit1.Key == ConsoleKey.Enter)
                            {
                                break;
                            }
                            else
                            {
                                char kk = Convert.ToChar(uservvodit1.KeyChar);
                                list.Add(kk);
                                Console.SetCursorPosition(i, 2);
                                Console.WriteLine('*');
                                i = i + 1;
                            }
                        }
                    }
                }
                List<Porol> porollog = new List<Porol>();
                Porol class3 = new Porol();
                string login = "";
                foreach (var item in list1)
                {
                    login = login + item;
                }
                class3.login = login;
                string porol = "";
                foreach (var item in list)
                {
                    porol = porol + item;
                }
                class3.porol = porol;
                string hh = "admin.json";
                class3.rol = 0;// -- Чтобы создать админа
                porollog.Add(class3);
                bool equal = false;
                bool equal1 = false;
                int rolis=100;
                SerilDesir.Serialize(porollog, hh);// -- Создать админа
                //var proverk = SerilDesir.Desir<List<Porol>>(hh);
                //string id = "";
                //for (int i = 0; i < proverk.Count; i++)
                //{
                //    foreach (var item in proverk)
                //    {
                //        if (item.porol == class3.porol)
                //        {
                //            equal = true;
                //            if (item.login == class3.login)
                //            {
                //                equal1 = true;
                //                rolis = item.rol;
                //                id = item.id;

                //            }
                //        }
                //    }
                //}
                //hh = "kadrovik.json";
                //var poick = SerilDesir.Desir<List<Kladmen>>(hh) ?? new List<Kladmen>();
                //foreach (var item in poick)
                //{
                //    if (item.akk == id)
                //    {
                //        class3.login = item.name;
                //    }
                //}
                //if (equal == true & equal1 == true)
                //{
                //    if ( rolis == 0)
                //    {
                //        Admin admin = new Admin();
                //        admin.admin(class3.login, roli[0]);
                //    }
                //    else if ( rolis == 1)
                //    {
                //        kassir kasa = new kassir();
                //        kasa.kassirs(class3.login, roli[1]);
                //    }
                //    else if (rolis == 2)
                //    {
                //        Kadrovik klad = new Kadrovik();
                //        klad.kladmen(class3.login, roli[2]);
                //    }
                //    else if (rolis == 3)
                //    {
                //        skladik skladi = new skladik();
                //        skladi.sklad(class3.login, roli[3]);
                //    }
                //    else if (rolis == 4)
                //    {
                //        Buxgalteryo bux = new Buxgalteryo();
                //        bux.Buxa(class3.login, roli[4]);
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Неправильный логин или пороль. Попробуйте еще раз.");
                //    Thread.Sleep(1000);
                //}
            }

        }
    }
}