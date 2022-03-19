// A15_Hanoi.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <iostream>
using namespace std;

void Hanoi(int n, char from, char via, char to) 
{
	// 재귀함수는 반드시 끝나는 조건이 있어야 한다
	if (n == 1) {
		cout << from << " -> " << to << endl;
	}
	else {
		Hanoi(n - 1, from, to, via);
		cout << from << " -> " << to << endl;
		Hanoi(n - 1, via, from, to);
	}
}

int main()
{
	Hanoi(4, 'A', 'B', 'C');
}
