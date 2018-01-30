#include <cstdio>

using namespace std;

int main()
{
	double dis, ability = 2.0, n = 1;
	scanf("%lf", &dis);
	while (true)
	{
		dis -= ability;
		if (dis <= 0.0)
		{
			printf("%.0f\n", n);
			break;
		}
		n++;
		ability *= 0.98;
	}
	return 0;
 } 
