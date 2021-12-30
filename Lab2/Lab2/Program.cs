namespace QuadraticEquation;
class Program
{
    private static QuadraticEquation quadraticEquation = new();
    
private static void Main()

    {
        while (true)
        {
            Console.Title = $"Текущее уравнение: {quadraticEquation.ToString()}";

            Console.Clear();
            Console.WriteLine("<== Меню ==>");
            Console.WriteLine($"Уравнение {quadraticEquation.ToString()}");
            Console.WriteLine();

            Console.WriteLine("1. Задать a");
            Console.WriteLine("2. Задать b");
            Console.WriteLine("3. Задать c");
            Console.WriteLine("4. Рассчитать");
            Console.WriteLine("0. Выход");

            var position = Console.ReadLine();
            switch (position)
            {
                case "0":
                    return;
                case "1":
                    SetCoeffA();
                    break;
                case "2":
                    SetCoeffB();
                    break;
                case "3":
                    SetCoeffC();
                    break;
                case "4":
                    Calculate();
                    break;
            }
        }

    }

    private static void SetCoeffA()
    {
        Console.Clear();
        Console.WriteLine("<== Задать  коэффициент А ==>");
        Console.WriteLine($"Записанный коэффициент А: {quadraticEquation.CoefficientA}");

        Console.Write("Введите целое число ");
        try
        {
            var coeffA = int.Parse(Console.ReadLine() ?? "");
            quadraticEquation.CoefficientA = coeffA;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка при вводе: {e.Message}");
        }

        Console.ReadLine();
    }

    private static void SetCoeffB()
    {
        Console.Clear();
        Console.WriteLine("<== Задать  коэффициент B ==>");
        Console.WriteLine($"Записанный коэффициент B: {quadraticEquation.CoefficientB}");

        Console.Write("Введите целое число ");
        try
        {
            var coeffB = int.Parse(Console.ReadLine() ?? "");
            quadraticEquation.CoefficientB = coeffB;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка при вводе: {e.Message}");
        }

        Console.ReadLine();
    }

    private static void SetCoeffC()
    {
        Console.Clear();
        Console.WriteLine("<== Задать  коэффициент C ==>");
        Console.WriteLine($"Записанный коэффициент C: {quadraticEquation.CoefficientC}");

        Console.Write("Введите целое число ");
        try
        {
            var coeffC = int.Parse(Console.ReadLine() ?? "");
            quadraticEquation.CoefficientC = coeffC;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка при вводе: {e.Message}");
        }

        Console.ReadLine();
    }
    private static void Calculate()
    {
        Console.Clear();
        Console.WriteLine("<== Рассчитать уравнение ==>");
        Console.WriteLine($"Текущее уравнение: {quadraticEquation.ToString()}");

        Console.WriteLine("Результат ");
        try
        {
            var result = quadraticEquation.Calculate();
            if(result?.Item1 != null && result?.Item2 != null)
            {

            Console.WriteLine($"х1 = {result?.Item1} х2={result?.Item2}");
            }
            else { Console.WriteLine($"х = {result?.Item1}"); }
        }
        catch (Exception ex)
        {

            Console.WriteLine($"Ошибка при рассчете: {ex.Message}");
        }

        Console.ReadLine();
    }

}