// A08_Prime.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//
using namespace std;
#include <iostream>

int main()
{
	int nPrime = 0;
	int j;

	for (int i = 2; i <= 1000; i++) {
		for (j = 2; j <= i - 1; j++) {
			if (i % j == 0)	// 나누어지는 수, 소수가 아니다
				break;	// 반복문 하나를 빠져나간다
		}
		if (j == i) {	// 소수라는 뜻이 된다
			nPrime++;
			cout << i << "\t";
		}
	}
	cout << "\n소수의 갯수 = " << nPrime << endl;
}
