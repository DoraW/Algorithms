#include <cstdio>

using namespace std;

int main()
{
	int n, min = 2147483647;
	scanf("%d", &n);
	for (int i = 1; i <= 3; i++)
	{
		int single, amount, price;
		scanf("%d%d", &single, &price);
		amount = n / single;
		if (n % single != 0) amount++;
		int cost = amount * price;
		if (cost < min) min = cost;
	}
	printf("%d\n", min);
	return 0;
}
