<Query Kind="Program" />

void Main()
{
	int diam, len;
	string line;
	string[] charArray;
	
	diam = 7;
	
	if(diam<3)
		Console.WriteLine("Must be 3 or higher");
	int rad = (int)Math.Ceiling(((double)diam)/2);
	
	Console.WriteLine(rad);
	charArray = new string[diam];
	for(int i = 0;i<diam;i++)
	{
		for(int j=0;j<rad;j++)
		{
			if(j==Math.Abs(rad-i-1))
			{
				charArray[j]="*";
				charArray[diam-1-j]="*";
			}
			else
			{
				charArray[j]=" ";
				charArray[diam-j-1]=" ";
			}
		}
		Console.WriteLine(string.Join("",charArray));
	}
}

// Define other methods and classes here
