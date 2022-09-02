// See https://aka.ms/new-console-template for more information

int input;

Console.WriteLine("Please enter an integer.");

input = Convert.ToInt16(Console.ReadLine());


if(input % 10 == 0)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("False");
}

