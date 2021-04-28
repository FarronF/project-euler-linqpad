<Query Kind="Program" />

void Main()
{
	string strToScramble = "0123456789";
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
	strArray1.Sort();
	Console.WriteLine(strArray1[999999]);
	 Console.WriteLine(strArray1[1000000]);
	Console.WriteLine(strArray1[1000001]);

	//Console.WriteLine(strArray1);
}
