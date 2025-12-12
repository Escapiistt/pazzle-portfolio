using System;

static class Program
{
    static int counter = 0;

    static void Main()
    {
        // === ЗАДАНИЕ 1 ===
        SayHello();
        SayHello();
        SayHello();

        // === ЗАДАНИЕ 2 ===
        Greet("Саша");
        Greet("Ярослав");
        Greet("Анна");

        // === ЗАДАНИЕ 3 ===
        PrintPerson("Егор", 15, "Москва");
        PrintPerson("Оля", 17, "Казань");

        // === ЗАДАНИЕ 4 ===
        PrintPerson2("Андрей", 20, "Чтение");
        PrintPerson2("Марина");

        // === ЗАДАНИЕ 5 ===
        Console.WriteLine(Square(5));

        // === ЗАДАНИЕ 6 ===
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите операцию (+, -, *, /): ");
        string op = Console.ReadLine();

        switch (op)
        {
            case "+": Console.WriteLine(Add(a, b)); break;
            case "-": Console.WriteLine(Subtract(a, b)); break;
            case "*": Console.WriteLine(Multiply(a, b)); break;
            case "/": Console.WriteLine(Divide(a, b)); break;
            default: Console.WriteLine("Неизвестная операция"); break;
        }

        // === ЗАДАНИЕ 7 ===
        Increment(); Console.WriteLine(counter);
        Increment(); Console.WriteLine(counter);
        Increment(); Console.WriteLine(counter);

        // === ЗАДАНИЕ 8 ===
        Console.WriteLine(Multiply(2, 3));
        Console.WriteLine(Multiply(2, 3, 4));
        Console.WriteLine(Multiply(2.5, 4.0));
    }

    static void SayHello() => Console.WriteLine("Привет, мир!");
    static void Greet(string name) => Console.WriteLine($"Привет, {name}!");
    static void PrintPerson(string name, int age, string city) =>
        Console.WriteLine($"Имя: {name} Возраст: {age} Город: {city}");

    static void PrintPerson2(string name, int age = 18, string hobby = "Не указано") =>
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Хобби: {hobby}");

    static int Square(int x) => x * x;

    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
    static int Multiply(int a, int b) => a * b;
    static double Divide(int a, int b)
    {
        if (b == 0) return 0;
        return (double)a / b;
    }

    static void Increment() => counter++;

    // ПЕРЕГРУЗКИ
    static int Multiply(int a, int b, int c) => a * b * c;
    static double Multiply(double a, double b) => a * b;
}
