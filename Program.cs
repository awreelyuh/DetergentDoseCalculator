using DetergentDoseCalculator;

//Project Feature: "Implement a 'master loop' console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program"
MainCalculate();
ChooseActionAgain();

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
        Console.WriteLine("Invalid input. Press any key to try again.");
        Console.ReadLine();
        Console.Clear();
        MainCalculate();
    }

    WashingMachine.CheckWashingMachineSize(chosenDetergent);
}

static void ChooseActionAgain()
{
    Console.Write("Would you like to choose another detergent? Type Y to start over, or any other key to quit: ");
    string? startOver = Console.ReadLine().ToUpper();
    switch (startOver)
    {
        case "Y":
            Console.Clear();
            MainCalculate();
            ChooseActionAgain();
            break;
        default:
            Environment.Exit(0);
            break;
    }
}