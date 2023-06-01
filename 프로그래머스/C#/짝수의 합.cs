using System;

public class Solution 
{
    public int solution(int n) 
    {
        int answer = 0;

        for(int i = 1 ; i < n + 1 ; i++)
        {
            if(i % 2==0) answer += i;
        }

        return answer;
    }
}

/*
for(int i = 2;i<=n;i+=2)
{
     answer += i;
}
*/