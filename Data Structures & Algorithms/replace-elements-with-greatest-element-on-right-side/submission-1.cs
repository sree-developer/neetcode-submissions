public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int n = arr.Length;
        int[] res = new int[n];
        int max= -1;
        for(int i=n-1; i>=0;i--)
        {
            res[i] = max;
            max= Math.Max(arr[i],max);

        }
        return res;
    }
}