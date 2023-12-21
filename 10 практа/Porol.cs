using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_практа
{
    public  class Porol
    {
        public string id;
        public string porol;
        public string login;
        public int rol;
    }
    public class Kladmen
    {
        public string id;
        public string surname;
        public string name;
        public string midlename;
        public string dr;
        public string passport;
        public string dolznost;
        public double zp;
        public string akk;
    }
    public class Sklad
    {
        public string id;
        public string name;
        public double cena;
        public int colvovsklad;
        public int nasklad;
    }
    public class Buxgalter
    {
        public string id;
        public string name;
        public double cuma;
        public DateTime vrema;
        public bool pribavka;
        public double itog;
    }
    public class kassiri:Sklad
    {
        public int pokupkolvo;
        public double cumaitog;
        public string nazvpokup;
    }
}

