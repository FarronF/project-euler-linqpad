<Query Kind="Program" />

void Main()
{
	//int  number = 1000001;
	int  number = 999999, current;
	List<int> list = new List<int>();
	List<int> list2 = new List<int>();
	List<int> primeList = new List<int>();
	
	list = Enumerable.Range(2, number).ToList();//99999  	454396537
		
	while(list.Count>0)
	{
		current = list[0];
		primeList.Add(current);
		for(int i=0;i<list.Count;i++)
			list2.Add(list[i]*current);	
		list.RemoveAt(0);
		list = list.Except(list2).ToList();
		list2.Clear();
	}
	Console.WriteLine(primeList);
	
	/*
	bool[] list = new bool[number];
	int workNum, digit, greatest;
	
	for(int i=2; i<number;i++)
	{
		if(list[i]==false)
		{
			
			workNum = i;
			while(workNum>10)
			{
				digit = workNum%10;
				digit/=10;
				if(digit>greatest)
					greatest=digit;
			}
			if(workNum>greatest)
			{
				//Do the thing;
			
			}
			//sum+=i;
			for(int j=i*2; j<number;j+=i)
			{
					list[j] = true;
			}
		}
	}
	*/

	
	//Console.WriteLine(sum);
}

// Define other methods and classes here