using System;

public class Solution 
{
    public int solution(int n) 
    {
        int answer = 0;
        //n에서 1을 뺀 수의 약수를 구하자.
        n = n - 1;

        //단, 약수는 1과 2를 제외한다.
        for(int i = 1 ; i * i <= n ; i++)
        {
            if(n % i == 0)
            {
                if(2 <= i)
                {
                    answer = i;
                    break;
                }
                else if(i == 1)
                {
                    answer = n;
                }
            }
        }
        return answer;
    }
}

/*
using System;

public class Solution {
    public int solution(int n) {
        n = n -1;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return i;
                }
            }
            return n;
    }
}

*/