<Query Kind="Program" />

void Main()
{
	bool check = false;
	bool check2;
	int cap = 20;
	int current = cap;
	int divider;
	while(check==false)
	{
		divider = 1;
		check2=true;
		
		while(check2!=false&&divider<=cap)
		{
			if(current%divider==0)
				check2=true;
			else
				check2=false;
			divider++;
		}
		if(check2==true)
			check=true;
		else
			current++;
	}
	Console.WriteLine(current);
}

// Define other methods and classes here
