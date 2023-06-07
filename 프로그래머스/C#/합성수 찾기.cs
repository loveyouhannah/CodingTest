using System.Collections.Generic;
..
    public int solution(int n) 
    {
        List<int> answer = new List<int>();

        for(int tmp = 2 ; tmp <= n ; tmp++)
        {
            int count = default(int);
            int i = 1;
            for(i = 1; i * i < tmp ; i++)
            {
                if(tmp % i == 0)
                    count += 2;
            }
            if(i*i == tmp)
                count ++;

            if(count >= 3)
                answer.Add(tmp);
        }
        return answer.Count;
    }
	
/*
using System.Linq;
...
    public int solution(int n) {
        return Enumerable.Range(1, n).Count(x => Enumerable.Range(1, x).Count(y => x % y == 0) >= 3);
    }
*/

/*
using System.Linq;
..
    public int solution(int n) {
        int answer = 0;
        for (int i = 4; i <= n; i++)
        {
            answer += Enumerable.Range(1, n).Count(x => i % x == 0) >= 3 ? 1 : 0;
        }
        return answer;
    }
*/