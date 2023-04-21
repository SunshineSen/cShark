// на вход координаты 2х точек и рассчитывает 3d расстояние между ними
double Dist (double x1, double x2, double y1, double y2, double z1, double z2)
{
   double r = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
   return r;
}
System.Console.WriteLine("введите координаты первой точки");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double z1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("введите координаты второй точки");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double z2 = double.Parse(Console.ReadLine());
System.Console.WriteLine(Dist(x1, x2, y1, y2, z1, z2));
