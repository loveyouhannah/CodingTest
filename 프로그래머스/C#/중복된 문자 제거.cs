public string solution(string my_string) 
{
        string answer = "";

        foreach(char tmp in my_string)
        {
            if(answer.Contains(tmp))
                continue;
            else
                answer += tmp;
        }

        return answer;
}