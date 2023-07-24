#include <iostream>

using namespace std;

int main(void) 
{
    string str;
    cin >> str;
        
    for(int i = 0 ; i < str.length() ; i++)
    {
        if( 97 > str[i]) //str[i]가 대문자일 경우 
            str[i] = tolower(str[i]);
        else
            str[i] = toupper(str[i]);
    }
    
    cout << str;
    return 0;
}

//아스키 코드의 특징을 활용한 답
//	대소문자의 아스키 코드 수의 차는 32이다.
/* 
#include <iostream>
#include <string>

using namespace std;

int main(void) {
    string str;
    cin >> str;

    for (int i = 0; i < str.length(); i++) {
        if (str[i] >= 90)
            str[i] -= 32;
        else
            str[i] += 32;
    }

    cout << str;
    return 0;
}
*/


//아스키 코드의 특징을 활용한 답 2
//	97과 65의 차이는 32라는 것이 생각이 나지 않을 때
//	문자의 차를 더하여 대문자로 만들고, 문자의 차를 빼서 소문자로 만든다.
/*
#include <iostream>
#include <string>

using namespace std;

int main(void)
{
    string str;
    cin >> str;
    for (auto c : str)
    {
        if ('a' <= c && c <= 'z')
            c -= 'a' - 'A';
        else
            c += 'a' - 'A';
        cout << c;
    }
    return 0;
}
*/

//범위 기반 for문
//for(char ch : str) //문자열 str에서 하나씩 ch에 넣으며 for문 돌기
//for(auto c : str) //문자열 str에서 자료형 미지정 c에 넣으며 for문 돌기 -> 컴파일러가 자료형 추론



