<Query Kind="Program" />

void Main()
{
	string strToScramble = "123456789";
 	List<string> strArray1 = new List<string>{""};
	List<string> strArray2 = new List<string>();
	List<int> intList = new List<int>();
	char letter;
	int strLen = strToScramble.Length;
	int sum=0;
	
	for(int i = 0;i<strLen;i++)
	{
		for(int j = 0;j<strLen;j++)
		{
			letter = strToScramble[j];
			foreach(string str in strArray1)
			{
				//if(strToScramble.Count(x => x == letter)!=str.Count(x => x == letter))
				if(str.Contains(letter)==false)
					strArray2.Add(str+letter);
				
			}
		}
		
		//Console.WriteLine(strArray2);
		strArray1 = new List<string>(strArray2);
		strArray2.Clear();
		
	}
	int x, y, z;
	foreach(string str1 in strArray1)
	{
	//string str1 = strArray1[1];
	//Console.WriteLine(str1);
		for(int i = 1;i<strLen-1;i++)
		{	
			Int32.TryParse(str1.Substring(0,i), out x);
			for(int j = i+1;j<strLen;j++)
			{
				Int32.TryParse(str1.Substring(i,j-i), out y);
				Int32.TryParse(str1.Substring(j), out z);
				//Console.WriteLine(x+":"+y+":"+z);	
				if(x*y==z)
				{
					Console.WriteLine(x+":"+y+":"+z);
					if(intList.Contains(z)==false)
					{
						intList.Add(z);
						sum+=z;
					}
				}
			}
		}
	}
	Console.WriteLine(intList);
	Console.WriteLine(sum);
	
	
	//Console.WriteLine(strArray1);
}