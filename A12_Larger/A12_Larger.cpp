// A12_Larger.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//
using namespace std;
#include <iostream>

int Larger(int a, int b) {
	if (a > b)
		return a;
	else
		return b;
}

int main()
{
	int x, y, z;

	cout << "세개의 값을 입력하세요 : ";
	cin >> x >> y >> z;

	//int max = Larger(x, y);
	//max = Larger(max, z);

	// 한줄로 만들자
	int max = Larger(Larger(x, y), z);
	cout << "최대값 = " << max << endl;
}

