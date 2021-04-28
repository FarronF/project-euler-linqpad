<Query Kind="Program" />

void Main()
{
	long sum = 0; 
	int pos = 0, pos2, current;
	List<int> list = new List<int>();
	List<int> list2 = new List<int>();
	List<int> primeList = new List<int>();
	
	list = Enumerable.Range(2, 99999).ToList();//99999  	454396537
	//Console.WriteLine(list);
	while(list.Count>0)
	{
		//Console.WriteLine(list);
		current = list[0];
		//Console.WriteLine(list);
		
		sum = sum + current;
		pos2 = pos+1;
		list2.Clear();
		for(int i=0;i<list.Count;i++)
		{
			list2.Add(list[i]*current);
		}
		
		list = list.Except(list2).ToList();
	
		list.RemoveAt(0);
		/*while(pos2<list.Count)
		{
			if(list[pos2]%current==0)
				list.RemoveAt(pos2);
			else
				pos2++;
		}*/
	}
	Console.WriteLine(sum);
	//Console.WriteLine(list);	
}

static bool PrimeChecker(long checkNum)
{
		bool isPrime;
		if(checkNum<=3)
		{
			isPrime = true;
			
		}
		else if(checkNum%2==0)
		{
			isPrime = false;
		}
		else
		{
			isPrime = true;
			long half = checkNum/2;
			long workingNum = 3;
			while(isPrime==true&&workingNum <= half)
			{			
				if(checkNum%workingNum==0)
				{
					isPrime = false;
				}
				workingNum = workingNum + 2;
			}
		}
		return isPrime;
}