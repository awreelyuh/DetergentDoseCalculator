using DetergentDoseCalculator;

var allDetergents = DetergentRepository.InitializeDetergents();

Console.WriteLine("Here are some detergents we recommend:");
foreach (var detergent in allDetergents.Values)
{
    Console.WriteLine($"{detergent.Name} {detergent.Consistency}");
}

Console.Write("\nWhich detergent do you want to use? ");
string? userInput = Console.ReadLine();

//userInput.ToUpper() == allDetergents.Keys.ToUpper();

bool detergentAvailable = allDetergents.TryGetValue(userInput, out Detergent value);
if (detergentAvailable)
{
    DetergentRepository.AnnounceDetails(value);
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
    Console.WriteLine("What size is your washing machine?");
    double washerSize = Convert.ToDouble(Console.ReadLine());
    var detergentDose = BaseDose + (washerSize - 7.5);   //TODO - add 25% for each kg over; this is not right
}
else if (isLarger == "N")
{
    Console.WriteLine("You're good to go. Happy washing!");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Invalid input. Please try again.");
    Console.Write("Is your washer larger than 7.5 kg? \nEnter Y for yes or N for no: ");
    //Does it return to outside of if-else loop
}