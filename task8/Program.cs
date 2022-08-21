Console.WriteLine("Введите число: ");
try
{
    int N = Convert.ToInt32(Console.ReadLine());
int x = 2;

if (N<2) 
{
  Console.WriteLine("Неверно");  
}
else
{
    while (x<=N)
    {
        Console.WriteLine(x);
        x=x+2;
    }
}
}
catch
{
    Console.WriteLine("Не корректный ввод данных"); 
}










