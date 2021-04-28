<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

void Main()
{
	const int n = 100;
	BigInteger factor = 1;
	BigInteger sum = 0;
	for(int i = n;i>1;i--)
		factor*=i;
	Console.WriteLine(factor);

	while(factor>0)
	{
		sum+=factor%10;
		factor/=10;
	}
	Console.WriteLine(sum);
}

// Define other methods and classes here
