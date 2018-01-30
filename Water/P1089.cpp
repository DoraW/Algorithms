#include <cstdio>

using namespace std;

int main()
{
	int bank = 0, charge = 0;
	for (int i = 1; i <= 12; i++)
	{
		charge += 300;
		int cost;
		scanf("%d", &cost);
		charge -= cost;
		if (charge < 0)
		{
			printf("-%d\n", i);
			return 0;
		}
		bank += (charge / 100) * 100;
		charge %= 100;
	}
	charge += bank / 100 * 120;
	printf("%d\n", charge);
	return 0;
}
