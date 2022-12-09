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

string[] CreateStringArray(string[] array, int numberSymbol = 3)
{
    int lengthNewArray = 0;
    for(int i = 0; i < array.Length;i++)
        if(array[i].Length <= numberSymbol) lengthNewArray++;

    string[] newArray = new string[lengthNewArray];

    for(int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length <= numberSymbol)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

