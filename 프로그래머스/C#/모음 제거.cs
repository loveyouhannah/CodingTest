public string solution(string my_string) 
    {
        string answer = "";
        foreach(char tmp in my_string)
        {
            if(tmp == 'a' || tmp == 'e' || tmp == 'i' || tmp == 'o' || tmp == 'u')
                continue;
            answer += tmp;            
        }
        return answer;
    }
	
/*
public string solution(string my_string) {
        string answer = "";
        string [] b = new string [] {"a","e","i","o","u"};

        foreach(string c in b)
        {
            my_string = my_string.Replace(c,"");
        }
        return my_string;
    }
*/