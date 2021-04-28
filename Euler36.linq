<Query Kind="Program" />

void Main()
{
	int cap = 1000000;
	int sum = 0;
	for(int i=1;i<cap;i++)
	{
		if(doublePalindrome(i))
		{
			sum+=i;
		}
	}
	Console.WriteLine(sum);
	//Console.WriteLine(doublePalindrome(585));
	//Console.WriteLine(isPalindrome("TEEET"));
}

// Define other methods and classes here
bool doublePalindrome(int x)
{
	string binary = Convert.ToString(x, 2);
	string str = Convert.ToString(x, 10);
	if(isPalindrome(str)&&isPalindrome(binary))
		return true;
	else
		return false;
}

bool isPalindrome(string value)
{
	bool isPal = true;
	int len = value.Length, count=0;
	while(isPal==true&&count<len/2)
	{
		if(value[count]!=value[len-count-1])
			isPal=false;
		count++;
	}
	return isPal;
}