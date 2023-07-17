#include <string>
#include <vector>

using namespace std;

int solution(int a, int b, bool flag) {
    int answer = 0;

	//flag에 대한 이해
    if(flag)
    {
        answer = a+b;
    }
    else
    {
        answer = a-b;
    }

    return answer;
}

/*
//삼항연산자 활용법
//	①
    answer = flag ? a+b : a-b;
    return answer;
//	②
	return flag? a+b:a-b;
*/