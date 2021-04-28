<Query Kind="Program" />

void Main()
{
	int n;
	int oneCount = 0;
	string userInput;
	
	Console.WriteLine("Enter Integer:");
	userInput = Console.ReadLine();
	
	if(int.TryParse(userInput, out n))
	{
		string binaryForm = Convert.ToString(n, 2);
		//Console.WriteLine(binaryForm);
		for(int i = 0;i<binaryForm.Length;i++)
		{
			//Console.WriteLine(binaryForm[i]);
			if(binaryForm[i].Equals('1'))
				oneCount++;
		}
		Console.WriteLine(oneCount);
	}
	else
		Console.WriteLine("Not an integer");
}

// Define other methods and classes here
