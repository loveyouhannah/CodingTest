#include <iostream>

using namespace std;

int main(void) 
{
    int n;
    cin >> n;

	//홀짝 구분 문제. %를 이용할 수 있는가에 대한 문제
    if(n % 2 == 0)
    {
        cout << n << " is even";
    }
    else
    {
        cout << n << " is odd";
    }

    return 0;
}


/*
//n이 홀수이면, n % 2가 1(true)이며 n이 짝수이면, n % 2가 0(false)이다.
    if(n%2)
        cout << n <<" is odd"; //홀수
    else
        cout << n <<" is even";//짝수
*/

/*
//C++의 삼항연산자-활용법
cout << n << " is " << (n%2==0 ? "even":"odd");
*/