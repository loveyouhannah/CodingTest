#include <iostream>
#include <string>

using namespace std;

int main(void) {
    string str;
    int n;
    cin >> str >> n;

	//나의 답. for문은 C#과 사용방법이 동일하다.
    for(int i = 0 ; i < n ; i++)
    {
        cout << str;
    }

	//다른 분의 답. while문 조건이 false(0)일 경우 빠져나오는 것을 활용.
	//while(n--)
    //    cout << str;
    return 0;
}

