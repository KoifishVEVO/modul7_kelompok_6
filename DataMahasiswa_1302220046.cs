using System;

public class DataMahasiswa_1302220046
{
    public class DataMahasiswa()
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public address address {  get; set; }
        public courses courses { get; set; }
    }

    public class address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }   
        public string state { get; set; }
    }

    public class courses
    {
        public string name { get; set; }
        public string code { get; set; }
    }


	public void ReadJSON()
	{
        string jsonData = File.ReadAllText("C:\\Users\\LENOVO\\Downloads\\skool tugas\\Semester 4\\Konstruksi\\tp\\mod7\\modul7_kelompok_6\\modul7_kelompok_6\\jurnal7_1_1302220046")
        
            DataMahasiswa data = JsonConvert.DeserializeObject<DataMahasiswa>(jsonData);
            
        Console.WriteLine($"Nama {data.firstName} {data.lastName} gender {data.gender} age {data.age} ");
        Console.Writeline($"address: {data.address.city} {data.address.state} {data.address.streetAddress}");
        Console.WriteLine($"courses: {data.courses.name} {data.courses.code}");
            }
}
