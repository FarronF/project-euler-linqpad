<Query Kind="Program" />

void Main()
{
	const int CAP = 28123;
	bool[] abundantArray = new bool[CAP+1];
	long sum = 0;
	int rev;
	bool check;
	int half;
	for(int i = 1;i<=CAP;i++)
	{
	 	if(i<sumDivisors(i))
		{
			abundantArray[i]=true;
			//Console.WriteLine(i);
		}
		
		rev = i-1;
		check = false;
		half = i/2;
		while(check==false)
		{
			if(abundantArray[rev]==true)
			{
				//Console.WriteLine(rev+"+"+(i-rev));
				if(abundantArray[i-rev]==true)
				{
					check=true;
				}
			}
			rev--;
			if(rev<half&&check!=true)
			{
				sum+=i;
				check=true;
				//Console.WriteLine(i+":"+sum);
			}
		}
	}
	Console.WriteLine(sum);
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
