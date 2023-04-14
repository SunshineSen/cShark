// принимать на вход два числа, выводить является ли второе кратным первому. если число не кратно, выести остаток от деления
Console.Write("введите числа ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = a % b;

if (c == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно " + c);
}
