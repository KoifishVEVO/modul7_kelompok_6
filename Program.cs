// See https://aka.ms/new-console-template for more inforda
using modul7_kelompok_6;
using modul7_kelompok6;

DataMahasiswa_1302223027 test1 = new DataMahasiswa_1302223027();

test1.ReadJSON();

Console.WriteLine(test1.firstName + " " + test1.lastName) ;
Console.WriteLine(test1.gender);
Console.WriteLine(test1.age);
Console.WriteLine(test1.address.streetAddress+", "+test1.address.city+", "+test1.address.state) ;
for (int i = 0 ; i < test1.courses.Count ; i++)
{
    Console.WriteLine(test1.courses[i].code);
    Console.WriteLine(test1.courses[i].name);
}  


TeamMember_1302223027 test2 = new TeamMember_1302223027();
test2.ReadJSON();
