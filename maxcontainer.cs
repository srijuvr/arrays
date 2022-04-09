public class Solution {
    public int MaxArea(int[] height) {
        int right= 0;
        int maxWater=0;
        for(int i=height.Length-1;i>-1;i--){  
            right= height[i];
           // Console.WriteLine("right"+right);
            for(int j=0;j<i;j++){
                int left=height[j];
                // Console.WriteLine("left"+left);
                
                int width = i-j;
                // Console.WriteLine("width"+width);
                if(left<right){
                   if((left*width)>maxWater){
                       
                      maxWater=(left*width); 
                    // Console.WriteLine("width"+width);
                    // Console.WriteLine("left"+left);
                   }
                }
                else{
                    if((right*width)>maxWater)  {  
                     maxWater=(right*width);
                     //Console.WriteLine("width"+width);
                    // Console.WriteLine("right"+right);
                   }
                }
             }
            
        }
        return maxWater;
    }
}