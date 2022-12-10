// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)

int Poww(int a, int b) {
    int sum = a;
    for (int i = 1; i < b; i++)
    {
        sum = sum * a;
        System.Console.WriteLine(sum);  
    }
return sum;
}

System.Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = Poww(a, b);

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)

void Summ(int a){
    int summ = 0;
    while (a > 0){
        summ += a %10;
        a /= 10;
    }
    System.Console.WriteLine($"Сумма цифр равна: {summ}");
}
System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Summ(a);

// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.

int[] Array(int numb) {
    int [] arr = new int [numb];
    for (int i = 0; i < numb; i++) {
        System.Console.WriteLine($"Введите {i}-ый элемент массива");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
void ShowArray (int[] arr) {
    System.Console.WriteLine("Вывожу ваш красивый массив:");
    for (int i = 0; i < arr.Length; i++) {
        System.Console.Write($"{arr[i]} ");
    }
}
System.Console.Write("Введите размер массива: ");
int lengthMass = Convert.ToInt32(Console.ReadLine());
ShowArray(Array(lengthMass));

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]