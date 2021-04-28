<Query Kind="Program" />

void Main()
{
	int sum = 2; 
	
	//Console.WriteLine(list);
	for(int i = 3;i<2000000;i=i+2)
	{
		if(isPrime(i))
			sum = sum + i;	
	}
	Console.WriteLine(sum);
	//Console.WriteLine(list);	
}

bool isPrime(double n)
{
	double r,f;
	if(n==1)
		return false;
	else if(n<4)
		return true;  //2 and 3 are prime
	else if(n%2==0)
		return false;
	else if (n<9)
		return true;   //we have already excluded 4,6 and 8.
	else if(n%3==0)
		return false;
	else
	{
		r=Math.Floor((double)n);  // n  rounded to the greatest integer r so that r*r<=n
		f=5;
	   	while(f<=r)
		{
			if(n%f==0)
				return false;
			if(n%(f+2)==0)
				return false;
			f=f+6;
		}
		return true;
	}
}