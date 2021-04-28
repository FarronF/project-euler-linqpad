<Query Kind="Program" />

void Main()
{
	long sum = 0; 
	int pos = 0, pos2, current;
	
	//Console.WriteLine(list);
	while(pos<list.Count)
	{
		current = list[pos];
		//Console.WriteLine(list);
		
		pos2=pos+1;
		while(pos2<list.Count)
		{
			if(list[pos2]%current==0)
				list.RemoveAt(pos2);
			else
				pos2++;
		}
		pos++;
		
	}
	Console.WriteLine(sum);
	//Console.WriteLine(list);	
}