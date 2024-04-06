using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_6
{
    public class TeamMembers_1302223023
    {
        private string members {  get; set; }

        public TeamMembers_1302223023() { }

        public void ReadJson()
        {
            string json = File.ReadAllText(@"C:\Users\rinda\OneDrive\Documents\C#\Kelompok 6\modul7_kelompok_6\modul7_kelompok_6\jurnal7_2_1302223023.json");
            dynamic anggota = JsonConvert.DeserializeObject(json);
            Console.WriteLine("Team Member list:");
            foreach(var Member in anggota.members)
            {
                Console.WriteLine($" " + Member.firstName + " " + Member.lastName + " " + Member.gender + "" + Member.age + " " + Member.nim);
            }
        }
    }
}
