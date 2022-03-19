// A01_IO.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//


#include <iostream>
using namespace std;

int main()
{
	int id;	// 학번
	char name[10];	// 이름(문자배열)

	cout << "학번을 입력하세요: ";
	cin >> id;

	cout << "이름을 입력하세요: ";
	cin >> name;

	cout << "학번 : " << id << endl;

	cout << "이름 : " << name << endl;
}
