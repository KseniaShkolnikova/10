using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _10_практа
{
    internal static class SerilDesir
    {
        public static void Serialize <T> (T avtor, string file)
        {
            string desktoop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = JsonConvert.SerializeObject(avtor);
            File.WriteAllText(desktoop+ "\\10\\"+file, json);
        }
        public static T Desir <T> (string file)
        {
            string desktoop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json="";
            try
            {
                json = File.ReadAllText(desktoop + "\\10\\" + file);
            }
            catch
            {
                File.Create(desktoop + "\\" + file).Close();
            }
            T avtor = JsonConvert.DeserializeObject <T> (json);
            return avtor;
        }
    }
}
