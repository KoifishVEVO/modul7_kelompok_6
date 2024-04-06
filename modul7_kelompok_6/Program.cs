using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using modul7_kelompok_6;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa_1302223023 data = new DataMahasiswa_1302223023();
        data.ReadJson();

        TeamMembers_1302223023 team = new TeamMembers_1302223023(); 
        team.ReadJson();

        GlossaryItem_1302223023 gloss = new GlossaryItem_1302223023();
        gloss.ReadJson();
    }
}
