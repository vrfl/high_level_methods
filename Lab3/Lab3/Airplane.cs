using System;
namespace Lab3
{
    public class Airplane
    {

        private string _destination;
        private string _number;
        private DateTime _time;

        public Airplane(string destination, string number, DateTime time)
        {
            _destination = destination;
            _number = number;
            _time = time;
        }

        public string Destination
        {
            get => _destination;
        }

        public string Number
        {
            get => _number;
            set
            {
                if (value.Length != 6)
                    throw new ArgumentException($"Значение номера рейса должно быть шестизначным");

                _number = value;
            }
        }

        public DateTime Time
        {
            get => _time;
        }



        public override string ToString()
        {

            return $@"
Номер рейса: {Number}
Пункт назначения: {Destination}
Время вылета: {Time}
";
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(_number, _destination, _time);
        }

        public static bool operator ==(Airplane left, Airplane right)
        {
            return left.Time.Equals(right.Time);
        }
        public static bool operator !=(Airplane left, Airplane right)
        {
            return !left.Time.Equals(right.Time);
        }


        public override bool Equals(object obj)
        {
            if (obj?.GetType() != GetType())
                return false;

            var other = (Airplane)obj;

            return _time == other._time;

        }
    }
}
