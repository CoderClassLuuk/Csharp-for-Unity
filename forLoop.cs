using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            const string geheimeWoord = "FIETS";
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Raad het geheime woord\nTIP : HET RIJMT OP IETS\n: ");
                string woordInput = Console.ReadLine();
                if (woordInput.ToUpper() == geheimeWoord) 
                {
                    Console.WriteLine("Het is je gelukt! Ik ben trots op je :).");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("Ok buddy\nretard.\nAantal pogingen over: " + Convert.ToString((3 - i)));
                    Console.ReadLine();
                }
            }
        }
    }
}
