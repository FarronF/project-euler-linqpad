<Query Kind="Program" />

class Euler4                   // Class declaration
{
	
	static void Main()              //   Method declaration
	{
		int number1 = 999;
		int number2 = number1;
		int product;
		int highest = 0;
		bool palCheck = false;
		while(palCheck==false&&number2>99)
		{
		
			for(int i=number1;i>=number2;i--)
			{
				product = i*number2;
				if(isPalindrome(product.ToString()))
				{
					if(product>highest)
						highest = product;
				}
			}
			number2--;
		}
		Console.WriteLine(highest);
	}                               //   End of method	
	static bool isPalindrome(string check)
	{
		var original = check;
		var reversed = new string(original.ToCharArray().Reverse().ToArray());
		var palindrome = original == reversed;
		return palindrome;
	}
}    
