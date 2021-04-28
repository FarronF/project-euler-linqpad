<Query Kind="Program" />

void Main()
{
	const int SIZE = 2;
	const int MOVE_CAP = SIZE*2;
	//List<bool> test1 = new List<bool>() {true};
	//List<bool> test2 = new List<bool>() {false};
	
	StringBuilder test1 = new StringBuilder("1");
	StringBuilder test2 = new StringBuilder("0");
	
	
	StringBuilder addable = new StringBuilder();
				
	//Not sure why test is needed but it is.
	//List<List<bool>> paths1 = new List<List<bool>>() {test1,test2};
	//List<List<bool>> paths2 = new List<List<bool>>();
	List<StringBuilder> paths1 = new List<StringBuilder>() {test1, test2};
	List<StringBuilder> paths2 = new List<StringBuilder>();
	
	for(int i = 1;i<MOVE_CAP;i++)
	{
		
		foreach(StringBuilder current in paths1)
		{
			if(countDORR(current,'1')<SIZE)
			{
				addable.Clear();
				addable.Append(current);
				addable.Append('1');
				paths2.Add(addable);
				Console.WriteLine(addable);
			
			}
			if(countDORR(current,'0')<SIZE)
			{
				addable.Clear();
				addable.Append(current);
				addable.Append('0');
				paths2.Add(addable);
				Console.WriteLine(addable);
			}
			
		}
		Console.WriteLine("BR");
		paths1 = new List<StringBuilder>(paths2);
		//Console.WriteLine(paths1);
		paths2.Clear();

	}
	Console.WriteLine(paths1.Count());
	Console.WriteLine(paths1);
}

// Define other methods and classes here
int countDORR(StringBuilder given, char downRight)
{
	int count = 0;
	string str = given.ToString();
	
	foreach(char check in str)
	{
		if(check==downRight)
			count++;
	}
	Console.WriteLine(str+":"+count+":"+downRight);
	return count;
}