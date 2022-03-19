// A07_Gugu.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <iostream>
using namespace std;

int main()
{
    std::cout << "구구단!\n"; 
	
	for (int y = 1; y <= 9; y++) {
		for (int x = 2; x <= 9; x++) 
			cout << x << "x" << y << "=" << x * y << "\t";
		cout << endl;
	}
}
