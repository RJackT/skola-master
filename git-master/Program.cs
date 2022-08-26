// See https://aka.ms/new-console-template for more information
Console.WriteLine("Skriv en boolean.");
string input;
do
{
    input = Console.ReadLine();
}while(input  == null);

if (input.ToLower() == "true")
    Console.Write("True");
else if (input.ToLower() == "false")
    Console.Write("False");
else
    Console.Write("Your input was not valid.");