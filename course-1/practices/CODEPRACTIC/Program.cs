// Задание 1: Проверка числа
Console.WriteLine("Задание 1: Проверка числа");
int number = 10;
if (number > 0)
    Console.WriteLine("Число положительное");
else if (number < 0)
    Console.WriteLine("Число отрицательное");
else
    Console.WriteLine("Число равно нулю");
Console.WriteLine();

// Задание 2: Проверка возраста
Console.WriteLine("Задание 2: Проверка возраста");
Console.Write("Введите ваш возраст: ");
int age = int.Parse(Console.ReadLine());
if (age >= 18)
    Console.WriteLine("Вы совершеннолетний");
else
    Console.WriteLine("Вы несовершеннолетний");
Console.WriteLine();

// Задание 3: Проверка чётности числа
Console.WriteLine("Задание 3: Проверка чётности числа");
int num = 7;
if (num % 2 == 0)
    Console.WriteLine("Число чётное");
else
    Console.WriteLine("Число нечётное");
Console.WriteLine();

Console.WriteLine("=== Практика: Уровень 2 ===\n");

// Задание 4: Логические операторы
Console.WriteLine("Задание 4: Логические операторы");
int a = 5, b = -2;
if (a > 0 && b > 0)
    Console.WriteLine("Оба числа положительные");
else if (a > 0 || b > 0)
    Console.WriteLine("Хотя бы одно число положительное");
else if (a <= 0)
    Console.WriteLine("a не положительное");
Console.WriteLine();

// Задание 5: Калькулятор оценок
Console.WriteLine("Задание 5: Калькулятор оценок");
Console.Write("Введите оценку (от 2 до 5): ");
int grade = int.Parse(Console.ReadLine());
if (grade < 3)
    Console.WriteLine("Неудовлетворительно");
else if (grade == 3)
    Console.WriteLine("Удовлетворительно");
else if (grade == 4)
    Console.WriteLine("Хорошо");
else if (grade == 5)
    Console.WriteLine("Отлично");
Console.WriteLine();

// Задание 6: Калькулятор
Console.Write("Число: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Число: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Операция: ");
string z = Console.ReadLine();

if (z == "+") Console.WriteLine(x + y);
if (z == "-") Console.WriteLine(x - y);
if (z == "*") Console.WriteLine(x * y);
if (z == "/") Console.WriteLine(x / y);

// Задание 7: Проверка пароля
string password = "12345";
Console.Write("Пароль: ");
string input = Console.ReadLine();

if (input == password)
    Console.WriteLine("Доступ получен");
if (input != password)
    Console.WriteLine("Доступ запрещен");