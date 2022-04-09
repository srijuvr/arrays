using System;
					
public class Program
{
	public static void Main()
	{
	
	
		string sentence="I live in Rutherford";
		sentence=ReverseSentence(sentence);
		Console.WriteLine(sentence);
		
	}
	public static string ReverseSentence(string sentence)
	{
		string reversedSentence= "";
		string word="";	
		for(int i=sentence.Length-1;i>-1;i--)
		{	
			
			
			//Console.WriteLine(sentence.ToCharArray()[i]);
			if(sentence.ToCharArray()[i]== ' ')
			{
			//	Console.WriteLine(word);
				reversedSentence=reversedSentence+word + " ";
			//	Console.WriteLine(reversedSentence);
				word="";
						
			}			
			else
			word=sentence.ToCharArray()[i]+word;
			
			if(i==0)
			{
				reversedSentence=reversedSentence+word;
			}
		}
		return reversedSentence;
	}
	
}