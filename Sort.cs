    using System;
    public class Sort
    {
        public static void Main()
        {
            int[] nums={54,78,34,90,01,100,34,12,56};
            //Simple(nums);
            //Selection(nums);
            //Bubble(nums);
            //Insertion(nums);
            Quick(nums,0,nums.Length-1);
            foreach(int i in nums){
                Console.Write(i+",");
            }
        }
        public static void Quick(int[] nums,int beg, int end)
        {
            if(beg<end)
			{
            int pivotPos=Partition(nums,beg,end);
            Quick(nums,beg,pivotPos-1);
            Quick(nums,pivotPos+1,end);
			}
            
        }
        public static int Partition(int[] nums, int beg, int end)
        {
            
           

               int pivot= nums[beg];
               int i=beg+1;
               int j=end;
               while(i<j){
                  while(i<=end && nums[i]<pivot){
                      i++;
                  }
                  while(j>beg && nums[j]>pivot){
                      j--;
                  }
                  if(i<j){
                    swap(nums,i,j);
                  }
               }
              swap(nums,beg,j);
			 return j;
        }
        public static void Insertion(int[] nums)
        {
           int i=1;
            while(i<nums.Length){
				//Console.WriteLine(i);
                Insert(nums,i);
				i++;
            }
        }
        public static void Insert(int[] nums,int pos){
            int key=nums[pos];
			//Console.WriteLine(pos);
            int i= pos;
            while(i>0){
                    if(nums[i-1]>key){
                         nums[i]=nums[i-1];
                         pos=i-1;
                    } 
				i--;

            }
            nums[pos]=key;
			//Console.WriteLine(nums[pos]);

        }
        public static void Bubble(int[] nums){

           
			int n= nums.Length;
            while(n>0){
                bbl(nums,n);
                n--;
            }

        }
        public static void bbl(int[] nums, int size)
        {
            int i= nums.Length-1;
			int n = nums.Length;
            while(i>(n-size)){
                if(nums[i]<nums[i-1]){
                    swap(nums,i,i-1);
                }
                i--;
            }
        }
        public static void swap(int[] nums, int source, int dest)
        {
            int temp= nums[source];
            nums[source]=nums[dest];
            nums[dest]=temp;
        }
        public static int locationOfSmallestElement(int[] nums, int start, int end)
        {
            int small=start;
            while(start+1<=end){
                if(nums[small]>nums[start+1])
                    small=start+1;
                start++;    
            }
            return small;
        }
        public static void Selection(int[] nums)
        {
            int i=0;
            int n= nums.Length;
            while(i<=n-1){
                int j=locationOfSmallestElement(nums,i,n-1);
                if(j>i){
                    swap(nums,i,j);
                }
                i++;
            }

        }
        public static void Simple(int[] nums)
        {
            for(int i=0;i<nums.Length;i++)
            {
                for(int j=i+1;j<nums.Length;j++)
                {
                    if(nums[j]<nums[i])
                    {
                        int temp= nums[j];
                        nums[j]=nums[i];
                        nums[i]=temp;
                    }
                }
            }
        }
    }