<Query Kind="Program" />

void Main()
{
	int  number = 2000001;
	long sum = 0;
	bool[] list = new bool[number];
	
	
	for(int i=2; i<number;i++)
	{
		if(list[i]==false)
		{
			sum+=i;
			for(int j=i*2; j<number;j+=i)
			{
					list[j] = true;	
			}
		}
	}
	

	
	Console.WriteLine(sum);
}

// Define other methods and classes here