<Query Kind="Program" />

void Main()
{
	decimal check1, check2;
	decimal num, den, num2, den2;
	decimal numProd = 1, denProd = 1;
	for(int i = 1;i<=9;i++)
	{
		for(int j = 1;j<=9;j++)
		{
			den = (i*10)+j;
			for(int k = 1;k<=9;k++)
			{
					num = (k*10)+i;
					if(num<den)
					{
						num2 = k;
						den2 = j;
						if(num/den==num2/den2)
						{
							numProd*=num2;
							denProd*=den2;
						}
					}
					num = (i*10)+k;
					if(num<den)
					{
						num2 = k;
						den2 = j;
						if(num/den==num2/den2)
						{
							numProd*=num;
							denProd*=den;
						}
					}
					num = (k*10)+j;
					if(num<den)
					{
						num2 = k;
						den2 = i;
						if(num/den==num2/den2)
						{
							numProd*=num;
							denProd*=den;
						}
					}
					num = (j*10)+k;
					if(num<den)
					{
						num2 = k;
						den2 = i;
						if(num/den==num2/den2)
						{
							numProd*=num;
							denProd*=den;
						}
					}
			}
		//	Console.WriteLine(i);
		}
		
	}
	Console.WriteLine(numProd+"/"+denProd);
	Console.WriteLine(denProd/numProd);

}

// Define other methods and classes here
bool trivial(int nom, int den)
{
	
	return false;
}