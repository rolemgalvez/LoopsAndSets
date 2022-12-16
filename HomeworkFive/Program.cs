//Welcome message
Console.WriteLine("Homework Five");
Console.WriteLine("-------------");

bool runAgain = true;

while (runAgain)
{
    //Get user input
    Console.WriteLine();
    Console.Write("Enter your name (type \"exit\" to end program): ");
    string? name = Console.ReadLine();

    //Process input
    if (name?.ToLower() == "exit")
    {
        runAgain = false;
    }
    else
    {
        runAgain = true;
    }

    string welcomeName = $"Student {name}";
    if (name?.ToLower() == "tim")
    {
        welcomeName = $"Professor {name}";
    }

    //Show results
    if (string.IsNullOrEmpty(name) == false)
    {
        Console.WriteLine($"Hi {welcomeName}!");
    }
}

Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();