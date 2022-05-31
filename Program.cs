// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your water hardness level? (Soft/Med/Hard)");
    string? hardness = Console.ReadLine();
    
    if (hardness == "Soft") // How to make these case insensitive?
    {
    Console.WriteLine("What detergent would you like to use?");
    Console.WriteLine("1 - Biozet Attack powder, 2 - Radiant liquid, 3 - Kin Kin Naturals liquid, 4 - b clean co powder (Type only the number)");
    var detergentChoice = Console.ReadLine();
    }
    else if (hardness == "Med")
    {
    Console.WriteLine("What detergent would you like to use?");
    Console.WriteLine("1 - OMO/Persil powder, 2 - b clean co powder, 3 - Biozet Attack powder, 4 - Zero Co liquid (Type only the number)");
    var detergentChoice = Console.ReadLine();
    }
    else
    {
    Console.WriteLine("What detergent would you like to use?");
    Console.WriteLine("1 - OMO/Persil powder, 2 - Radiant powder, 3 - b clean co powder, 4 - Trimat Advanced powder (Type only the number)");
    var detergentChoice = Console.ReadLine();
    }

/* Console.WriteLine("Is your washing machine 7–7.5 kg? (Yes/No)");
bool Yes = true;
Console.ReadLine();

if (Yes) // How to make this case insensitive?
{
  
} */
