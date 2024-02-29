//function max
//function min
static int mx(int[] x)
{
    int max = x[0];
    for(int i=0;i<x.Length;i++)
    { if (x[i]>max)
            max = x[i];
    }
    return max; 
}
static int mn(int[] x)
{
    int min = x[0];
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] < min)
            min = x[i];
    }
    return min;
}



int[] x = { 1, 2, 3, 6, 5 };
int res = 1;
for (int i = 0;i<x.Length;i++)
{
    res *= x[i];    
}

Console.WriteLine(res);



