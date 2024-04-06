using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static TeamMembers_1302220046;

internal class TeamMembers_1302220046

{

    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }

    public string nim { get; set; }

    public List<TeamMembers_1302220046> Members { get; set; }
    public TeamMembers_1302220046()
    {
        Members = new List<TeamMembers_1302220046>();
    }








    public void ReadJSON()
	{
		string jsonContent = File.ReadAllText("C:\\Users\\LENOVO\\Downloads\\skool tugas\\Semester 4\\Konstruksi\\tp\\mod7\\modul7_kelompok_6\\modul7_kelompok_6\\jurnal7_2_1302220046");
        TeamMembers_1302220046 data = JsonConvert.DeserializeObject<TeamMembers_1302220046>(jsonContent);

		

		for (int i = 0; i < data.Members.Count; i++)
		{
            Members.Add(data.Members[i]);
		}

	}
		


}
}