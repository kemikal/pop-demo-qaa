using System;

namespace netqa;

public class User
{
	public string Name {get; set;}
	
	public User(string name) 
	{
		this.Name = name;
	}
	
	public string getName() 
	{
		return this.Name;
	}
}
