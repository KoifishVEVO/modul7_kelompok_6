using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TP_Modul_07_CoffeJava
{
    internal class DataMahasiswa_1302220018
    {
        public DataMahasiswa_1302220018 ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\Tugas\\Tugas Kuliah\\Semester 4\\KPL\\jurnal7_1302220018\\modul7_kelompok_6\\jurnal7_1_1302220018.json");
            DataMahasiswa_1302220018 data = JsonConvert.DeserializeObject<DataMahasiswa_1302220018>(jsonString);
            this.firstName = data.firstName;
            this.lastName = data.lastName;
            this.gender = data.gender;
            this.age = data.age;
            return data;
        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }

        public Address address { get; set; }
        public List<Courses> courses { get; set; }


        public DataMahasiswa_1302220018()
        {
            address = new Address();
        }

        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class Courses
        {
            public string code { get; set; }
            public string name { get; set; }

            public Courses()
            {

            }
        }

       
       

    }




}