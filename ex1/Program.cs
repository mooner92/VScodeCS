// See https://aka.ms/new-console-template for more information
/*Console.Write("정수 하나를 입력하세요 : ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("결과는 {0}", fact(n));

int fact(int n)
{
    if (n == 1)
    {
        return 1;
    }
    return fact(n - 1) * n;
}*/

/*Console.Write("정수 하나를 입력하세요 : ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("결과는 {0}", Sum(n));


int Sum(int n)
{
    if (n == 1) 
        return 1;

    return Sum(n - 1) + n;
}*/


/*int[] a = new int[1000001];
Console.Write("정수 하나를 입력하세요 : ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("결과는");

int fibo(int n)
{
    a[n-1] = fibo(n);
    if(n==1 || n == 2)
    {
        return 1;
    }
    return fibo(n - 1) + fibo(n - 2);

}

for (int i = 0; i < n; i++)
{
    Console.WriteLine("{0}", a[i]);
}*/

/*hanoi(4, 'A', 'B', 'C');

void hanoi(int n, char f, char v, char t)
{
    if (n == 1)
    {
        Console.WriteLine("{0}=>{1}", f, t);
    }
    else
    {
        hanoi(n - 1, f, t, v);
        Console.WriteLine("{0}=>{1}", f, t);
        hanoi(n - 1, v, f, t);
    }
}*/