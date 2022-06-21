// See https://aka.ms/new-console-template for more information
using DetergentDoseCalculator;

Console.WriteLine("What detergent do you want to use?");

string? Name = Console.ReadLine(); // This becomes key to pull detergent from index?
//How to get item from List<Detergent> via key?
Detergent.Announce(Name, BaseDose);

Console.Write("Is your washer larger than 7.5 kg? Y/N");
bool isLarger == Console.ReadLine("Y");
if (isLarger)
{
    Console.WriteLine("What size is your washing machine?");
    float washerSize = float.Parse(Console.ReadLine());
    var detergentDoze = BaseDose + (washerSize - 7.5);   //TODO - add 25% for each kg over; this is not right
}    
else
{
    Console.WriteLine("You're good to go. Happy washing!");
}