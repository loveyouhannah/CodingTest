public int solution(int[] numbers) 
{
    int answer = 0;
    int [] tmp = new int [2];

    for(int i = 0 ; i < numbers.Length ; i++)
    {
        if(tmp[0] < numbers[i])
        {
            tmp[1] = tmp[0];
            tmp[0] = numbers[i];
        }
        else if(tmp[1] < numbers[i])
        {
            tmp[1] = numbers[i];
        } 
    }
        return tmp[0] * tmp[1];
}

/*
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        numbers = numbers.OrderByDescending(x => x).ToArray();
        int answer = numbers[0] * numbers[1];
        return answer;
    }
}
*/

/*
public int solution(int[] numbers) 
{
        Array.Sort(numbers);
        int answer = numbers[numbers.Length-1] * numbers[numbers.Length-2];
        return answer;
}
​
*/

/*
public int solution(int[] numbers) 
{
        Array.Sort(numbers, (x, y) => { return x >= y ? -1 : 1; } );
        return numbers[0]*numbers[1];
}
*/

/*
using System.Linq;

public class Solution
{
    public int solution(int[] numbers)
    {
        Array.Sort(numbers);
        Array.Reverse(numbers);

        return numbers[0] * numbers[1];
    }
}
*/

/*
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        for(int i = 0; i < numbers.Length; i++)
        {
            for(int j = i+1; j < numbers.Length; j++)
            {
                if(numbers[i] > numbers[j])
                {
                    int k = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = k;
                }
            }
        }
        return numbers[numbers.Length - 1] * numbers[numbers.Length - 2];
    }
}
*/