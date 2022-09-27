// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumbr () /// метод ввода числа
{
    int  num = 0 ;
    while (num < 10)
    {
        Console.WriteLine("Введите число  (которое больше 9) ");  
        num = Convert.ToInt32(Console.ReadLine());
    }   
    return num;   
}


int Sumnumbers(int A )
{
    int summ = 0;
    for ( int i = 3 ; i >= 0 ;  i--) 
    {
        summ += A/Convert.ToInt32(Math.Pow(10.01, i));
        A = A%(int)Convert.ToInt32(Math.Pow(10.0,i));
    }
    return summ;

}

int A = GetNumbr ();
int B = Sumnumbers(A);
Console.WriteLine($"Сумма всех цифр в числе {A} --> {B}");



