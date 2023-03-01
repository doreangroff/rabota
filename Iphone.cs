using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabota
{
    internal class Iphone : Mobile
    {
        private string _ios_version;
        public string Ios_version;

        public void PrintInfo()
        {
            Console.WriteLine($"{Model}, {Colour}, {Datapok}, {Price}, {Guarantee}, {Ios_version}");
        }
    }
}
