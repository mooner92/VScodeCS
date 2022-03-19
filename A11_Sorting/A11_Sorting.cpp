// A11_Sorting.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//
using namespace std;
#include <iostream>
#include <ctime>

int main()
{
	int a[10];

	srand((unsigned)time(0));

	for (int i = 0; i < 10; i++)
		a[i] = rand() % 100;

	cout << "Before Sorting : ";
	for (int i = 0; i < 10; i++)
		cout << a[i] << " ";
	cout << endl;

	// 정렬하는 코드
	for(int i=0; i<10; i++)
		for(int j=i+1; j<10; j++)
			if (a[i] > a[j]) {
				int tmp = a[i];
				a[i] = a[j];
				a[j] = tmp;
			}

	cout << "After Sorting : ";
	for (int i = 0; i < 10; i++)
		cout << a[i] << " ";
	cout << endl;
}
