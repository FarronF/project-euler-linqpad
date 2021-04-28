<Query Kind="Program" />

void Main()
{
	int primeNumberCountCap = 10001;
	int primeNumberCount = 1;
	long check = 1;
	while(primeNumberCount<primeNumberCountCap)
	{
		check=check+2;
		if(PrimeChecker(check)==true)
			primeNumberCount++;
	}
	Console.WriteLine(check);
}
static bool PrimeChecker(long checkNum)
{
		bool isPrime;
		if(checkNum<=3)
		{
			isPrime = true;
			
		}
		else if(checkNum%2==0)
		{
			isPrime = false;
		}
		else
		{
			isPrime = true;
			long half = checkNum/2;
			long workingNum = 3;
			while(isPrime==true&&workingNum <= half)
			{			
				if(checkNum%workingNum==0)
				{
					isPrime = false;
				}
				workingNum = workingNum + 2;
			}
		}
		return isPrime;
}
// Define other methods and classes here
