using System;

public class Solution {
    public int[] solution(int money) 
    {
        int coffee = money / 5500;
        money = money - (5500 * coffee);

        int[] answer = {coffee, money};
        return answer;
    }
}