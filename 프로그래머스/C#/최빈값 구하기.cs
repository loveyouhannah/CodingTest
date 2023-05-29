using System;
using System.Linq;

public class Solution 
{
    public int solution(int[] array) 
    {
        int[] indexes = new int[1000];
        int max = -1;

        for(int i =0 ; i< array.Length ; i++)
        {
            indexes[array[i]]++;
        }    

        for(int i = 0 ; i < indexes.Length ; i++)
        {
            if (indexes[i] == indexes.Max())
            {
                if(max != -1) return -1;
                else max = i;
            }
        }
        return max;
    }
}