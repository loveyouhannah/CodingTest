#include <string>
#include <vector>

using namespace std;

int solution(double flo) 
{
    int answer = 0;
	
	//double의 소수점 버리기 = double을 int로 출력하기
    //	answer가 이미 int로 선언되어있기 때문에 1나누기 안해도 된다. 넣는 것만으로도 int형 변환.
	answer = flo / 1;
	//answer = flo;
	//answer = int(flo);

    return answer;
}