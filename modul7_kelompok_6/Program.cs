using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Modul_07_CoffeJava
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DataMahasiswa_1302220018 mahasiswa = new DataMahasiswa_1302220018();
            Console.WriteLine("Nama Mahasiswa : " + mahasiswa.ReadJSON().firstName + " " + mahasiswa.ReadJSON().lastName);
            Console.WriteLine("Gender : " + mahasiswa.ReadJSON().gender);
            Console.WriteLine("Umur : " + mahasiswa.ReadJSON().age);
            Console.WriteLine("Nama jalan : " + mahasiswa.ReadJSON().address.streetAddress);
            Console.WriteLine("Nama Kota : " + mahasiswa.ReadJSON().address.city);
            Console.WriteLine("Nama State : " + mahasiswa.ReadJSON().address.state);
            Console.WriteLine("Mata Kuliah :");
            foreach (var course in mahasiswa.ReadJSON().courses)
            {
                Console.WriteLine("Kode : " + course.code);
                Console.WriteLine("Nama : " + course.name);
            }

        }
    }
}