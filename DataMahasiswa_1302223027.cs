using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul7_kelompok_6
{
    internal class DataMahasiswa_1302223027
    {
        public string firstName;
        public string lastName;
        public string gender;
        public int age;
        public addressDetail address;
        public List<collegeCourses_1302223027> courses;


        public DataMahasiswa_1302223027()
        {
            courses = new List<collegeCourses_1302223027>();
            address = new addressDetail();
        }


        public void ReadJSON()
        {
            string jsonContent = File.ReadAllText("D:\\praktikum kpl\\modul7_kelompok_6\\modul7_kelompok_6\\jurnal7_1_1302223027.json");
            DataMahasiswa_1302223027 data = JsonConvert.DeserializeObject<DataMahasiswa_1302223027>(jsonContent);

            firstName = data.firstName;
            lastName = data.lastName;
            gender = data.gender;
            age = data.age;
            address = data.address;
            courses = data.courses;
        }
    }
}

public class addressDetail
{
    public string streetAddress;
    public string city;
    public string state;
}

public class collegeCourses_1302223027
{
    public string code;
    public string name;
}

