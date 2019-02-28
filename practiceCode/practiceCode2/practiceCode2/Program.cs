using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCode2
{

    struct House
    {
        public string address;
        public int width;
        public int length;

        public House(string a, int w, int l)
        {
            address = a;
            width = w;
            length = l;
        }

        public int Area()
        {
            return width * length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            House myHouse = new House("789 road Street", 20, 10);
            /*
            myHouse.address = "123 Streeto";
            myHouse.width = 50;
            myHouse.length = 35;
            */

            Console.WriteLine(myHouse.address);
            Console.WriteLine(myHouse.Area());
            Console.ReadKey();

            
        }
    }
}
