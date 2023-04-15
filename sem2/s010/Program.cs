// на вход трехзначное число и показывает вторую цифру

 Console.Write("введите число ");
int number = int.Parse(Console.ReadLine());
if (number >= 100 && number < 1000)
{
    int a = number / 10 % 10;
    Console.WriteLine($"вторая цифра '{a}'"); ;
}
else
{
    Console.WriteLine("неверное число");
} 



/* int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите число ");
if (number < 100 | number >= 1000)
{
    System.Console.WriteLine("неверное число ");
    return;
}
int a = number/10%10;
System.Console.WriteLine($"вторая цифра '{a}'" ); 
*/