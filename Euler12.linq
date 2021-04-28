<Query Kind="Program" />

void Main()
{
	const int LOOKING_FOR=500;
	long loopCount = 1;
	int divCount = 0;
	long numCheck = 0;
	
	while(divCount<LOOKING_FOR)
	{
		numCheck+=loopCount;
		loopCount++;
		divCount = numDivisors(numCheck);
	}
	Console.WriteLine(numCheck+":"+divCount);
}

int numDivisors(long x)
{
	double square = (double)Math.Sqrt(x);
	int count = 0;
	for(int i=1;i<=square;i++)
	{
		if(x%i==0)
		{
			if(i==square)
				count++;
			else
				count+=2;
			//Console.Write("|"+i+":"+count+"|");
		}
		
	}
	return count;
}

// Define other methods and classes here