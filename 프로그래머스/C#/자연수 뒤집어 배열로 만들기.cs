using System;

    public int[] solution(long n) 
    {
        int length = 0;
        long number = n;
        while(number > 0)
        {
            number /= 10;
            length ++;
        }

        int[] answer = new int[length];

        for(int i = 0 ; i < length ; i++)
        {
            answer[i] = int.Parse(n.ToString().Substring(length -1 -i, 1));
        }

        return answer;
    }