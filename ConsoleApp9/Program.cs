using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mers = new Car();
            mers.name = "Mercedes";
            mers.version = "CLS 220";
            mers.type = "sedan";
            mers.color = "white";
            mers.doorsCount = 4;
            mers.GetInfo();


            Car bmw = new Car();
            bmw.name = "BMW";
            bmw.version = "X6";
            bmw.type = "SUV";
            bmw.color = "black";
            bmw.doorsCount = 5;
            bmw.GetInfo();

            Console.ReadLine();

        }
    }
}
