#include <cstdio>

using namespace std;

int main()
{
	int k, n = 1;
	double sn = 0;
	scanf("%d", &k);
	while (true)
	{
		sn += 1 / double(n);
		if (sn > k)
		{
			printf("%d\n", n);
			return 0;
		}
		n++;
	}
	return 0;
 } 
