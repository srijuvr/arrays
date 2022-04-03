using System;
					
public class Program
{
	public static void Main()
	{
	
		int [] nums= new int[]{1,2,3,4,5,-1,-1};
		//1,2,2,3,4,4,5
		nums=DoubleEven(nums);
		for(int i=0;i<nums.Length;i++){
				Console.Write(nums[i]);
		}
	}
	
	 public static int[] DoubleEven(int[] nums) {
		  int lastInx=nums.Length-1;
      for(int i=nums.Length-1;i>-1;i--){

          if(nums[i]>-1){
			  	//Console.WriteLine("Element"+ nums[i]);
              if(nums[i]%2==0){
				 // Console.WriteLine("Even"+ nums[i]);
				  //Console.WriteLine("lastInx"+lastInx);
                  nums[lastInx]=nums[i];
				  lastInx--;
				  	 // Console.WriteLine("lastInx"+lastInx);
                  nums[lastInx]=nums[i];
                  lastInx--;
              }
              else{
				// Console.WriteLine("Odd"+ nums[i]);
				  //	  Console.WriteLine("lastInx"+lastInx);
                  nums[lastInx]=nums[i];
				  lastInx--;
              }
          }

      }
		return nums;
    }
}