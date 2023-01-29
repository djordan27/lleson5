// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

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
        array[count] = rnd.Next(100, 1000);
        Console.Write(array[count] + " ");
        count++;
    }
    Console.Write("]");
    return array;
}

int evenNumber (int[] array) {
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) {
            even++;
        }
    }
    return even;
}

int [] myArray = array();
myArray = arrayFilling(myArray);
int even = evenNumber(myArray);
Console.WriteLine($"\nКоличество четных чисел: {even}");