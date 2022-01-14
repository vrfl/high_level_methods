using System;
using System.Linq;

namespace Lab3
{
    public class Airport
    {
        private Airplane[] _airplanes = {
            new Airplane("Новосибирск", "NSK123", new DateTime(2022, 01, 20, 10, 0, 0)),
            new Airplane("Москва", "MSK434", new DateTime(2022, 01, 20, 20, 4, 0)),
            new Airplane("Красноярск", "KJA323", new DateTime(2022, 01, 20, 12, 43, 0)),
            new Airplane("Екатеринбург", "SVX304", new DateTime(2022, 01, 21, 0, 25, 0)),
            new Airplane("Новосибирск", "NSK145", new DateTime(2022, 01, 20, 10, 0, 0)),
            new Airplane("Москва", "MSK244", new DateTime(2022, 01, 20, 20, 4, 0)),
            new Airplane("Красноярск", "KJA973", new DateTime(2022, 01, 20, 12, 43, 0)),
            new Airplane("Екатеринбург", "SVX514", new DateTime(2022, 01, 21, 0, 25, 0))
        };

        public string[] getAirplanesNumbers()
        {
            return _airplanes.Select(s => s.Number).ToArray();

        }

        public Airplane getAirplaneByNumber(string number)
        {
            try
            {
                return _airplanes.Single(e => e.Number == number);
            }
            catch
            {
                throw new ArgumentException("Самолеты с введенным номером не найден");

            }
        }

        public Airplane[] getNearAirplane(DateTime time)
        {
            Airplane[] _airplane;
            try
            {
                _airplane = _airplanes.Where(e => e.Time > time && e.Time < time.AddHours(1)).ToArray();
            }
            catch
            {
                throw new ArgumentException("Самолеты не найдены");

            }
            return _airplane;

        }

        public Airplane[] getAirplaneByDestination(string destination)
        {
            Airplane[] _airplane;
            try
            {
                _airplane = _airplanes.Where(e => e.Destination == destination).ToArray();
            }
            catch
            {
                throw new ArgumentException("Самолеты не найдены");

            }
            return _airplane;

        }



    }
}
