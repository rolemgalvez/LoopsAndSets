//Welcome message
Console.WriteLine("Homework Nine");
Console.WriteLine("-------------");
Console.WriteLine();

//Get input
Console.Write("Enter first names (separated by comma): ");
string userInput = Console.ReadLine();

//Process input
string[] firstNames = userInput.Split(',');

//Show output
if (firstNames.Length > 1)
{
	for (int i = 0; i < firstNames.Length; i++)
	{
		Console.WriteLine($"Hello {firstNames[i]}");
	} 
}

//End
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();