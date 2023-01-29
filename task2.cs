// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int [] array () {
    int size = 0;
    Console.WriteLine("введите размер вашего массива: ");
    int.TryParse(Console.ReadLine(), out size);
    int [] result = new int [size];
    return result;
}

int [] arrayFilling(int[] array) {
    Random rnd = new Random();
    int count = 0;
    Console.Write("[ ");
    while(count < array.Length){
        array[count] = rnd.Next(-2_147_483_648, 2_147_483_647);
        Console.Write(array[count] + " ");
        count++;
    }
    Console.Write("]");
    return array;
}

int notEvenNumber (int[] array) {
    int notEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0 && i != 0) {
            notEven += array[i];
        }
    }
    return notEven;
}

int [] myArray = array();
myArray = arrayFilling(myArray);
int notEven = notEvenNumber(myArray);
Console.WriteLine($"\nСумма нечетных чисел: {notEven}");