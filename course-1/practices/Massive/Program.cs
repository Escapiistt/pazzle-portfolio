// === УРОВЕНЬ 1 ===

// ЗАДАНИЕ 1
int[] nums = { 10, 20, 30, 40, 50 };
for (int i = 0; i < nums.Length; i++)
    Console.WriteLine(nums[i]);


// ЗАДАНИЕ 2
int[] marks = { 5, 4, 3, 5, 4, 5 };
int sum = 0;
for (int i = 0; i < marks.Length; i++) sum += marks[i];
double avg = (double)sum / marks.Length;
Console.WriteLine($"Среднее: {avg}");


// ЗАДАНИЕ 3
Random rnd = new Random();
int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++) arr[i] = rnd.Next(1, 101);
int max = arr[0];
for (int i = 1; i < arr.Length; i++) if (arr[i] > max) max = arr[i];
Console.WriteLine($"Максимум: {max}");


// ЗАДАНИЕ 4
string[] fruits = { "Яблоко", "Банан", "Апельсин", "Киви", "Груша" };
foreach (string f in fruits) Console.WriteLine(f);


// === УРОВЕНЬ 2 ===

// ЗАДАНИЕ 5
int[,] table = new int[3, 3];
int value = 1;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        table[i, j] = value++;
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++) Console.Write(table[i, j] + " ");
    Console.WriteLine();
}


// ЗАДАНИЕ 6
string pass;
do
{
    Console.Write("Введите пароль: ");
    pass = Console.ReadLine();
}
while (pass != "1234");

Console.WriteLine("Пароль верный!");