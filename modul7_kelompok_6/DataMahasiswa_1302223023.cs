using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_6
{
    public class DataMahasiswa_1302223023
    {
        private string firstName {  get; set; }
        public string lastName { get; set; }
        private string gender { get; set; }
        private int age { get; set; }
        private string address { get; set; }
        private string courses { get; set; }

        public DataMahasiswa_1302223023 () { }

        public void ReadJson()
        {
            string json = File.ReadAllText(@"C:\Users\rinda\OneDrive\Documents\C#\Kelompok 6\modul7_kelompok_6\modul7_kelompok_6\jurnal7_1_1302223023.json");
            dynamic mhs = JsonConvert.DeserializeObject(json);
            string NamaDe = mhs.firstName;
            string NamaBe = mhs.lastName;
            string JK = mhs.gender;
            int umur = mhs.age;
            string jalan = mhs.address.streetAddress;
            string kota = mhs.address.city;
            string provinsi = mhs.address.state;

            int i = 1;
            foreach (var item in mhs.courses)
            {
                Console.WriteLine($"Course " + i + item.code + " - " + item.name);
                i++;
            }

        }

    }
}
