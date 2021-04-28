<Query Kind="Program" />

void Main()
{
	int maxDigit = factorial(9);
	int maxCheck = maxDigit;
	int max = 9;
	int maxAdd = max;
	int factCheck, factSum, sum=0;
	while(max<maxCheck)
	{
		maxAdd*=10;
		max+=maxAdd;
		maxCheck+=maxDigit;
	}
	//Console.WriteLine(max+":"+maxCheck);
	for(int i = 10;i<=max;i++)
	{
		factCheck = i;
		factSum = 0;
		while(factCheck>0)
		{
			factSum+=factorial(factCheck%10);
			factCheck/=10;
		}
		if(i==factSum)
		{
			sum+=i;
			Console.WriteLine(i);
		}
	}
	Console.WriteLine(sum);
}

// Define other methods and classes here
int factorial(int x)
{
	int sum=1;
	for(int i=x;i>1;i--)
		sum*=i;
	return sum;
}
