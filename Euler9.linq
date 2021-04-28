<Query Kind="Program" />

void Main()
{
	double a = 1, b = 1, c;
	double aSq = 1, bSq = 1;
	bool check = false;
	while(check==false&&a<=1000)
	{
		aSq = Math.Pow(a,2);
		b = a;
		bSq = Math.Pow(b,2);
		while(check==false&&b+a<=1000)
		{
			bSq = Math.Pow(b,2);
			c = Math.Sqrt(aSq + bSq);
			if(a+b+c==1000)
			{
				Console.WriteLine(a+","+b+","+c);
				Console.WriteLine(a*b*c);
			}
			b++;
		}
		a++;
	}
}

// Define other methods and classes here
