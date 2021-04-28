<Query Kind="Program" />

void Main()
{
	int convertable;
	int reversedNumber = 0, digit;
	string strVersion = ""S;
	bool neg;
	
	
		convertable = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Input: "+convertable);
	
	
	
	if(convertable<0)
		neg=true;
	else
		neg=false;
	
	while(convertable!=0)
	{
		digit = (Math.Abs(convertable%10));
		
		strVersion = digit+strVersion;
		convertable = convertable/10;
		reversedNumber = (reversedNumber * 10) + digit;
	}
	if(neg==true)
	{
		strVersion="-"+strVersion;
		reversedNumber = reversedNumber*-1;
	}
	Console.WriteLine("String version: "+strVersion);
	Console.WriteLine("Reveresed version: "+reversedNumber);	
}

// Define other methods and classes here
