<Query Kind="Program" />

void Main()
{
	const int SIZE = 3;
	const int MOVE_CAP = SIZE*2;
	//List<bool> test1 = new List<bool>() {true};
	//List<bool> test2 = new List<bool>() {false};
	
	string test1 = "1";
	string test2 = "0";
	
	
	//string addable = new string();
				
	//Not sure why test is needed but it is.
	//List<List<bool>> paths1 = new List<List<bool>>() {test1,test2};
	//List<List<bool>> paths2 = new List<List<bool>>();
	List<string> paths1 = new List<string>() {test1, test2};
	List<string> paths2 = new List<string>();
	
	for(int i = 1;i<MOVE_CAP;i++)
	{
		
		foreach(string current in paths1)
		{
			
			if(countDORR(current,'1')<SIZE)
			{
				paths2.Add(current+"1");
			}
			if(countDORR(current,'0')<SIZE)
			{
				paths2.Add(current+"0");
			}
			
		}
		//Console.WriteLine("BR");
		paths1 = new List<string>(paths2);
		//Console.WriteLine(paths1);
		paths2.Clear();

	}
	Console.WriteLine(paths1.Count());
	Console.WriteLine(paths1);
}

// Define other methods and classes here
int countDORR(string given, char downRight)
{
	int count = 0;
	//string str = given.ToString();
	
	foreach(char check in given)
	{
		if(check==downRight)
			count++;
	}
	//Console.WriteLine(str+":"+count+":"+downRight);
	return count;
}