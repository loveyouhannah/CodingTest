#include <string>
#include <vector>

using namespace std;

int solution(int num, int n) {
    int answer = 0;

	//n이 num의 약수이면 %결과 0 = false가 되는 개념
    if(num % n)
        answer = 0;
    else
        answer = 1;

    return answer;
}

/*
//삼항 연산자
	return num%n == 0 ? 1:0;
*/