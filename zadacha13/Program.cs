Console.Clear();
int chislo = 0;
Console.WriteLine("введите a");
int a = int.Parse(Console.ReadLine());
while (a >= 1000)
{
    a = a / 10;
}
chislo = a % 10;
  Console.WriteLine(chislo); 