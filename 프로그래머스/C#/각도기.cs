using System;

public class Solution 
{
    public int solution(int angle) 
    {
        if(angle < 90 && angle > 0) return 1;
        else if(angle == 90) return 2;
        else if(angle < 180 && angle > 90) return 3;
        else return 4;
    }
}

/*
using System;

public class Solution {
    public int solution(int angle) {
        int answer = angle < 90 ? 1 : angle == 90 ? 2 : angle < 180 ? 3 : 4;
        return answer;
    }
}
*/