<Query Kind="Program" />

void Main()
{
	const int MAX = 10001;
	long[] sumDiv = new long[MAX];
	long check;
	long summed=0;
	for(int i = 1;i<MAX;i++)
	{
		if(sumDiv[i]==0)
		{
			check=sumDivisors(i);
			sumDiv[i]=check;
			if(check<MAX&&check!=i&&check>0)
			{
				if(sumDiv[check]==0)
					sumDiv[check]=sumDivisors(check);
				if(sumDiv[check]==i)
				{
					summed+=i+check;
					Console.WriteLine(i+":"+check);
				}
			}
		}
		//Console.WriteLine(sumDiv[i]);
	}
	Console.WriteLine(summed);
}

// Define other methods and classes here
long sumDivisors(long x)
{
	double square = (double)Math.Sqrt(x);
	long sum = 0;
	for(int i=1;i<=square;i++)
	{
		if(x%i==0)
		{
			if(i==square)
			{
				sum+=i;
			}
			else
			{
				sum+=(i+(x/i));
			}
			//Console.Write("|"+i+":"+count+"|");
		}
		
	}
	sum-=x;
	return sum;
}
