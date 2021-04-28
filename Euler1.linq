<Query Kind="Program">
  <Namespace>System</Namespace>
</Query>

class Test                        // Class declaration
{

  static void Main()              //   Method declaration
  {
  	int sum = 0;
  	int x = 3;
	while (x < 1000)
	{
		sum = sum + x;
		x += 3;
	}
	
	int y = 5;
	while (y < 1000)
	{
		if(y%3!=0)
		{
			sum = sum + y;
		
		}
		y += 5;
	}
	
	Console.WriteLine(sum);
  }                               //   End of method
}    