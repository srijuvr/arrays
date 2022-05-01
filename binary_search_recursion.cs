using System;
					
public class Program
{
	public static void Main()
	{
		int[] numbers={1,3,4,5,6,7,8,9,23,90};
		Console.WriteLine(binarySearch(numbers,0,numbers.Length-1,7));
		
	}
	public static int binarySearch(int[] list,int beg, int end, int item)
	{
		
		if(end<beg)//base case
		  return -1;
		int mid=(beg+end)/2;
		if(list[mid]==item)
			return mid;    

		else if(item<list[mid])
			return binarySearch(list,beg, end-1,item);
		else if(item>list[mid])
			return binarySearch(list,beg+1, end,item);
		else
			return -1;
		
		
	}
}   