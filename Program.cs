int Max(int a, int b) => a > b ? a : b;
int Max(int a, int b, int c) => Max(Max(a, b), c);