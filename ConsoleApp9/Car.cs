using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Car
    {
        public string type;
        public string name;
        public string version;
        public string color;
        public int doorsCount;

        public void GetInfo()
        {
            Console.WriteLine($"name: {name}\n" +
                $"version: {version}\n"+
                $"type: {type}\n"+
                $"color: {color}\n"+
                $"doorsCount: {doorsCount}\n");
        }
    }
}
