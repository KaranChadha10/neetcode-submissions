public class Solution {
    public int MaxArea(int[] heights) {
        int res = 0; 
        int l = 0, r = heights.Length - 1;

        while(l < r){
            int area = (r - l) * Math.Min(heights[l], heights[r]);
            res = Math.Max(area, res);
            if(heights[l] < heights[r]){
                l += 1;
            } else {
                r -= 1;
            }
        }
        return res;
    }
}
