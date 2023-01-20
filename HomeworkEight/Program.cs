//Welcome message
Console.WriteLine("Homework Eight");
Console.WriteLine("--------------");

//Declare variables
Dictionary<int, string> records = new Dictionary<int, string>();
bool runAgain;

do
{
    runAgain = false;
    Console.Write("\n[0] Add Record [1] Find Record [2] Exit: ");
    string? choice = Console.ReadLine();


} while (runAgain);