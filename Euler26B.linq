<Query Kind="Program" />

void Main()
{
	const int MAX = 1000;
	string pattern, decStr;
	int highest = 0, patternLength, pos1=0, pos2=0, count, highestPos=0, divis, times ,remainder;
	decimal dec;
	List<int> prev = new List<int>();
	bool recur, zero;
	
	for(int i = 1;i<=MAX;i++)
	{
		recur = false;
		zero = false;
		divis = 1;
		prev.Clear();
		pos2=0;
		while(recur==false&&zero==false)
		{
			//times = divis/i;
			pos1=prev.IndexOf(divis);
			//Console.WriteLine(pos2+":"+pos1);
			if(pos1==-1)
			{
				remainder = divis%i;
				prev.Add(divis);
				divis = remainder*10;
				pos2++;
			}
			else
			{
				recur=true;
			}
		}
		patternLength = pos2-pos1;
		if(patternLength>highest)
		{
			highest=patternLength;
			highestPos=i;
		}
	}
	Console.WriteLine(highestPos+":"+highest);

}

// Define other methods and classes here
