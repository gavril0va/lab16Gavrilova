// Console.Write("Сколько студентов в группе?");
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];

// for (int i = 0; i < grades.Length; i++) {
//     Console.Write($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine());
// }

// int sum = 0;
// foreach (int grade in grades) {
//     sum += grade;
//     Console.WriteLine(grade);
// }
// Console.WriteLine($"Средний балл: {(double)sum / grades.Length}");

// int[] points = { 4, 7, 2, 9, 5 };

// for (int i = 0; i < points.Length; i++) {
//     if (points[i] < 10) {
//         points[i]++;
//     }
// }

// foreach (int point in points) {
//     Console.WriteLine(point);
// }

// int[] grades = { 4, 5, 3, 5, 4, 2 };

// for (int i = 0; i < grades.Length - 1; i++) {
//     for (int j = 0; j < grades.Length - 1 - i; j++) {
//         if (grades[j] < grades[j + 1]) { 
//             int temp = grades[j];
//             grades[j] = grades[j + 1];
//             grades[j + 1] = temp;
//         }
//     }
// }

// foreach (int grade in grades) {
//     Console.WriteLine(grade);
// }


// int[] GenerateEvenSlots(int lessonsCount) {
//     int[] slots = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++) {
//         slots[i] = (i + 1) * 2;
//     }
//     return slots;
// }


// int[] evenSlots = GenerateEvenSlots(6);
// foreach (int slot in evenSlots) {
//     Console.WriteLine(slot);
//}


// int[] grades = { 4, 5, 3, 5, 4, 2 };
// Array. Sort (grades);

// foreach (int grade in grades) {
// Console.WriteLine(grade);
// }


// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());

// int[] squares = new int[N];

// for (int i = 0; i < N; i++) {
//     squares[i] = (i + 1) * (i + 1);
// }

// Console.WriteLine("Полученный массив:");
// foreach (int number in squares) {
//     Console.WriteLine(number);
// }


// int[] numbers = { -3, 5, -1, 8, -7, 0, 2 };

// Console.WriteLine("Исходный массив:");
// foreach (int num in numbers) {
//     Console.Write(num + " ");
// }


// for (int i = 0; i < numbers.Length; i++) {
//     if (numbers[i] < 0) {  
//         numbers[i] = 0;    
//     }
// }

// Console.WriteLine("\nИзмененный массив:");
// foreach (int num in numbers) {
//     Console.Write(num + " ");
// }


// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 
// if (string.IsNullOrEmpty(surname)) { 
// Console.WriteLine("Фамилия не введена. Завершение работы."); 
// return; 
// } 
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
// var assigned = Enumerable.Range(1, 10) 
// .OrderBy(_ => rnd.Next()) 
// .Take(2) 
// .OrderBy(x => x) 
// .ToList(); 
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

//ЗАДАЧА 2
int[] numbers = { 6, 8, 9, 15, 22, 3, 7 };

Console.WriteLine("Исходный массив:");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 3 == 0)
    {
        numbers[i] = -1;  
    }
}

Console.WriteLine("\nИзмененный массив:");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}


//ЗАДАЧА 4
{
    static int[] GenerateFibonacci(int n) 
    {
        int[] fib = new int[n];
        
        if (n <= 0) return fib;
        
        fib[0] = 1;
        if (n == 1) return fib;
        
        fib[1] = 1;
        
        for (int i = 2; i < n; i++) 
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
        
        return fib;
    }
 
    {
        Console.Write("Введите количество чисел: ");
        int count = int.Parse(Console.ReadLine());
        
        int[] result = GenerateFibonacci(count);
        
        Console.WriteLine("Числа Фибоначчи:");
        foreach (int number in result) 
        {
            Console.Write(number + " ");
        }
    }
}


