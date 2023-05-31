using System;

public class Solution 
{
    public string solution(string my_string, int n) 
    {
        string answer = "";

        for(int i = 0; i < my_string.Length ; i++)
        {
            for(int j = 0; j < n ; j++)
            {
                answer += my_string.Substring(i,1);
            }
        }

        return answer;
    }
}

/*
public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";

        foreach (var c in my_string)
        {
            answer += new string(c, n);
        }

        return answer;
    }
}*/