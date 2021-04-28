<Query Kind="Program" />

void Main()
{
	string userInput, reversed, rev2;
	int strLen, revPos;
	
	//userInput = Console.ReadLine();
	userInput = "Lorum Ipsum";
	reversed = string.Join("", userInput.Reverse().ToArray());
	Console.WriteLine(userInput);
	Console.WriteLine(reversed);
	reversed = "";
	
	strLen = userInput.Length;
	for(int i = 0;i<strLen;i++)
	{
		reversed = reversed + userInput[strLen-i-1];
	}
	Console.WriteLine(reversed);
	reversed = "";
	rev2 = "";
	for(int i = 0;i<=strLen/2;i++)
	{
		revPos = strLen - i - 1;
		if(i<revPos)
		{
			reversed = reversed + userInput[revPos];
			rev2 = userInput[i] + rev2;
		}
		else if(i==revPos)
			reversed = reversed + userInput[revPos];
	}
	reversed = reversed + rev2;
	Console.WriteLine(reversed);
}

// Define other methods and classes here