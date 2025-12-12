// === УРОВЕНЬ 1 ===

// === ЗАДАНИЕ 1: Калькулятор оценок ===
int[] weekMarks = { 5, 4, 3, 5, 2, 5, 4 };
int sum = 0;
int countFive = 0;
int countTwo = 0;

for (int i = 0; i < weekMarks.Length; i++)
{
    sum += weekMarks[i];
    if (weekMarks[i] == 5) countFive++;
    if (weekMarks[i] == 2) countTwo++;
}

double avg = (double)sum / weekMarks.Length;
Console.WriteLine($"Средний балл: {avg}");
Console.WriteLine($"Количество пятёрок: {countFive}");
Console.WriteLine($"Количество двоек: {countTwo}");


// === ЗАДАНИЕ 2: Переворот массива ===
int[] nums = { 10, 20, 30, 40, 50 };

Console.WriteLine("Прямой порядок:");
for (int i = 0; i < nums.Length; i++) Console.Write(nums[i] + " ");

Console.WriteLine("\nОбратный порядок:");
for (int i = nums.Length - 1; i >= 0; i--) Console.Write(nums[i] + " ");


// === УРОВЕНЬ 2 ===

// === ЗАДАНИЕ 3: Чётные числа 1..20 ===
Console.WriteLine("\nЧётные числа от 1 до 20:");
for (int i = 1; i <= 20; i++)
{
    if (i % 2 != 0) continue;
    Console.Write(i + " ");
}


// === ЗАДАНИЕ 4: Пароль с ограничением ===
int attempts = 3;

for (int i = 0; i < attempts; i++)
{
    Console.Write("Введите пароль: ");
    string pass = Console.ReadLine();

    if (pass == "1234")
    {
        Console.WriteLine("Доступ разрешен");
        break;
    }
    else
    {
        Console.WriteLine("Неверный пароль");
    }

    if (i == attempts - 1)
    {
        Console.WriteLine("Доступ запрещён");
    }
}
