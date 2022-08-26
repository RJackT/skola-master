// See https://aka.ms/new-console-template for more information

int input;
int numSum = 0 ;
int numAmount = 0;



do
{
    Console.WriteLine("Skriv in ett heltal.");
    input = Convert.ToInt32(Console.ReadLine());
    numAmount++;
    numSum += input; // Den räknar inte nollor oavsett, 1 + 0 = 1;
} while (input != 0);   numAmount--;

Console.WriteLine("Totala summan av alla nummer " + numSum + "\nTotalt antal nummer " + numAmount);





