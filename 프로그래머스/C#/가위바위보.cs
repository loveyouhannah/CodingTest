public class Solution {
    public string solution(string rsp) {
        string answer = "";
        foreach(char tmp in rsp)
        {
            if(tmp == '2') answer += '0';
            else if(tmp == '0') answer += '5';
            else answer += '2';
            //삼항연산자
            //answer += '2'==a ? 0 : a=='0' ? 5 : 2;
        }
        
        return answer;
    }
}

/*
public class Solution {
    public string solution(string rsp) {
        string temp = rsp;
        string answer = "";

        temp = temp.Replace("0", "1");
        temp = temp.Replace("2", "0");
        temp = temp.Replace("5", "2");
        answer = temp.Replace("1", "5");

        return answer;
    }
}
*/