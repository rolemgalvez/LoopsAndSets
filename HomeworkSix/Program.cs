//Welcome message
Console.WriteLine("Homework Six");
Console.WriteLine("------------");

//Prepare variables
bool runAgain;
string[] names = new string[3] { "Juan", "Pedro", "Miguel" };
int userInput;

do
{
    runAgain = false;
    Console.WriteLine();

    //Get user input
    Console.Write("Enter a number within 0 and 2: ");
    bool validInput = int.TryParse(Console.ReadLine(), out userInput);
    bool withinRange = (userInput >= 0) && (userInput <= 2);
    runAgain = (validInput == false) || (withinRange == false);

    //Check invalid input
    if (runAgain)
    {
        Console.WriteLine();
        Console.WriteLine("Invalid input. Try again.");
    }

} while (runAgain);

//Show result
Console.WriteLine();
Console.WriteLine($"Its equivalent name is {names[userInput]}.");

//End of program
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();