<Query Kind="Program" />

void Main()
{
	const int CAP = 1000000;
	int largestChain = 0, largestChainNum = 0, chainCount;
	for(int i=1;i<=CAP;i++)
	{
		chainCount = Collatz(i);
		if(chainCount>largestChain)
		{
			largestChain = chainCount;
			largestChainNum = i;
		}

	}
	Console.WriteLine(largestChainNum + ":" + largestChain);
}

// Define other methods and classes here
int Collatz(int x)
{
	long num = (long)x;
	int count = 1;
	while(num!=1)
	{
		if(num%2==0)
			 num/=2;
		else
			num=(num*3)+1;
		count++;
	}
	return count;
}