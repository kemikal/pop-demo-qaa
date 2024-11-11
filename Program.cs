// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using netqa;

Console.WriteLine("Hello, World!");

// int tal;
// bool run = true;

// while(run) 
// {
// 	System.Console.WriteLine("Säg en siffra! (Eller skriv x för att avsluta)");
	
// 	string input = Console.ReadLine();
// 	//Console.ReadLine();

// 	if (int.TryParse(input, out tal)) 
// 	{
// 		System.Console.WriteLine("Ja va duktig du är! Du skrev ett tal: " + tal);
// 	} else 
// 	{
// 		if (input == "x") 
// 		{
// 			System.Console.WriteLine("Avslutar");
// 			run = false;
// 		} else 
// 		{
// 			System.Console.WriteLine("Nej, läs igen! Gör rätt!");
// 		}
// 	}
// }

bool run = true;
List<User> users = new List<User>();

while (run) 
{
	System.Console.WriteLine("Vad vill du göra?");
	System.Console.WriteLine("A. Lägg till en ny användare");
	System.Console.WriteLine("B. Se alla användare");
	System.Console.WriteLine("X. Avsluta programmet");
	
	string choice = Console.ReadLine();
	
	Console.Clear();
	
	switch(choice) 
	{
		case "a":
			System.Console.WriteLine("Vem vill du lägga till?");
			string newName = Console.ReadLine();
			users.Add(new User(newName));
		break;
		
		case "b":
			System.Console.WriteLine("Här är alla användarna:");
			
			foreach(User user in users) 
			{
				System.Console.WriteLine("- " + user.Name);
			}
 			
		break;
		
		case "x":
			run = false;
			System.Console.WriteLine("Avslutar");
		break;
		
		default:
			System.Console.WriteLine("Ogiltigt menyval");
		break;
	}
}

