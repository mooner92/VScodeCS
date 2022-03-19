// A05_Loop.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//
using namespace std;
#include <iostream>

int main()
{
	int sum = 0;	// 초기값 중요

	for (int i = 1; i <= 100; i++)
		sum += i;	// sum = sum + i
	cout << "1~100의 합 = " << sum << endl;

	int evenSum = 0;
	int oddSum = 0;
	for (int i = 1; i <= 100; i++) {
		if (i % 2 == 0) // 짝수
			evenSum += i;
		else
			oddSum += i;
	}
	cout << "1~100사이의 짝수의 합 = " << evenSum << endl;
	cout << "1~100사이의 홀수의 합 = " << oddSum << endl;

	double rSum = 0;
	for (int i = 1; i <= 100; i++)
		rSum += 1.0 / i;
	cout << "1~100의 역수의 합 = " << rSum << endl;

}
