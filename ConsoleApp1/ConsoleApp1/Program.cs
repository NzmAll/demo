using System.ComponentModel.Design;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string carMark = Console.ReadLine();
            string carModel = Console.ReadLine();
            int count = Int16.Parse(Console.ReadLine());
            float rentACarCount = Int16.Parse(Console.ReadLine());
            int month = Int16.Parse(Console.ReadLine());
            float total = count * rentACarCount * month;


            if ( total == count * rentACarCount * month)
            {
                Console.WriteLine(total);
            }

            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}