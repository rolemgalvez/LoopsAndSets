//Welcome message
Console.WriteLine("Homework Eight");
Console.WriteLine("--------------");

//Declare variables
Dictionary<string, string> records = new Dictionary<string, string>();
bool runAgain;

do
{
    runAgain = true;
    Console.Write("\n[1] Add Record [2] Get Name [3] Exit: ");
    string? textInput = Console.ReadLine();
    int.TryParse(textInput, out int action);
    bool validInput = (action >= 1) && (action <= 3);

    if (validInput)
    {
        switch (action)
        {
            case 1:
                string recordFormat = "EmployeeId,EmployeeName";
                Console.Write($"Enter record to add ({recordFormat}): ");
                string record = Console.ReadLine();
                string[] recordParts = record.Split(',');
                string employeeId = recordParts[0];
                string employeeName = recordParts[1];
                records.Add(employeeId, employeeName);
                Console.WriteLine($"({employeeId}) {employeeName} added successfully!");
                break;
            case 2:
                Console.Write("Enter employee id: ");
                string id = Console.ReadLine();
                Console.WriteLine($"{id} is id of \"{records[id]}\".");
                break;
            default:
                runAgain = false;
                break;
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Invalid input, try again.");
    }

} while (runAgain);