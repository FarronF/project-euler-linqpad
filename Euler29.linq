<Query Kind="Program" />

void Main()
{
	const int MAX = 100;
	double result;
	List<double> results = new List<double>();
	for(int a = 2;a<=MAX;a++)
	{
		for(int b = 2;b<=MAX;b++)
		{
				result = Math.Pow(a,b);
				if(results.IndexOf(result)==-1)
					results.Add(result);
		}
	}
	Console.WriteLine(results.Count);
}

// Define other methods and classes here
