<Query Kind="Program" />

void Main()
{
	string square = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
	//string square = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
	const int WIDTH = 50;
	const int CHECK_LEN = 13;
	long highest = 0;
	long vert, hor, diag,posVal;
	int pos;
	int highestPos = 0;
	for(int i=0;i<square.Length/WIDTH;i++)
	{	
		Console.WriteLine(square.Substring(i*WIDTH,WIDTH));
	}
	for(int i=0;i<square.Length/WIDTH;i++)//square.Length/WIDTH-CHECK_LEN
	{
		for(int j=0;j<WIDTH;j++)//WIDTH-CHECK_LEN
		{
			pos = (i*WIDTH)+j;
			posVal = Int64.Parse(square.Substring(pos,1));
			
			
			hor = 1;
			vert = 1;
			diag = 1;
			
			for(int k = 0;k<CHECK_LEN;k++)
			{
				if(j<=WIDTH-CHECK_LEN)
					hor = hor * Int64.Parse(square.Substring(pos+k,1));
				else 
					hor = 0;
				if(i<=(square.Length/WIDTH)-CHECK_LEN)
					vert = vert * Int64.Parse(square.Substring(pos+(k*WIDTH),1));
				else
					vert = 0;
				if(i<=square.Length/WIDTH-CHECK_LEN&&j<=WIDTH-CHECK_LEN)
					diag = diag * Int64.Parse(square.Substring(pos+(k*WIDTH)+k,1));
				else
					diag = 0;
			}
				if(hor>highest)
				{
					highest=hor;
					highestPos = pos;
				}
				if(vert>highest)
					highest=vert;
				if(diag>highest)
					highest=diag;
			Console.WriteLine(pos+":"+hor+","+vert+","+diag);
					
		}
	}
	Console.WriteLine(highest);
	highest = 0;
	for(int j=0;j<=1000-CHECK_LEN;j++)//WIDTH-CHECK_LEN
	{
		hor = 1;
		for(int k = 0;k<CHECK_LEN;k++)
			{
				hor = hor * Int64.Parse(square.Substring(j+k,1));
			}
				if(hor>highest)
					highest=hor;
	}
	Console.WriteLine(highest);
}

// Define other methods and classes here
