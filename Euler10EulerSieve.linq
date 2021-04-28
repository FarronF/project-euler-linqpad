<Query Kind="Program" />

void Main()
{
	int  number = 2000001;
	long sum = 0;
	List<bool> list = new List<bool>();
	
	
	for(int i=0; i<number;i++)
		list[i]=true;
	
	for(int i=2; i<number;i++)
	{
		if(list[i]==true)
		{
			sum+=i;
			for(int j=i*2; j<number;j+=i)
			{
					list[j] = false;	
			}
		}
	}
	

	
	Console.WriteLine(sum);
}

// Define other methods and classes here
