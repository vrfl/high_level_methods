

namespace QuadraticEquation
{
    public sealed class QuadraticEquation
    {
        private int _coefficientA;
        private int _coefficientB;
        private int _coefficientC;
        public QuadraticEquation(int coefficientA = 1, int coefficientB = 1, int coefficientC = 1)
        {
            CoefficientA = coefficientA;
            CoefficientB = coefficientB;
            CoefficientC = coefficientC;
        }

        public int CoefficientA
        {
            get => _coefficientA;
            set
            {


                _coefficientA = value;
            }
        }

        public int CoefficientB
        {
            get => _coefficientB;
            set
            {


                _coefficientB = value;
            }
        }
        public int CoefficientC
        {
            get => _coefficientC;
            set
            {


                _coefficientC = value;
            }
        }

        public (Double, Double?)? Calculate()
        {
            try
            {
                Double x1, x2;
                Double D = _coefficientB * _coefficientB - 4 * _coefficientA * _coefficientC;
                if (D < 0) throw new Exception(" Квадратное уравнение не имеет корней ");
                if (D == 0)
                {
                    x1 = -_coefficientB / 2 * _coefficientA;
                  return (x1, null);
                }
                if (D > 0)
                {
                    x1 = (-_coefficientB + Math.Sqrt(D)) / (2 * _coefficientA);
                    x2 = (-_coefficientB - Math.Sqrt(D)) / (2 * _coefficientA);
                    return (x1, x2);
                }
                }
            catch (Exception ex)
            {

                throw ex;
            }
            return null;
        }
        public override string ToString()
        {
            return $"{_coefficientA}x^2 + {_coefficientB}x + {_coefficientC} = 0";
        }

    }
}
