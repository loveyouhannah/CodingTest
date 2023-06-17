using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int n) 
    {
        List<int> answer = new List<int>();

        for(int i = 1 ; i * i <= n ; i++ ) // i * i < n의 횟수만 돌면 중복 제거
        {
            if(i * i == n && Divide(i))
            {
                answer.Add(i);
            }
            else if((n % i) == 0 )
            {
                if(i != 1 && Divide(i)) answer.Add(i);    
                if(Divide(n/i))
                {
                    answer.Add(n/i);
                }
            }
        }

        answer.Sort();
        return answer.ToArray();
    }

    private bool Divide(int number)
    {
        if(number == 1) return true;

        int count = default(int);
        for(int i = 1 ; i * i <= number ; i++)
        {
            if(i * i == number) count ++;
            else if(number % i == 0) count += 2;
        }

        if(count == 2) return true;
        else return false;
    }
}
