using System;
using System.Linq;

namespace Lab3
{
    class Program
    {
        private static Airport airport = new Airport();
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("<== Меню ==>");
                Console.WriteLine();

                Console.WriteLine("1. Получить информацию о рейсе по номеру рейса");
                Console.WriteLine("2. Получить информацию о рейсах по времени");
                Console.WriteLine("3. Получить информацию о рейсах по месту назначения");
                Console.WriteLine("0. Выход");

                string position = Console.ReadLine();
                switch (position)
                {
                    case "0":
                        return;
                    case "1":
                        SelectAirplane();
                        break;
                    case "2":
                        FindAirplaneByTime();
                        break;
                    case "3":
                        FindAirplaneByDestination();
                        break;
                    default:
                        break;
                }

            }
        }

        private static void SelectAirplane()
        {
            string[] _airplaneNumbers = airport.getAirplanesNumbers();

            for (int i = 0; i < _airplaneNumbers.Length; i++)
            {

                Console.WriteLine($"{i + 1} {_airplaneNumbers[i]}");

            }
            string airplaneIndex = Console.ReadLine();
            try
            {
                Airplane _airplane = airport.getAirplaneByNumber(_airplaneNumbers[int.Parse(airplaneIndex) - 1]);
                Console.WriteLine(_airplane.ToString());
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }

        }

        private static void FindAirplaneByTime()
        {

            Console.WriteLine("Введите время в формате YYYY-MM-DD hh:mm:ss");
            DateTime awaitingTime;
            try
            {
                awaitingTime = DateTime.Parse(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("Некорректный фомат введенного времени, введите в формате YYYY-MM-DD hh:mm:ss");
                Console.ReadLine();
                return;

            }
            try
            {
                Airplane[] _airplanes = airport.getNearAirplane(awaitingTime);
                foreach (string _airplane in _airplanes.Select(el => el.ToString()))
                    Console.WriteLine(_airplane);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }
        }


        private static void FindAirplaneByDestination()
        {

            Console.WriteLine("Введите пункт назначения");
            string destination = Console.ReadLine();

            try
            {
                Airplane[] _airplanes = airport.getAirplaneByDestination(destination);
                foreach (string _airplane in _airplanes.Select(el => el.ToString()).ToArray())
                    Console.WriteLine(_airplane);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }
        }

    }
}
