// принимает на вход координаты х и у и выдает в какой черверти точка
string Quarter ( int x, int y)
{
    if (x > 0 && y > 0) {
        return " первая четверть ";
    }
    else if ( x < 0 && y > 0) {
        return "вторая четверть";
    }
    else if ( x < 0 && y < 0) {
        return "третья четверть";
    }
    else if ( x > 0 && y < 0) {
        return "четвертая четверть";
    }
    else {
        return "не принадлежит никакой черверти";
    }
}
System.Console.WriteLine("введите х");
int x = int.Parse(Console.ReadLine());
System.Console.WriteLine("введите y");
int y = int.Parse(Console.ReadLine());
System.Console.WriteLine(Quarter(x, y));