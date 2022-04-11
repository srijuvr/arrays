public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {        
    int[] ans= new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            int counter=0;
            for(int j=0;j<nums.Length;j++){
               if(nums[i]>nums[j]){
                   counter++;
               }
            }
            ans[i]=counter;
        }
        return ans;
    }
}