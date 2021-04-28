<Query Kind="Program" />

void Main()
{	
		const int SIZE = 21;
		const int MOVE_CAP = SIZE*2;
		
		long[,] grid = new long[SIZE,SIZE];
		grid[0,0] = 1;
		
		for(int i=0;i<SIZE;i++)
		{	
			if(i>0)
				grid[i,i] = grid[i-1,i]+grid[i,i-1];
			for(int j = i + 1; j<SIZE; j++)
			{
				if(i>0)
				{
					grid[i,j]=grid[i,j-1]+grid[i-1,j];
					grid[j,i]=grid[j-1,i]+grid[j,i-1];
				}
				else
				{
					grid[i,j]=grid[i,j-1];
					grid[j,i]=grid[j-1,i];
				}
			}
		}
		Console.WriteLine(grid);
}

// Define other methods and classes here
