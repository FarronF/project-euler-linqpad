<Query Kind="Program" />

void Main()
{
	int cap = 100;
	int squareSum = 0,sum = 0;
	for(int i=1;i<=cap;i++)
	{
		squareSum = squareSum+(i*i);
		sum = sum + i;
	}
	Console.WriteLine((sum*sum)-squareSum);
}

// Define other methods and classes here
