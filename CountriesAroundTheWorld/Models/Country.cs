using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesAroundTheWorld.Models
{
    public class Country
    {
        public string Name { get; set; }
        public List<string> Languages { get; set; } = new List<string>();
        public string Greeting { get; set; }
        public string Description { get; set; }
        public List<string> Colors { get; set; } = new List<string>();
        //public string   FlagSrc { get; set; }
        public Country(string Name, List<string> Languages, string Greeting, string Description, List<string> Colors)
        {
            this.Name = Name;
            this.Languages = Languages;
            this.Greeting = Greeting;
            this.Description = Description;
            this.Colors = Colors;
           //this.FlagSrc = FlagSrc;
        }
    }
}
