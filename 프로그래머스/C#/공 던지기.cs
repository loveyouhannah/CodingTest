public int solution(int[] numbers, int k) 
{
    int answer = 0;
    int count = 0;

    for(int i = 0 ; i < k ; i ++)
    {
        if((numbers.Length) == count) count = 0;
        else if((numbers.Length + 1) == count) count = 1;

        answer = numbers[count];
        count += 2;
    }
    return answer;
}