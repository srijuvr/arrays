public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
     
        //find the kid with max candie
        //travarse kids andd extra and check with max kid and mark flag
        int kidWithMaxNumOfCandies=candies[0];
        bool isMaxCandies= false;
        IList<bool> kidsMaxCandies= new List<bool>();
        for(int i=0;i<candies.Length;i++){
            
            if(!isMaxCandies){
                 for(int j=1;j<candies.Length;j++){
                      if(kidWithMaxNumOfCandies<candies[j])
                         kidWithMaxNumOfCandies=candies[j];
                 }
                isMaxCandies=true;
            }
            if(kidWithMaxNumOfCandies>(candies[i]+extraCandies))
                kidsMaxCandies.Add(false);
            else
                kidsMaxCandies.Add(true);
           
        }
        return kidsMaxCandies;
       
      
    }
}