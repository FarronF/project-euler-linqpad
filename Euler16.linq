<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

void Main()
{
	int pow = 1000;
	BigInteger num = (BigInteger)Math.Pow(2,pow);
	Console.WriteLine(num);
	BigInteger sum = 0;
	while(num>0)
	{
		sum+=num%10;
		num/=10;
	}
	Console.WriteLine(sum);
}

// Define other methods and classes here
