public int[] solution(int[] numbers, string direction) 
{
    int[] answer = new int[numbers.Length];
        
    if(direction == "right")
    {
        for(int i = 0; i < numbers.Length - 1 ; i++)
        {
            answer[i+1] = numbers[i];
        }
        answer[0] = numbers[numbers.Length-1];
    }
    else
    {
        for(int i = 1; i < numbers.Length ; i++)
        {
            answer[i-1] = numbers[i];
        }
        answer[numbers.Length-1] = numbers[0];
    }        
    return answer;
}
​
/*
using System.Linq;
...
    public int[] solution(int[] numbers, string direction)
    {
        var list = numbers.ToList();
        if (direction == "left")
        {
            var number = list[0];
            list.RemoveAt(0);
            list.Add(number);
        }
        else if (direction == "right")
        {
            var number = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            list.Insert(0, number);
        }
        return list.ToArray();
    }
*/