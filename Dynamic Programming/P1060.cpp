#include <cstdio>

using namespace std;

int bank, n;
int goods[30], price[30], worths[30];

int max(int a, int b)
{
	if (a > b) return a;
	return b;
}

int subs(int range, int cost, int rewards)
{
	if (range > n) return rewards;
	if (cost + price[range] > bank) return subs(range + 1, cost, rewards);
	return max(subs(range + 1, cost, rewards), subs(range + 1, cost + price[range], rewards + goods[range]));
}

int main()
{
	scanf("%d%d", &bank, &n);
	for (int i = 1; i <= n; i++)
	{
		scanf("%d%d", &price[i], &worths[i]);
		goods[i] = price[i] * worths[i];
	}
	printf("%d\n", subs(1, 0, 0));
	return 0;
} 
