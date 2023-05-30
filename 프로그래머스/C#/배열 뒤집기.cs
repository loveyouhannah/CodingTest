using System;

public class Solution 
{
    public int[] solution(int[] num_list) 
    {
        int length = num_list.Length;
        int[] answer = new int[length];

        for(int i = 0 ; i < length ; i++)
        {
            answer[i] = num_list[(length - 1) - i];           
        }

        return answer;
    }
}

/*
using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = num_list.Reverse().ToArray();
        return answer;
    }
}*/