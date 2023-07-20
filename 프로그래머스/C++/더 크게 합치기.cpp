#include <string>
#include <vector>

using namespace std;

int solution(int a, int b) 
{
    int answer = 0;
	string strA = to_string(a);//string만들기
	string strB = to_string(b);
	
	string strAB = strA + strB;
	string strBA = strB + strA;
	
	if(strAB > strBA) //사전순으로 strAB가 뒤인 가?
	{
		answer = stoi(strAB); //stoi : string to int
	}
	else
	{
		answer = stoi(strBA);
	}
	
	return answer;
}