using DetergentDoseCalculator;

var allDetergents = DetergentRepository.InitializeDetergents();

Console.WriteLine("Here are some detergents we recommend:");
foreach (var detergent in allDetergents.Values)
{
    Console.WriteLine($"{detergent.Name} ({detergent.Consistency})");
}

Console.Write("\nWhich detergent do you want to use? ");
string? userInput = Console.ReadLine();

//TODO - Figure out a `while` loop so user can continue trying to type correct option

bool detergentAvailable = allDetergents.TryGetValue(userInput, out Detergent? chosenDetergent);
if (detergentAvailable)
{
    string defaultDoseStatement = Detergent.Announce(chosenDetergent.Name, chosenDetergent.Consistency, chosenDetergent.BaseDose);
    Console.WriteLine(defaultDoseStatement);
}
else
{
    Console.WriteLine("Invalid input. Please try again.");
    //giveDosageAdvice(allDetergents);
}


Console.Write("\nIs your washer larger than 7.5 kg? Y/N: ");
var isLarger = Console.ReadLine().ToUpper();

if (isLarger == "Y")
{
    string finalDoseStatement = DetergentRepository.CalculateFinalDose(chosenDetergent.Name, chosenDetergent.Consistency, chosenDetergent.BaseDose);
    Console.WriteLine(finalDoseStatement);
    Console.ReadLine();
}
else if (isLarger == "N")
{
    Console.WriteLine("\nYou're good to go. Happy washing!");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Invalid input. Please try again.");
    Console.Write("Is your washer larger than 7.5 kg? Y/N: ");
    //Does it return to outside of if-else loop
}