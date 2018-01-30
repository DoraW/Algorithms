#include <cstdio>

using namespace std;

int main()
{
	unsigned long long miles = 0, n, sum_day = 0;
	int day;
	scanf("%d%lld", &day, &n);
	if (day > 5)
		n -= (8 - day);
	else
	{
		sum_day = (6 - day);
		n -= sum_day + 2;
	}
	if (n < 0)
	{
		printf("%d\n", n * 250);
		return 0;
	}
	sum_day += (n % 7) > 5 ? 5 : n % 7;
	sum_day += (n / 7) * 5;
	printf("%lld\n", sum_day * 250);
	return 0;
}
