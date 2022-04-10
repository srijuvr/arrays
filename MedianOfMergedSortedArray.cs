public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
        
        int m=nums1.Length;
        int n=nums2.Length;
        int[] num3= new int[m+n];
       
        int j=0,k=0;
       //  Console.WriteLine("m="+m);
       //  Console.WriteLine("n="+n);
        for(int i=0;i<m+n;i++)
        {
          // Console.WriteLine("j="+j);
          // Console.WriteLine("k="+k);
            if((m==0 || j>m-1) && k<=n-1){
                num3[i]=nums2[k];
                 k++;
            }
            else if(j<=m-1 && (n==0 || k>n-1)){
                 num3[i]=nums1[j];
                 j++;
            }
            else{
            if(nums1[j]<=nums2[k])
            {
                num3[i]=nums1[j];
                j++;
            }
            else if(nums1[j]>=nums2[k])
             {
                num3[i]=nums2[k];
                 k++;
            }
            }
            //Console.WriteLine(num3[i]);
        }
        //Console.WriteLine("middle"+middle);
        if(num3.Length %2!=0){
           // Console.WriteLine(num3[middle]);
            return num3[num3.Length/2];
        }
        else {
                      //  Console.WriteLine(num3[middle]);
                      //  Console.WriteLine(num3[middle+1]);
            int mid=num3.Length/2;
            return (double) (num3[mid-1]+num3[mid])/2;
        }
        //return middle;
    }
}
