<Query Kind="Program" />

void Main()
{
	string[] under20 = new  string[]{"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight","Nine","Ten","Eleven","Twelve","Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Nineteen"};
	string[] tens = new string[]{"","","Twenty","Thirty","Forty","Fifty","Sixty","Seventy","Eighty","Ninety"};
	string hun = "Hundred";
	string thou = "Thousand";
	const int MAX = 1000;
	long charCount = 0;
	int workingNum;
	int t, h, d, s;
	StringBuilder fullStr = new StringBuilder();
	
	for(int i = 1;i<=MAX;i++)
	{
		t = i/1000;
		h = (i%1000)/100;
		d = (i%100)/10;
		s = i%10;
		
		if(t>0)
		{
			charCount+=under20[t].Length+thou.Length;
			fullStr.Append(under20[t]+thou);
		}
		if(h>0)
		{
			charCount+=under20[h].Length+hun.Length;
			fullStr.Append(under20[h]+hun);
		}
		
		//and check
		if(h!=0&&d!=0||h!=0&&s!=0)
		{
			charCount+=3;
			//Console.WriteLine("AND");
			fullStr.Append("AND");
		}
		
		if(d>1)
		{
			charCount+=tens[d].Length;
			fullStr.Append(tens[d]);
		}
		if(d==1)
		{
			charCount+=under20[10+s].Length;
			fullStr.Append(under20[10+s]);
		}
		else
		{
			charCount+=under20[s].Length;
			fullStr.Append(under20[s]);
		}
		//fullStr.Append(",");
		//Console.WriteLine(i+":"+charCount);

	}
	Console.WriteLine(fullStr.ToString());
	
	Console.WriteLine(fullStr.Length);
	Console.WriteLine(charCount);
}

// Define other methods and classes here
