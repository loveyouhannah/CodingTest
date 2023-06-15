public class Solution 
{
    public long[] solution(int x, int n) 
    {
        long[] answer = new long[n];
        long totalNum = x;

        for(int i = 0; i < n; i++)
        {
            answer[i] = totalNum;
            totalNum += x;
        }

        return answer;
    }
}