// на вход два числа и проверяет ялвяется ли одно квадратом другого
Console.Write("введите числа ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a*a == b | b*b==a)
{
    System.Console.WriteLine("верно");
}
else{
    System.Console.WriteLine("не верно");
}