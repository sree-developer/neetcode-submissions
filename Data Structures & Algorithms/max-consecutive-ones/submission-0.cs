public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {

        
        int result=0, count=0;
        foreach(int n in nums)
        {
            if(n==0)
            {
                result = Math.Max(result,count);
                count=0;
            }
            else
            count++;
        }
        return Math.Max(result,count);
    }
}