using DetergentDoseCalculator;

var allDetergents = DetergentRepository.InitializeDetergents();

Console.WriteLine("Here are some detergents we recommend:");
foreach (var detergent in allDetergents.Values)
{
    Console.WriteLine($"{detergent.Name} {detergent.Consistency}");
}

Console.Write("\nWhich detergent do you want to use? ");
string? userInput = Console.ReadLine();

Detergent chosenDetergent = allDetergents[userInput];

//TODO - Figure out a `while` loop so user can continue trying to type correct option

bool detergentAvailable = allDetergents.TryGetValue(userInput, out Detergent? detergent1);
    if (detergentAvailable)
    {
        Console.WriteLine($"Based on a 7.5 kg washing machine capacity, you need {detergent1.BaseDose} cap / scoop of {detergent1.Name} {detergent1.Consistency} for your main wash."); ;
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
        Console.Write("Which detergent do you want to use? ");
    }


float BaseDose = 1.5f;

Console.Write("\nIs your washer larger than 7.5 kg? \nEnter Y for yes or N for no: ");
var isLarger = Console.ReadLine().ToUpper();

if (isLarger == "Y")
{
    Console.Write("How many kg is your washing machine capacity? ");
    double washerCapacity = Convert.ToDouble(Console.ReadLine());
    double increasedDetergentDose = (detergent1.BaseDose + ((washerCapacity - 7.5) * 0.25));   //TODO - add 25% for each kg over; this is not right
    var finalDetergentDose = Math.Round(increasedDetergentDose, 2);
    Console.WriteLine($"\nFor your {washerCapacity} kg washing machine, you need {finalDetergentDose} cap / scoop of {detergent1.Name} {detergent1.Consistency} for your main wash.");
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
    Console.Write("Is your washer larger than 7.5 kg? \nEnter Y for yes or N for no: ");
    //Does it return to outside of if-else loop
}