using DetergentDoseCalculator;

//TODO - For master loop, include option to quit as well as choose another detergent
MainCalculate();

static void MainCalculate()
{
    var allDetergents = DetergentRepository.InitializeDetergents();

Console.WriteLine("Here are some detergents we recommend:");
foreach (var detergent in allDetergents.Values)
{
    Console.WriteLine($"{detergent.Name} ({detergent.Consistency})");
}
string? userInput = Detergent.ChooseDetergent();

    bool detergentAvailable = allDetergents.TryGetValue(userInput, out Detergent? chosenDetergent);
    if (detergentAvailable)
    {
        string defaultDoseStatement = Detergent.Announce(chosenDetergent.Name, chosenDetergent.Consistency, chosenDetergent.BaseDose);
        Console.WriteLine(defaultDoseStatement);
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
        Console.WriteLine();
        MainCalculate();
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
}
