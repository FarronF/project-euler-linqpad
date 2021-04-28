<Query Kind="Program" />

void Main()
{
	string paragraph = "The fast red fox jumps over the lazy brown dog, then sleeps. Lorum Ipsum.";
	char[] puncArray = new char[]{' ',',','.','!'};
	int pos1 = 0, pos2;
	string wordRev = "", paraRev = "";
	
	while(pos1<paragraph.Length)
	{
		
		if(Array.IndexOf(puncArray,paragraph[pos1])==-1)
		{
			pos2 = pos1;
			while(pos2<paragraph.Length&&Array.IndexOf(puncArray,paragraph[pos2])==-1)
			{
					wordRev = paragraph[pos2]+wordRev;
					pos2++;
			}
			
			
			paraRev = paraRev + wordRev;
			wordRev = "";
			pos1 = pos2;
		}
		else
		{
			paraRev = paraRev + paragraph[pos1];
			pos1++;
		}
		
	}
	
	Console.WriteLine(paraRev);
}

// Define other methods and classes here
