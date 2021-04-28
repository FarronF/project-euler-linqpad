<Query Kind="Program" />

class Euler3                   // Class declaration
{
	long factor1;
	long factor2;
	
	static void Main()              //   Method declaration
	{
			EulerTools test = new EulerTools();
			long[] primeCheck = test.PrimeFactors(600851475143);
			Console.WriteLine(primeCheck);
	}                               //   End of method
	bool PrimeChecker(long checkNum)
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
						factor1 = workingNum;
						factor2 = checkNum/workingNum;
					}
					workingNum = workingNum + 2;
				}
			}
			return isPrime;
	}
	
	void SetFactors(long x, long y)
	{
	
	}
	
  	long[] PrimeFactors(long x)
  	{
		
		if(PrimeChecker(x)==true)
		{
			return new long[]{x};
		}
		else
		{
			List<long> list = new List<long>();
			list.Add(x);
			int pos = 0;
			while(pos<list.Count())
			{
				if(PrimeChecker(list[pos]))
				{
					pos++;
				}
				else
				{
					list.RemoveAt(pos);
					list.Add(factor1);
					list.Add(factor2);
				}
			}
			return(list.ToArray());
			
		}
  	}
}    