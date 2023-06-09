public int solution(int n) 
{
    int answer = 0
    for(int i = 1 ; i <= 11 ; i++)
    {
        if(n < factorial(i))
        {
            answer = i-1;
            break;
        }
    }
    return answer;
}

public int factorial(int num)
{
    if(num == 1) return 1;
    return num * factorial(num - 1);
}

/*
public int solution(int n)
    {
        int answer = 0;
        int fac = 1;

        for (int i = 1; i <= 11; i++)
        {
            fac *= i;

            if(fac > n)
            {
                return i-1;
            }

        }
        return answer;
    }
*/

/*

public int solution(int n) 
{
    int answer = 1;
    while (true)
    {
        if (n <= answer)
            break;

        answer++;
        n /= answer;
    }
    return answer;
}

*/
