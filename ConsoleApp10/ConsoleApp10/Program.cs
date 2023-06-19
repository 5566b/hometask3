
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = double.Parse(Console.ReadLine());

      
        Console.WriteLine("Выберите операцию (+, -, *, /):");
        string operation = Console.ReadLine();

        Console.WriteLine("Введите второе число:");
        double num2 = double.Parse(Console.ReadLine());


        double result = 0;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
                break;
            default:
            case "%"
                result = num1 % num2;
                Console.WriteLine("Операция не распознана.");
                break;
        }

        Console.WriteLine("Результат: " + result);

    }
}