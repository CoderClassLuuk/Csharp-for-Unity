using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobielClass
{
    public class Mobiel
    {
        public string type;
        public string model;
        public string os;
        public string ceo;
        public Mobiel(string nType, string nModel, string nOS, string nCeo)
        {
            type = nType;
            model = nModel;
            os = nOS;
            ceo = nCeo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mobiel Apple = new Mobiel("iPhone", "iPhone XS", "iOS", "Tim Cook");
            Mobiel Samsung = new Mobiel("Samsung Galaxy", "Galaxy S10+", "Android", "Koh Dong Jin");
            Mobiel Google = new Mobiel("Google Pixel", "Pixel 3 XL", "Android", "Sundar Pichai");

            Console.WriteLine("Apple\n=====\nType: " + Apple.type + "\nModel: " + Apple.model + "\nOS: " + Apple.os + "\nCEO: " + Apple.ceo + "\n");
            Console.WriteLine("Samsung\n=====\nType: " + Samsung.type + "\nModel: " + Samsung.model + "\nOS: " + Samsung.os + "\nCEO: " + Samsung.ceo + "\n");
            Console.WriteLine("Google\n=====\nType: " + Google.type + "\nModel: " + Google.model + "\nOS: " + Google.os + "\nCEO: " + Google.ceo + "\n");
            Console.ReadLine();
        }
    }
}
