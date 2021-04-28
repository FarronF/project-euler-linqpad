<Query Kind="Program" />

class Euler2                       // Class declaration
{

  static void Main()              //   Method declaration
  {
	int last = 1;
	int current = 2;
	int oldLast = 0;
	int sum = 0;
	while(current < 4000000)
	{	
		if(current%2==0)
		{
			sum = sum+current;
		}
		
		oldLast = last;
		last = current;
		current = current + oldLast;
		
	}

	
	Console.WriteLine(sum);
		
	
  }                               //   End of method
}    