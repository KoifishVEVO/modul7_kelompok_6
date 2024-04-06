using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Modul_07_CoffeJava;

namespace modul7_kelompok_6
{
    internal class TeamsMembers_1302220018
    {
        public TeamsMembers_1302220018 ReadJson()
        {
            string jsonString = File.ReadAllText("D:\\Tugas\\Tugas Kuliah\\Semester 4\\KPL\\jurnal7_1302220018\\modul7_kelompok_6\\jurnal7_2_1302220018.json");
            TeamsMembers_1302220018 data = JsonConvert.DeserializeObject<TeamsMembers_1302220018>(jsonString);
            return data;
        }

        public List<Members> members { get; set; }
        public class Members
        {
            public string firstName { get; set; }
            public string lastName { get; set; }

            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }

            public Members() { }
        }
    }
}

