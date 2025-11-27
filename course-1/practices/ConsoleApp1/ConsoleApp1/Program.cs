// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Мне выпала Чиса в Wuthering Waves");
Console.WriteLine("Так же я выбил её сигнатурное оружие");
Console.WriteLine("И апнул первого героя в доте 2!");

// Задание 1
int a = 12;
int b = 5;
Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b);

// Задание 2
Console.Write("Как тебя зовут? ");
string name = Console.ReadLine()!;
Console.WriteLine($"Привет, {name}!");

// Задание 3
Console.Write("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(n1 + n2);

// Задание 4
Console.Write("Введите ширину: ");
int width = int.Parse(Console.ReadLine()!);
Console.Write("Введите длину: ");
int height = int.Parse(Console.ReadLine()!);
Console.WriteLine(width * height);

// Задание 5
Console.Write("Введите температуру в Цельсиях: ");
double c = double.Parse(Console.ReadLine()!);
double f = c * 9 / 5 + 32;
Console.WriteLine(f);

// Задание 6
Console.Write("Введите первое число: ");
double t1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
double t2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
double t3 = double.Parse(Console.ReadLine()!);
double avg = (t1 + t2 + t3) / 3;
Console.WriteLine($"Среднее: {avg}");

// Задание 7
Console.Write("Введите число номер 1: ");
double c1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите число номер 2: ");
double c2 = double.Parse(Console.ReadLine()!);
Console.WriteLine(c1 + c2);
Console.WriteLine(c1 - c2);
Console.WriteLine(c1 * c2);
Console.WriteLine(c1 / c2);

// Задание 8
Console.Write("Введите количество рублей: ");
double rub = double.Parse(Console.ReadLine()!);

int usd = 79;
int eur = 87;
int cny = 11;

Console.WriteLine(rub / usd);
Console.WriteLine(rub / eur);
Console.WriteLine(rub / cny);
