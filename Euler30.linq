<Query Kind="Program" />

void Main()
{
	const int POW = 5;
	int max=0, maxCheck, maxWork;
	bool abMax = false;
	int mult = 1;
	int num, sum, digit, totalSum=0;
	
	while(abMax==false)
	{
		maxCheck = 0;
		max+=(mult*9);
		maxWork = max;
		while(maxWork>0)
		{
			digit=maxWork%10;
			maxWork=maxWork/10;
			maxCheck+=(int)Math.Pow(digit,POW);
		}
		if(maxCheck<max)
		{
			abMax=true;
		}
	}
	
	
	for(int i = 2;i<354294;i++)
	{
		num = i;
		sum = 0;
		while(num>0)
		{
			digit=num%10;
			num=num/10;
			sum+=(int)Math.Pow(digit,POW);
		}
		if(sum==i)
		{
			Console.WriteLine(i);
			totalSum+=sum;
		}
	}
	Console.WriteLine(totalSum);
}

// Define other methods and classes here
