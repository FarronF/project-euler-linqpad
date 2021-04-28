<Query Kind="Program" />

void Main()
{
	const int SIZE = 13;
	const int MOVE_CAP = SIZE*2;
	List<bool> test1 = new List<bool>() {true};
	List<bool> test2 = new List<bool>() {false};

	//Not sure why test is needed but it is.
	List<List<bool>> paths1 = new List<List<bool>>() {test1,test2};
	List<List<bool>> paths2 = new List<List<bool>>();
	
	for(long i = 1;i<MOVE_CAP;i++)
	{
		foreach(List<bool> current in paths1)
		{
			if(countDORR(current,true)<SIZE)
			{
				List<bool> addable = new List<bool>(current);
				addable.Add(true);
				paths2.Add(addable);
			}
			if(countDORR(current,false)<SIZE)
			{
				List<bool> addable = new List<bool>(current);
				addable.Add(false);
				paths2.Add(addable);
			}
			
		}
		paths1 = new List<List<bool>>(paths2);
		
		paths2.Clear();
	}
	Console.WriteLine(paths1.Count());
	Console.WriteLine(paths1);
}

// Define other methods and classes here
int countDORR(List<bool> given, bool downRight)
{
	int count = 0;
	foreach(bool check in given)
	{
		if(check==downRight)
			count++;
	}
	return count;
}