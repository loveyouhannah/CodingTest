public int solution(string my_string) 
    {
        int answer = 0;

        foreach(char tmp in my_string)
        {
            if(char.IsDigit(tmp)) //char.IsDigit함수는 'char'가! 숫자인지 아닌지 판단하는 함수
            {
                answer += (int)tmp - 48;
            }
        }

        return answer;
    }