using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesStateManagementLab.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public string Greeting { get; set; }
        public string Description { get; set; }
        public List<string> NationalColors { get; set; }


        public Country() { }

        public Country(string Name, string Language, string Greeting, string Description, List<string> NationalColors)
        {
            this.Name = Name;
            this.Language = Language;
            this.Greeting = Greeting;
            this.Description = Description;
            this.NationalColors = NationalColors;
        }

    }
}
