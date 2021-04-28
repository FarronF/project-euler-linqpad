<Query Kind="Program" />

void Main()
{
	string strToScramble = "ABC";	
	List<string> strArray1 = new List<string>{""};
	List<string> strArray2 = new List<string>();
	char letter;
	int strLen = strToScramble.Length;
	
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
	Console.WriteLine(strArray1);
}

// Define other methods and classes here
