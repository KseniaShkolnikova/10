using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_практа
{
    public interface CRUDS
    {
        void Create();
        void Read(int position, string hh, string login, string roli);
        void Update (string hh, string login, string roli);
        void Delete(string hh);
        void Serch(string login, string hh, string roli);
    }
    
}
    


