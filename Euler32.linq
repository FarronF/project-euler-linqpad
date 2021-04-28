<Query Kind="Program" />

void Main()
{
	string strToScramble = "0123456789";
	StringBuilder test = new StringBuilder("");
 	List<StringBuilder> strArray1 = new List<StringBuilder>{test};
	List<StringBuilder> strArray2 = new List<StringBuilder>();
	char letter;
	int strLen = strToScramble.Length;
	
	for(int i = 0;i<strLen;i++)
	{
		for(int j = 0;j<strLen;j++)
		{
			letter = strToScramble[j];
			foreach(StringBuilder str in strArray1)
			{
				test = new StringBuilder(str.ToString());
				//Console.WriteLine(str.ToString());
				//if(strToScramble.Count(x => x == letter)!=str.Count(x => x == letter))
				if(str.ToString().Contains(letter)==false)
					strArray2.Add(test.Append(letter));
				
			}
		}
		
		//Console.WriteLine(strArray2);
		strArray1 = new List<StringBuilder>(strArray2);
		strArray2.Clear();
		//Console.WriteLine(strArray1);
		
	}
		strArray1.Sort();
	Console.WriteLine(strArray1[999999]);
	 Console.WriteLine(strArray1[1000000]);
	Console.WriteLine(strArray1[1000001]);

	//Console.WriteLine(strArray1);


	//Console.WriteLine(strArray1);
}