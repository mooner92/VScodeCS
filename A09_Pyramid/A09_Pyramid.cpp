// A09_Pyramid.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//
using namespace std;
#include <iostream>

int main()
{
	for (int i = 1; i <= 5; i++) {
		// 빈칸을 5-i개 
		for (int j = 0; j < 5 - i; j++)
			cout << " ";
		// 별표를 2*i-1개
		for (int k = 0; k < 2 * i - 1; k++)
			cout << "*";
		cout << endl;
	}
}
