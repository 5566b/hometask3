Console.WriteLine("enter the temperature");

var input = Convert.ToInt32(Console.ReadLine());


switch (input)
{
    case < 0:
        Console.WriteLine("very cold");
        break;

    case > 0 and < 10:
        Console.WriteLine("cold");
        break;

    case > 10 and < 20:
        Console.WriteLine("ok");
        break;

    case > 20 and < 30:
        Console.WriteLine("war");
        break;

    case > 30 and < 99999999:
        Console.WriteLine("very warm ");
        break;
}