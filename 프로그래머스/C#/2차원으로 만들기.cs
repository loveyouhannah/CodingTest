public class Solution 
{
    public int[,] solution(int[] num_list, int n) 
    {
        int[,] answer = new int[num_list.Length/n,n];

        for(int i = 0 ; i < answer.Length ; i++)
        {
            answer[i/n,i%n] = num_list[i];
        }
        return answer;
    }
}