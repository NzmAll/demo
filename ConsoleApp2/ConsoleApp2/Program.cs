namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System.Reflection;

namespace HomeTask
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //Console.Write("AZN-nin miqdarı:");
                //float amountAZN = float.Parse(Console.ReadLine());

                //Console.Write("1 USD neçə AZN-dir?");
                //float valueUSD = float.Parse(Console.ReadLine());

                //Console.Write("1 EUR neçə AZN-dir?");
                //float valueEUR = float.Parse(Console.ReadLine());

                //Console.Write("1 RUB neçə AZN-dir?");
                //float valueRUB = float.Parse(Console.ReadLine());

                //float amountUSD = amountAZN / valueUSD;  // 1 USD = 1 AZN / 1.70 
                //float amountEUR = amountAZN / valueEUR;  // 1 EUR = 1 AZN / 1.81
                //float amountRUB = amountAZN / valueRUB;  // 1 RUB = 1 AZN / 0.023

                //Console.WriteLine("USD-nin miqdarı:" + amountUSD);
                //Console.WriteLine("EUR-nun miqdarı:" + amountEUR);
                //Console.WriteLine("RUB-un miqdarı:" + amountRUB);









                //Console.Write("Azərbaycan dövlətinin illik büdcəsi:");
                //decimal annual_budget = decimal.Parse(Console.ReadLine());

                //decimal remaining_budget;

                //Console.Write("Müdafiə Nazirliyinə xərclənənən məbləğ:");
                //decimal ministry_of_defence = decimal.Parse(Console.ReadLine());
                //ministry_of_defence = annual_budget * 20 / 100;

                //Console.Write("Yüksək Texnologiyalar Nazirliyinə xərclənənən məbləğ:");
                //decimal ministry_of_high_technologies = decimal.Parse(Console.ReadLine());
                //ministry_of_high_technologies = annual_budget * 10 / 100;

                //remaining_budget = annual_budget - (ministry_of_defence + ministry_of_high_technologies);

                //Console.WriteLine("Yerdə qalan büdcə:" + remaining_budget);









                Console.Write("Firma :");
                string first_firm = Console.ReadLine();

                Console.Write("Ayaqqabı sayı :");
                float first_count_of_shoe = float.Parse(Console.ReadLine());

                Console.Write("Birinin qiyməti ($) :");
                float first_price_of_one = float.Parse(Console.ReadLine());

                float all_price = first_count_of_shoe * first_price_of_one;

                Console.WriteLine("Hamısının birlikdə qiyməti($):" + all_price);
                Console.WriteLine(" ");


                Console.Write("Firma :");
                string second_firm = Console.ReadLine();

                Console.Write("Ayaqqabı sayı :");
                float second_count_of_shoe = float.Parse(Console.ReadLine());

                Console.Write("Birinin qiyməti ($) :");
                float second_price_of_one = float.Parse(Console.ReadLine());

                float second_all_price = second_count_of_shoe * second_price_of_one;

                Console.WriteLine("Hamısının birlikdə qiyməti($):" + second_all_price);
                Console.WriteLine(" ");


                Console.Write("Firma :");
                string third_shoe = Console.ReadLine();

                Console.Write("Ayaqqabı sayı :");
                float third_count_of_shoe = float.Parse(Console.ReadLine());

                Console.Write("Birinin qiyməti ($) :");
                float third_price_of_one = float.Parse(Console.ReadLine());

                float third_all_price = third_count_of_shoe * third_price_of_one;

                Console.WriteLine("Hamısının birlikdə qiyməti($):" + third_all_price);
                Console.WriteLine(" ");



            }
        }
    }
}
    }
}