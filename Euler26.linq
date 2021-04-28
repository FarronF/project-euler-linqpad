<Query Kind="Program" />

void Main()
{
	const int MAX = 1000;
	string pattern, decStr;
	int highest = 0, patternLength, pos2, count, highestPos=0;
	decimal dec;
	bool recur;
	int shortest=999;
	
	for(decimal i = 6;i<=MAX;i++)
	{
		dec = 1/i;
		//Console.WriteLine(dec.ToString().Length);
		decStr = dec.ToString();
		Console.WriteLine(decStr);
		shortest = 999;
		for(int pos = 2;pos<decStr.Length;pos++)
		{
			//Console.WriteLine((decStr.Length-2-pos));
			recur=false;
			
			for(int len = 1;len<((decStr.Length-3-pos))/2;len++)
			{
//				Console.WriteLine("2");
				recur=true;
				pattern = decStr.Substring(pos,len);
				count=1;
				do
				{
//					Console.WriteLine("3");

					if(decStr.Substring(pos+(len*count),len)==pattern)
					{
						
					}
					else
						recur=false;
					count++;
				}while(recur==true&&pos+(len*count)+len<decStr.Length-1);
				
				if(recur==true&&len<shortest)
					shortest=len;
			}
			
		}
		if(shortest>highest&&shortest!=999)
		{
			highest=shortest;
			highestPos = (int)i;
		}

	}
		Console.WriteLine(highest+":"+highestPos);

}

// Define other methods and classes here
