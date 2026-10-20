Console.Write("Сколько студентов в группе?");
int studentsCount = int.Parse(Console.ReadLine());
int[] grades = new int[studentsCount];

for (int i = 0; i < grades.Length; i++) {
    Console.Write($"Оценка студента {i + 1}: ");
    grades[i] = int.Parse(Console.ReadLine());
}

int sum = 0;
foreach (int grade in grades) {
    sum += grade;
    Console.WriteLine(grade);
}
Console.WriteLine($"Средний балл: {(double)sum / grades.Length}");

int[] points = { 4, 7, 2, 9, 5 };

for (int i = 0; i < points.Length; i++) {
    if (points[i] < 10) {
        points[i]++;
    }
}

foreach (int point in points) {
    Console.WriteLine(point);
}


