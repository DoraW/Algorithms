#include <cstdio>

using namespace std;

int main()
{
	int n, dg;
	int count[10] = {};
	scanf("%d%d", &n, &dg);
	for (int i = 1; i <= n; i++)
	{
		int temp = i;
		while (temp > 0)
		{
			count[temp % 10]++;
			temp /= 10;
		}
	}
	printf("%d\n", count[dg]);
	return 0; 
}
