using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string my_string) 
    {
        List<int> tmpList = new List<int>();
        foreach(char tmp in my_string)
        {
            if(char.IsDigit(tmp)) //char.IsDigit함수는 char에서 10진수가 있는 지 확인하는 bool 함수
            {
                tmpList.Add((int)tmp - 48); //ascii 0 = 48
            }
        }
        tmpList.Sort();
        return tmpList.ToArray();
    }
}
