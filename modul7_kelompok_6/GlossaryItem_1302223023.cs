using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_6
{
    public class GlossaryItem_1302223023
    {
        private string glossary {  get; set; }
        private string GlossDiv {  get; set; }
        private string GlossList { get; set; }
        private string GlossEntry {  get; set; }
        private string GlossDef { get; set; }

        private string GlossSee { get; set; }

        public GlossaryItem_1302223023() { }

        public void ReadJson()
        {
            string json = File.ReadAllText(@"C:\Users\rinda\OneDrive\Documents\C#\Kelompok 6\modul7_kelompok_6\modul7_kelompok_6\jurnal7_3_1302223023.json");
            dynamic Gl = JsonConvert.DeserializeObject(json);

            foreach (var Glossary in Gl.glossary)
            {
                Console.WriteLine($"name" + Gl.title);
            }
        }
    }
}
