<Query Kind="Program" />

void Main()
{
	const int RANGE = 1000;
	int n,highest=0,highestA=0,highestB=0,count;
	bool primeBool;
	//n² + an + b
	for(int a=1;a<RANGE;a++)
	{
		//Console.WriteLine(a);
		for(int b=1;b<RANGE;b++)
		{
			//Console.WriteLine(b);
			n=0;
			primeBool = true;
			while(PrimeChecker((n*n) + (a*n) + b))
			{
				n++;
			}
			if(n>highest)
			{
				highest=n;
				highestA=a;
				highestB=b;
			}
			//Console.WriteLine("TEST");
			
			n=0;
			while(PrimeChecker((n*n) + (-a*n) + b))
			{
				n++;
			}
			if(n>highest)
			{
				highest=n;
				highestA=-a;
				highestB=b;
			}
			
			n=0;
			while(PrimeChecker((n*n) + (a*n) + -b))
			{
				n++;
			}
			if(n>highest)
			{
				highest=n;
				highestA=a;
				highestB=-b;
			}
			
			n=0;
			while(PrimeChecker((n*n) + (-a*n) + -b))
			{
				n++;
			}
			if(n>highest)
			{
				highest=n;
				highestA=-a;
				highestB=-b;
			}
		}
		/*
	Console.WriteLine("highest:"+highest);
	Console.WriteLine("highestA:"+highestA);
	Console.WriteLine("highestB:"+highestB);
	Console.WriteLine("highestProd:"+(highestB*highestA)); 
	Console.WriteLine("------------------");*/
	}
	Console.WriteLine("highest:"+highest);
	Console.WriteLine("highestA:"+highestA);
	Console.WriteLine("highestB:"+highestB);
	Console.WriteLine("highestProd:"+(highestB*highestA));

}



// Define other methods and classes here
bool calc(int a, int b, int n)
{

	if(PrimeChecker((n*n) + (a*n) + b))
		return true;
	else
		return false;

}

bool PrimeChecker(long checkNum)
	{
			//checkNum = Math.Abs(checkNum);
			
			//Console.WriteLine(checkNum);
			bool isPrime;
			
			if(checkNum<0)
				isPrime=false;
			else if(checkNum<=3)
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
						//factor1 = workingNum;
						//factor2 = checkNum/workingNum;
					}
					workingNum = workingNum + 2;
				}
			}
			
			return isPrime;
}