public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] ans= new int[2*n];
        int j=0;
        int i=0;
        while(j<n){
            ans[i]=nums[j];
            ans[i+1]=nums[n+j];
            j++;
            i=i+2;
        }
        return ans;
    }
}