//Welcome
Console.WriteLine("Homework Ten");
Console.WriteLine("------------");
Console.WriteLine();

//Input
List<string> firstNames = new();
bool runAgain = true;

while (runAgain)
{
    Console.Write("Enter first name: ");
    string userInput = Console.ReadLine();
    firstNames.Add(userInput);

    runAgain = string.IsNullOrEmpty(userInput) == false;
}

//Output
Console.WriteLine();
foreach (string name in firstNames)
{
    Console.WriteLine($"Hello {name}!");
}

//End 
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();