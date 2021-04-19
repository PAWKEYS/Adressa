using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_1
{
    class Adress
    {
        public string city { get; set; }
        public string street { get; set; }
        public int dom { get; set; }
      

        public Adress(string city, string street, int dom)
        {
            this.city = city;
            this.street = street;
            this.dom = dom;
        }

        public Adress(Adress a) : this(a.city, a.street, a.dom) { }


    }

}
