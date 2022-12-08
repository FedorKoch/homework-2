Console.Clear();
Console.WriteLine("введите цифру");
int a = int.Parse(Console.ReadLine());
if (a < 1 | a > 7)
Console.WriteLine("данное число не является номером дня недели");
if (a >= 1 & a <= 5)
Console.WriteLine("будний день");
if (a >= 6 & a <= 7)
Console.WriteLine("выходной день");