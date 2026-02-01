// Prompt the user for their name
Console.Write("Please enter your name: ");

// Read the name from console (never null)
string userName = Console.ReadLine() ?? "Guest";

// String interpolation (modern & recommended)
Console.WriteLine($"Hello {userName}");
