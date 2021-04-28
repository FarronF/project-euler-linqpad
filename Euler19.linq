<Query Kind="Program" />

void Main()
{
	long dayCount = 1;
	long monthCount = 1;
	int month = 1;
	int daysAdded;
	int year = 1900;
	int sundayCount = 0;
	while(year<2001)
	{
		if(dayCount%7==0&&year>1900)
			sundayCount++;		
		month=(int)monthCount%12;
		if(month==2)
		{
			if(year%4==0)
			{
				if(year%100==0&&year%400!=0)
					daysAdded = 28;
				else
					daysAdded = 29;
			}
			else
				daysAdded = 28;
			
		}
		else if(month==9||month==11||month==4||month==6)
			daysAdded = 30;
		else
		{
			daysAdded = 31;
			if(month==0)
				year++;
		}
		monthCount++;
		dayCount+=daysAdded;
		
	}
	
		Console.WriteLine(sundayCount);

}

// Define other methods and classes here
