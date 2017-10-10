using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Cat { get; set; }


        public override string ToString() {
            return "ID:" + ID + " Name:" + Name + " Price:" + Price + "Category: " + Cat;
        }

    }
}
