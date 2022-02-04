using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTraining
{
    public interface IConfiguration
    {
        void browser();
        string Name { get; set; }
        string Version { get; set; }
        
    }
}
