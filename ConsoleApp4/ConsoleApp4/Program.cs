Console.WriteLine("enter the age");
var input1 = Convert.ToInt32(Console.ReadLine());
if (input1 < 18)
{
    Console.WriteLine("minor");
}

else if (input1 >= 18)
{
    Console.WriteLine("adult");
}