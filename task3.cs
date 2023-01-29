// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
double [] array () {
    int size = 0;
    Console.WriteLine("введите размер вашего массива: ");
    int.TryParse(Console.ReadLine(), out size);
    double [] result = new double [size];
    return result;
}

double [] arrayFilling(double[] array) {
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

double difference (double[] array) {
    double minNumber = array[0];
    double maxNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(minNumber > array[i]) {
            minNumber = array[i];
        }
        if(maxNumber < array[i]) {
            maxNumber = array[i];
        }
    }

    return maxNumber - minNumber;
}

double [] myArray = array();
myArray = arrayFilling(myArray);
double myDifference = difference(myArray);
Console.WriteLine($"\nРазница: {myDifference}");