//Welcome message
Console.WriteLine("Homework Seven");
Console.WriteLine("--------------");

//Declare variables
List<string> classRosterList = new List<string>();
bool addAgain;

do
{
    addAgain = false;
    string currentContent = string.Empty;
    Console.WriteLine();

    //Prepare employee list for ouput
    if (classRosterList.Count > 0)
    {
        currentContent = classRosterList[0];
        int ctr = 1;
        while (ctr < classRosterList.Count)
        {
            currentContent += $", {classRosterList[ctr++]}";
        }
    }
    else
    {
        currentContent = "[None]";
    }

    //Get user input
    Console.WriteLine("---------------------");
    Console.WriteLine($"Current Class Roster: {currentContent}");
    Console.WriteLine("---------------------");
    Console.Write("Enter student's name to add (leave blank to exit): ");
    string? studentName = Console.ReadLine();
    addAgain = studentName?.Length > 0;

    if (addAgain)
    {
        classRosterList.Add(studentName);
    }

} while (addAgain);

//End of program
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();