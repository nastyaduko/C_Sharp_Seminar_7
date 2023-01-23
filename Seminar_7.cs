// // Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);



// // -------------------Методы---------------------------------
// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле:  
// Aₘₙ = m+n. Выведите полученный массив на экран. 
 
/*int[,] GetArray(int m, int n, int minValue, int maxValue){ 
    int[,] result = new int[m,n]; 
    for(int i = 0; i < m; i++){ 
    for(int j = 0; j < n; j++){ 
    result[i,j] = i + j; 
        } 
    } 
    return result; 
} 
 
void PrintArray(int[,] array){ 
    for(int i = 0; i < array.GetLength(0); i++){ 
        for(int j = 0; j < array.GetLength(1); j++){ 
            Console.Write($"{array[i,j]} "); 
        } 
        Console.WriteLine(); 
    } 
}*/ 
 
// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты. 
 
/*Console.Write("Введите количество строк: "); 
int rows = int.Parse(Console.ReadLine()!); 
 
Console.Write("Введите количество столбцов: "); 
int columns = int.Parse(Console.ReadLine()!); 
 
int[,] array = GetArray(rows, columns, 0, 10); 
PrintArray(array); 
Console.WriteLine(); 
PrintArray(GetArray2(array)); 
 
int[,] GetArray(int m, int n, int minValue, int maxValue){ 
    int[,] result = new int[m,n]; 
    for(int i = 0; i < m; i++) 
    { 
    for(int j = 0; j < n; j++) 
    { 
    result[i,j] = i + j; 
    } 
    } 
    return result; 
} 
 
void PrintArray(int[,] array){ 
    for(int i = 0; i < array.GetLength(0); i++) 
    { 
    for(int j = 0; j < array.GetLength(1); j++) 
    { 
    Console.Write($"{array[i,j]} "); 
    } 
        Console.WriteLine(); 
    } 
} 
 
int[,] GetArray2(int[,] array) 
{ 
   // int[,] Array2 = new int[rows,columns]; 
    for(int i = 0; i < array.GetLength(0); i++) 
    { 
    for(int j = 0; j < array.GetLength(1); j++) 
    { 
    if (i % 2 == 0 && j % 2 == 0)  
    array[i,j] = array[i,j] * array[i,j]; 
    } 
    } 
    return array; 
}*/ 
//Задача 51:** Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д. 
// Console.Write("Введите количество строк: "); 
// int rows = int.Parse(Console.ReadLine()!); 
 
// Console.Write("Введите количество столбцов: "); 
// int columns = int.Parse(Console.ReadLine()!); 
 
// int[,] array = GetArray(rows, columns, 0, 10); 
// PrintArray(array); 
// Console.WriteLine($" The sum is equal to {GetSumOfElements(array)}"); 
 
 
// int[,] GetArray(int m, int n, int minValue, int maxValue){ 
//     int[,] result = new int[m,n]; 
//     for(int i = 0; i < m; i++) 
//     { 
//     for(int j = 0; j < n; j++) 
//     { 
//     result[i,j] = i + j; 
//     } 
//     } 
//     return result; 
// } 
 
// void PrintArray(int[,] array){ 
//     for(int i = 0; i < array.GetLength(0); i++) 
//     { 
//     for(int j = 0; j < array.GetLength(1); j++) 
//     { 
//     Console.Write($"{array[i,j]} "); 
//     } 
//         Console.WriteLine(); 
//     } 
// } 
 
// int GetSumOfElements(int[,] array) 
// { 
//     int sum = 0; 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//     for(int j = 0; j < array.GetLength(1); j++) 
//     { 
//     if (i == j)  
//     sum = sum + array[i,j]; 
//     } 
//     } 
//     return sum; 
// }



















/***Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

Сумма элементов главной диагонали: 1+9+2 = 12*/
