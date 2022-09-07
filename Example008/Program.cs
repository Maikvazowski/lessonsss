int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}


int a1 = 13345;
int b1 = 23422341;
int c1 = 39;
int a2 = 154542;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23111;
int c3 = 3154;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a1, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2), 
    Max(a1, b3, c3));

Console.WriteLine(max);