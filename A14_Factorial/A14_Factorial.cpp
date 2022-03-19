// A14_Factorial.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//
using namespace std;
#include <iostream>

int Factorial(int n) {
	if (n == 1)
		return 1;
	else
		return Factorial(n - 1) * n;
}

int main()
{
    std::cout << "n!을 구하기 위해 숫자 하나를 입력하세요 : "; 

	int n;
	cin >> n;

	cout << n << "! = " << Factorial(n) << endl;
}
