/*
Math.Sqrt로 제곱근을 구하고 double로 넣었다. 정수인지 모르니까.
걔를 내림처리한거랑 같으면 +1한 값의 제곱을 출력하고 아니면 -1을 출력.
*/

using System;
...
    public long solution(long n) 
    {
        long answer = 0;
        double tmp = Math.Sqrt(n);

        if(Math.Floor(tmp) == tmp)
        {
            answer = (long)((tmp + 1) * (tmp + 1));
        }
        else
            answer = -1;

        return answer;
    }
}

/*
제곱근 구한것을 long 처리하면 소수점은 버림처리가 된다.

따라서 제곱근을 long처리하여 제곱한 것이 n이라면 ~ 의 접근으로 처리

using System;
...
    public long solution(long n) {
        long x = (long)Math.Sqrt(n);
            return (x*x == n) ? (x+1)*(x+1) : -1;
    }
}
*/
