#include <cstdio>

using namespace std;

int main()
{
	int max = 0, day = 0;
	for (int i = 1; i <= 7; i++)
	{
		int temp, temp1;
		scanf("%d%d", &temp, &temp1);
		temp += temp1;
		if (temp > max)
		{
			max = temp;
			day = i;
		}
	}
	printf("%d\n", day);
	return 0;
} 
