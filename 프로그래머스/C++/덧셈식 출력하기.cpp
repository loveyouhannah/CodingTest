#include <iostream>

using namespace std;

int main(void) {
    int a;
    int b;
    cin >> a >> b;
	
	//문자열과 수식을 같이 출력할 때 어떻게 cout처리를 할 것인가에 대한 문제
    cout << a << " + " << b << " = " << a+b << endl;
    return 0;
}