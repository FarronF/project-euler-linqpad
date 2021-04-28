<Query Kind="Program" />

void Main()
{
	long[,] grid = new long[1001,1001];
	grid[500,500]=1;
	//Console.WriteLine(grid);
	int count = 1, groupCount = 0, increment = 2;
	int sum = 1;
	int size = 1001;
	int finalSize = size*size;
	while(count<finalSize)
	{
		count+=increment;
		Console.WriteLine(count);
		sum+=count;
		groupCount++;
		if(groupCount==4)
		{
			increment+=2;
			groupCount=0;
		}
	}
	Console.WriteLine(sum);
	
}

// Define other methods and classes here
