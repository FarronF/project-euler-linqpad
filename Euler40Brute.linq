<Query Kind="Program" />

void Main()
{
	//Using StringBuilder reduced from 1m03s to .03s
	StringBuilder dec = new StringBuilder(".");
	long count = 1;
	int check = 1;
	int ans = 1;
	int digit;
	while(dec.Length<1000001)
	{
		dec.Append(count);
		if(dec.Length>check)
		{
			Int32.TryParse(dec[check].ToString(),out digit);
			Console.WriteLine(digit);
			check*=10;
			ans*=digit;
		}
		count++;
	}
	Console.WriteLine(ans);
}

// Define other methods and classes here