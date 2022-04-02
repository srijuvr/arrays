public class Solution {
    public int[] GetConcatenation(int[] c) {
        int ln = c.Length*2;
        int n=c.Length;
        int[] ans= new int[ln];
        int j=0;
        for(int i=0;i<c.Length;i++){
          
            ans[i]=ans[i+n]=c[i];
            
        }
        return ans;
    }
}