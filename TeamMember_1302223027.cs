using modul7_kelompok_6;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace modul7_kelompok6
{
    internal class TeamMember_1302223027
    {
        public List<detailMember> members;
        public TeamMember_1302223027()
        {
            members = new List<detailMember>();
        }

        public void ReadJSON()
        {
            string jsonContent = File.ReadAllText("D:\\praktikum kpl\\modul7_kelompok6\\jurnal7_2_1302223027.json");
            TeamMember_1302223027 data = JsonConvert.DeserializeObject<TeamMember_1302223027>(jsonContent);
            for(int i = 0;i<5;i++) {
                Console.WriteLine(data.members[i].firstName);
            }
        }
    }

    public class detailMember
    {
        public string firstName;
        public string lastName;
        public string gender;
        public int age;
        public string nim;

    }
}
