public class Solution {
    public int MostWordsFound(string[] sentences) {
        int maxNoOfWords=0;
        for(int i=0;i<sentences.Length;i++){
             int numOfWords=sentences[i].Split(" ").Length;
            if(numOfWords>maxNoOfWords)
                maxNoOfWords=numOfWords;
       }
       return maxNoOfWords;
    }
}