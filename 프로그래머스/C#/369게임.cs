using System.Collections.Generic;
...
    public int solution(int order) 
    {
        int answer = 0;
        List<int> list = new List<int>();
        int length = order.ToString().Length;

        for(int i = 0 ; i < length ; i++)
        {
            list.Add(order % 10);
            order = (order - (order % 10)) / 10 ;
        }

        foreach(int tmp in list)
        {
            if(tmp == 3 || tmp == 6 || tmp ==9)
            {
                answer++;
            }
        }

        return answer;
    }
