#include <cstdio>

using namespace std;

int main()
{
	for (int i = 100; i <= 333; i++)
	{
		bool occupy[10] = {};
		bool flag = false;
		for (int j = i; j <= i * 3; j += i)
		{
			int temp = j;
			int hun, ten, one = j % 10;
			temp /= 10;
			ten = temp % 10;
			temp /= 10;
			hun = temp;
			if (one == ten || one == hun || hun == ten) {flag = true; break;}
			if (occupy[one] == true) {flag = true; break;}
			if (occupy[ten] == true) {flag = true; break;}
			if (occupy[hun] == true) {flag = true; break;}
			occupy[one] = true;
			occupy[ten] = true;
			occupy[hun] = true;
		}
		if (!flag && occupy[0] == false)
		{
			printf("%d %d %d\n", i, i * 2, i * 3);
		}
	}
	return 0;
}
