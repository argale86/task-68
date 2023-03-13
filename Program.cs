//Найти функцию Аккемана для чисел M и N с помощью рекурсии

uint Akker (uint m, uint n)
{
    if (m == 0) 
    {
        return n+1;
    }
    else
    {
        if ((m != 0) && (n == 0))
        {
            return Akker(m-1,1);
        }
        else
        {
            return Akker(m-1, Akker(m,n-1));
        }
    }
}

Console.WriteLine("Введите целое положительное число M:");
uint numberm = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N:");
uint numbern = Convert.ToUInt32 (Console.ReadLine());
Console.WriteLine(Akker (numberm,numbern));
