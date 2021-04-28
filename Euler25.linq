<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

static void Main()              //   Method declaration
{
BigInteger last = 1;
BigInteger current = 2;
BigInteger oldLast = 0;
ulong count = 3;
const int digits = 1000;
bool check = false;
while(check==false)
{	
	oldLast = last;
	last = current;
	current = current + oldLast;
	count++;
	if(current.ToString().Length>=digits)
	{
		Console.WriteLine(current);
		Console.WriteLine(count);
		check=true;
	}
	
}


	

}   