<Query Kind="Program" />

void Main()
{
	List<int> list1 = new List<int>{};
	List<int> list2 = new List<int>{};
	Random rnd = new Random();
	int pos;
	
	for(int i=0;i<52;i++)
		list1.Add(i);
	
	while(list1.Count>0)
	{
		pos = rnd.Next(list1.Count);
		list2.Add(list1[pos]);
		list1.RemoveAt(pos);
	}
	Console.Write(list2);
}


// Define other methods and classes here
class 