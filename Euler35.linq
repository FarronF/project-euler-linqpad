<Query Kind="Program" />

void Main()
{
	int  number = 1000001;
	//int  number = 101;
	bool[] list = new bool[number];
	int workNum, digit, greatest, count=0, len, pos;
	int[] rotations;
	bool check, cont;
	
	for(int i=2; i<number;i++)
	{
		if(list[i]==false)
		{
			/*
			workNum = i;
			while(workNum>10)
			{
				digit = workNum%10;
				digit/=10;
				if(digit>greatest)
					greatest=digit;
			}
			if(workNum>greatest)
			{
				//Do the thing;
			
			}*/
			//sum+=i;
			for(int j=i*2; j<number;j+=i)
			{
					list[j] = true;
			}
		}
	}
	for(int k=number-1;k>=2;k--)
	{
		if(list[k]==false)
		{
			check = true;
			rotations = rotate(k);
			len = rotations.Length;
			//Console.WriteLine(rotations);
			
			for(int i = 1;i<len;i++)
			{
				pos = rotations[i];
				if(list[pos]==true)
					check = false;
				//Console.WriteLine(list[rotations[i]]+":"+check);
				list[pos]=true;
			}
			if(check==true)
			{
				
				count+=len;
			}
		}
	}
	


	Console.WriteLine(count);
}

// Define other methods and classes here
int[] rotate(int x)
{
	List<int> digits = new List<int>();
	int num = x, count, get, mult, addable;
	int[] returnable;
	
	while(num>0)
	{
		digits.Add(num%10);
		num/=10;
	}
	count = digits.Count;
	if(digits.Contains(0))
		return new int[0];
	returnable = new int[count];
	returnable[0] = x;
	for(int i=1;i<count;i++)
	{
		get = i;
		mult = 1;
		addable = 0;
		do
		{
			addable+=(digits[get]*mult);
			mult*=10;
			get++;
			if(get==count)
				get=0;
		}while(get!=i);
		returnable[i]=addable;
	}
	return returnable.Distinct().ToArray();
}