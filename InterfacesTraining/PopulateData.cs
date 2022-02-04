using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTraining
{
    internal class PopulateData : IConfiguration
    {
        public string Name { get; set; } = "Eric";
        public string Version { get ; set ; }


        public void browser()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                Console.WriteLine(Name);
            }
            else { 
            Console.WriteLine("empty");
            }
        }
    }
}
