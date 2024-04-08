using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje4
{
    internal class galeri { 

     List<araba> arabalar = new List<araba>();
       public void arabaekle(araba a)
        {
            arabalar.Add(a);
        }
        public string[] arabalistele()
        {
            string[] s = new string[arabalar.Count];
            for(int i = 0; i < arabalar.Count; i++)
            {
                s[i] = arabalar[i].marka + " " + arabalar[i].model;
            }
            return s;
        }
    }
}
