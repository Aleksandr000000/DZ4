///Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++ )
    {
        arr[i] = new Random().Next();   
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++ )
    {
        Console.Write(arr[i]+ " ");   
    }

}



int [] array = new int [8];
FillArray(array);
PrintArray(array);