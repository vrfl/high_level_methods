using System;

namespace control_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дробь в формате 'целое числитель/знаменатель'");
            string a = Console.ReadLine();
            var fraction = Fraction.Parse(a);
            Console.WriteLine(fraction.ToString());
        }
    }
}
