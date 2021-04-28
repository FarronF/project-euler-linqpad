<Query Kind="Program" />

void Main()
{
	long given = 987;
	string strRep = "";
	long digit;
	long check = 10;
	bool loopBool = true;
	while(loopBool==true)
	{
		digit = (given%check)/(check/10);
		given = given - digit;
		strRep = digit + strRep;
		if(check>given)
			loopBool = false;

		check = check*10;
	}
	Console.WriteLine(strRep);
}

// Define other methods and classes here
