using System;

public class Solution 
{
    public string solution(string my_string, string letter) 
    {
        string answer = "";
        for(int i =0 ; i < my_string.Length ; i++)
        {
            string tmp = my_string.Substring(i,1);
            if(tmp != letter)
            {
                answer += tmp;
            }
        }
        return answer;
    }
}

/*
using System;

public class Solution {
    public string solution(string my_string, string letter) {
        return my_string.Replace(letter,"");
    }
}
*/