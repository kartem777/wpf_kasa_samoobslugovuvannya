using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_proj
{
    internal class products
    {
        public string name { get; set; }
        public int price { get; set; }
        public products(string _name, int _price) { price = _price; name = _name; }
    }
}
