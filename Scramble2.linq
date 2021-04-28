<Query Kind="Program" />

void Main()
{
	string strToScramble = "ABC", strNew="";	
	List<string> strArray1 = new List<string>{""};
	List<string> strArray2 = new List<string>();
	List<string> outputArray = new List<string>();
	
	
	int strLen = strToScramble.Length;
	
	for(int i = 0;i<strLen;i++)
	{
		for(int j = 0;j<strLen;j++)
		{
			foreach(string str in strArray1)
			{
				//if(strToScramble.Count(x => x == letter)!=str.Count(x => x == letter))
				if(str.Contains(j.ToString())==false)
					strArray2.Add(str+j);
			}
		}
		
		//Console.WriteLine(strArray2);
		strArray1 = new List<string>(strArray2);
		strArray2.Clear();		
	}
	
	foreach(string str in strArray1)
	{
		for(int i = 0;i<strLen;i++)
		{
			strNew = strNew+strToScramble[Convert.ToInt32(str[i].ToString())];
		}
		outputArray.Add(strNew);
		strNew = "";
	}
	Console.WriteLine("Number of Iterations:" + outputArray.Count);
	Console.WriteLine(outputArray);
	
}

// Define other methods and classes here
