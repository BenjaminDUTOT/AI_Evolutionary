using System;
using System.Linq;

namespace AI_Evolutionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Courbe c = new Courbe();
            c.addData();
            Console.WriteLine(c.data.ElementAt(0).x.ToString());
            Console.ReadLine();
        }
    }
}
