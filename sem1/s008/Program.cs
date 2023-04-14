// на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("введите число ");
int j = int.Parse(Console.ReadLine());
 for (int i = 1; i <= j;  i++)
 {
    if (i % 2 == 0)
         Console.WriteLine(i+"");
 }