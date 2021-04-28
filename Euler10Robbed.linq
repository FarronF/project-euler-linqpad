<Query Kind="Program" />

void Main()
{

            uint arraySize = 2000001;
            bool[] sieveContainer = new bool[arraySize];
            //BigInteger sum = new BigInteger(0);
            ulong sum = 0;

            for (int i = 0; i < arraySize; i++)
                sieveContainer[i] = true;

            for (int baseMultiple = 2; baseMultiple < arraySize; baseMultiple++)
            {
                if (sieveContainer[baseMultiple])
                {
                    for (int multiples = baseMultiple * 2; multiples < arraySize; multiples += baseMultiple)
                        sieveContainer[multiples] = false;
                }
            }

            for (ulong j = 2; j < arraySize; j++)
            {
                if (sieveContainer[j])
                    sum += j;
            }

            Console.WriteLine(sum);
     
	        
}

// Define other methods and classes here
