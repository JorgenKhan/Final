// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.


string[] CreateUsersStringArray(int n)
{  
    string[] array = new string[n];
    for (int i = 0; i < n; i++) 
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Console.ReadLine();            
    }
    return array;
}
