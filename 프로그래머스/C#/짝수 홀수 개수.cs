using System;

public class Solution 
{
    public int[] solution(int[] num_list) 
    {
        int odd = default(int);
        int even = default(int);         

        foreach(int num in num_list)
        {
            if((num % 2) == 0) even ++;
            else odd++;
        }

        int[] answer = {even, odd};
        return answer;
    }
}