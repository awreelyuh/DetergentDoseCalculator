using System.Collections.Generic;
using DetergentDoseCalculator;

Console.WriteLine("Here are some detergents we recommend:");
Console.WriteLine(DetergentRepository.GetDetergents());
Console.WriteLine();
Console.Write("Which detergent do you want to use? ");
string userInput = Console.ReadLine().ToUpper();

var det = DetergentRepository.ReadAllDetergents(); 

bool detergentAvailable = det.ContainsKey(userInput);

if (!detergentAvailable)
{
    Console.WriteLine($"Sorry, {userInput} is not on the list. Please try again.");
    Console.Write("Which detergent do you want to use? ");
}
else
{
    // DetergentRepository.AnnounceDetails();
}
//if (userInput == null)
//{
//    Console.WriteLine("Invalid input. Please try again.");
//    Console.Write("Is your washer larger than 7.5 kg? \nEnter Y for yes or N for no: ");
//}
//else if (userInput.ContainsKey(detergent.Name))
//{

//}

float BaseDose = 1.5f;

Console.Write("Is your washer larger than 7.5 kg? \nEnter Y for yes or N for no: ");
var isLarger = Console.ReadLine().ToUpper();

if (isLarger == "Y")
{
    Console.WriteLine("What size is your washing machine?");
    double washerSize = Convert.ToDouble(Console.ReadLine());
    var detergentDose = BaseDose + (washerSize - 7.5);   //TODO - add 25% for each kg over; this is not right
}
else if (isLarger == "N")
{
    Console.WriteLine("You're good to go. Happy washing!");
}
else
{
    Console.WriteLine("Invalid input. Please try again.");
    Console.Write("Is your washer larger than 7.5 kg? \nEnter Y for yes or N for no :");
    //Does it return to outside of if-else loop
}