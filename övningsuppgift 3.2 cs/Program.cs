using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vem vann vm i fotboll för damer 2015?");
            string svar = Console.ReadLine();
            if(svar == "usa" )
            {
                Console.WriteLine("du svarade rätt!");
            }
            else
            {
                Console.WriteLine("fel svar :( ");
            }
        }
    }
}
