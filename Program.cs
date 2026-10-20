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

int[] grades = { 4, 5, 3, 5, 4, 2 };

for (int i = 0; i < grades.Length - 1; i++) {
    for (int j = 0; j < grades.Length - 1 - i; j++) {
        if (grades[j] < grades[j + 1]) { 
            int temp = grades[j];
            grades[j] = grades[j + 1];
            grades[j + 1] = temp;
        }
    }
}

foreach (int grade in grades) {
    Console.WriteLine(grade);
}


int[] GenerateEvenSlots(int lessonsCount) {
    int[] slots = new int[lessonsCount];
    for (int i = 0; i < lessonsCount; i++) {
        slots[i] = (i + 1) * 2;
    }
    return slots;
}


int[] evenSlots = GenerateEvenSlots(6);
foreach (int slot in evenSlots) {
    Console.WriteLine(slot);
}
