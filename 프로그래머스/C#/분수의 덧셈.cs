using System;

public class Solution 
{
    public int[] solution(int denum1, int num1, int denum2, int num2) 
    {
        //분자
        int ja_num = (denum1 * num2) + (denum2 * num1);
        //분모
        int mo_num = num1 * num2;
        //최대공약수
        int tmp_num = default(int);

        for(int i = 1; i <= ja_num ; i++)
        {
            if(ja_num % i == 0 && mo_num % i ==0)
            {
                tmp_num = i;
            }
        }

        int[] answer = new int[] {ja_num/tmp_num, mo_num/tmp_num};
        return answer;
    }
}