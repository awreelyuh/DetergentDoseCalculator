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

    WashingMachine.CheckWashingMachineSize(chosenDetergent);
}

