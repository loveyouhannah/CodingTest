/*
using System;
public class Solution 
{
    public int solution(string s) 
    {
        int answer = 0;

        string tmp = s.Substring(0,1);
        if(tmp == "-")
        {
            answer = Convert.ToInt32(s.Substring(1, s.Length-1));
            answer *= -1;
        }
        else
        {
            answer = Convert.ToInt32(s);
        }

        return answer;
    }
}
*/


//'-'도 그대로 converting을 인지시켜주는 문제
public class Solution {
    public int solution(string s)
    {
        int answer = int.Parse(s);
        return answer;
    }
}

using System;
public class Solution {
    public int solution(string s) {
        int answer = 0;
        answer = Convert.ToInt32(s);
        return answer;
    }
}

using System;
public class Solution {
    public int solution(string s) {
        int answer = Int32.Parse(s);
        return answer;
    }
}