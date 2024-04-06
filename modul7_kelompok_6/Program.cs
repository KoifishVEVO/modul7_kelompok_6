using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


Console.WriteLine("Hello, World!");


namespace modul7_kelompok_6;
{
internal class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa_1302220046 dataMahasiswa = new DataMahasiswa_1302220046();
        dataMahasiswa.ReadJSON();

        TeamMembers_1302220046 team = new TeamMembers_1302220046();
        team.ReadJSON();

        Console.WriteLine();
        Console.WriteLine("Team member list:");

        for (int i = 0; i < team.Members.Count; i++)
        {
            
            Console.WriteLine($"{team.Members[i].nim} {team.Members[i].firstName} {team.Members[i].lastName} {team.Members[i].age} {team.Members[i].gender}");
        }
    }
}



}