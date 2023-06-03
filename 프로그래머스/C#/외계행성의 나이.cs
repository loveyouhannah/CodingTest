public class Solution 
{
    public string solution(int age) 
    {
        string answer = default(string);

        //a의 아스키값
        char ascStrA = 'a';
        int ascIntA = (int)ascStrA;

        //각 자리 뽑아내기
        while(age>0)
        {
            int tempI = age % 10;
            tempI += ascIntA;
            char tempC = (char)tempI;
            string tempS = tempC.ToString();
            answer += tempS;

            age = age / 10;
        }

        char[] array = answer.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}
/*
public class Solution {
    public string solution(int age) {
        string answer = "";
        while(age > 0)
        {
            answer += Convert.ToChar((age % 10) + 'a');
            age /= 10;
        }
        char[] reverse = answer.ToCharArray();
        Array.Reverse(reverse);
        answer = new string(reverse);

        return answer;
    }
}
*/