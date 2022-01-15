// Объект: натуральная дробь (целое, числитель, знаменатель). Реализовать
// операции с учѐтом приведения к общему знаменателю. Принять: (+ и +=) –
// сложение, (– и –=) – вычитание, (* и *=) – умножение, (!) – проверка на
// ноль, (== и !=) – сравнение, (double) – преобразование в рациональную
// дробь, (~) – взаимообратная натуральная дробь.

using System;
using System.Text.RegularExpressions;

namespace control_work
{
    class Fraction
    {
        private int _numerator;
        private int _denominator;

        Fraction() { }
        Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public int Numerator
        {
            get => _numerator;
            set => _numerator = value;
        }

        public int Denominator
        {
            get => _denominator;
            set => _denominator = value;
        }

        public static Fraction Parse(string value)
        {
            string pattern = @"(?<whole>\d* )?((?<numerator>\d*)\/(?<denominator>\d*))";
            try
            {
                Match match = Regex.Match(value, pattern);
                int whole = int.Parse(match.Groups["whole"].Value);

                int numerator = int.Parse(match.Groups["numerator"].Value);
                int denominator = int.Parse(match.Groups["denominator"].Value);
                return new Fraction((whole * denominator) + numerator, denominator);

            }
            catch
            {
                throw new ArgumentException("Значение введено в неверном формате");
            }




        }

        int NOD(int left, int right)
        {
            while (left > 0 && right > 0)
            {
                if (left > right)
                    left %= right;
                else
                    right %= left;
            }
            return left + right;
        }


        public static Fraction operator +(Fraction left, Fraction right) =>
        new Fraction(left.Numerator * right.Denominator + right.Numerator * left.Denominator,
        left.Denominator * right.Denominator);

        public static Fraction operator -(Fraction left, Fraction right) =>
               new Fraction(left.Numerator * right.Denominator - right.Numerator * left.Denominator,
    left.Denominator * right.Denominator);

        public static Fraction operator *(Fraction left, Fraction right) =>
            new Fraction(left.Numerator * right.Numerator,
        left.Denominator * right.Denominator);

        public static Fraction operator /(Fraction left, Fraction right)
        {

            if (right.Numerator == 0)
                throw new ArgumentException("Числитель не может быть равен нулю");
            return new Fraction(
                left.Numerator * right.Denominator,
        right.Denominator * right.Numerator);


        }

        public static bool operator ==(Fraction left, Fraction right)
        => left.Numerator == right.Numerator && left.Denominator == right.Denominator;

        public static bool operator !=(Fraction left, Fraction right)
                => left.Numerator == right.Numerator && left.Denominator == right.Denominator;

        public override bool Equals(object obj)
        {
            if (obj?.GetType() != GetType())
                return false;

            var other = (Fraction)obj;

            return _numerator == other._numerator && _denominator == other._denominator;
        }

        public override int GetHashCode() => HashCode.Combine(_numerator, _denominator);

        public override string ToString() => $"{_numerator / _denominator} {_numerator % _denominator}/{_denominator}";

    }
}