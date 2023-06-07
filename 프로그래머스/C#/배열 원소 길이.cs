public class Solution 
{
    public int[] solution(string[] strlist) 
    {
        int[] answer = new int[strlist.Length];

        for(int i = 0 ; i < strlist.Length ; i++)
        {
            answer[i] = strlist[i].Length;
        }
        return answer;
    }
}
/*
using System;
using System.Linq;

public class Solution {
    public int[] solution(string[] strlist) {
        return strlist.Select(s => s.Length).ToArray();
    }
}
*/
/*
using System;
using System.Linq;
public class Solution {
    public int[] solution(string[] strlist) {
        return strlist.ToList().ConvertAll(x => x.Length).ToArray();
    }
}
*/