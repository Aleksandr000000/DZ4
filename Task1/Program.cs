// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumberA()
{
    Console.Write("Введите  число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetNumberB()
{
    Console.Write("Введите  число: ");
    return Convert.ToInt32(Console.ReadLine());
}


int Exponentiate (int A, int B)
{
    int result = 1;
    for(int i=1; i <= B; i++)
    {
    result = result * A;
    }
    return result;
}   
int A = GetNumberA();
int B = GetNumberB();
Console.WriteLine($"Число {A} в натуральной степни {B} -> {Exponentiate ( A,  B )}"); 



