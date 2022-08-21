Console.WriteLine("Введите целое число: ");
try
{
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1%2==0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}
}
catch
{Console.WriteLine("Не корректный ввод данных");}
