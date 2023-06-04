public class Solution 
{
    public string solution(string letter) 
    {
        string answer = default(string);

        Hashtable morse = new Hashtable();
        morse.Add(".-", "a");
        ...
        morse.Add("--..", "z");

        string[] tmpLetter = letter.Split(' ');
        foreach (string tmp in tmpLetter) 
        {
            if (morse.Contains(tmp))
            {
                answer += morse[tmp];
            }
        }

        return answer;
    }
}
