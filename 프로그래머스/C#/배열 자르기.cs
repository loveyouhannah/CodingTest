using System;

public class Solution 
{
    public int[] solution(int[] numbers, int num1, int num2) 
    {
        int length = num2 - num1 + 1;
        int[] answer = new int[length];
        int num = 0;
        for(int i = num1 ; i < num2 + 1 ; i++)
        {
            answer[num] = numbers[i];
            num++;
        }
        return answer;
    }
}
​
/*
public int[] solution(int[] numbers, int num1, int num2) 
{
	int[] answer = new int[num2-num1+1];
	for(int i=0; i<num2-num1+1; i++)
	{
       answer[i] = numbers[num1+i];
	}
	return answer;
}
*/