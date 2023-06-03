public class Solution 
{
    public int solution(int n) 
    {
        int answer = 0;
        int i = 0;
        for(i = 1; i * i < n ; i++)
        {
            if(n % i == 0)
                answer += 2;
        }

        if(i*i == n)
            answer ++;

        return answer;
    }
}