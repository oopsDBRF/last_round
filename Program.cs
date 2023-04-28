// Данный вариант предусматривает рандомную генерацию строки и запрос размера ориг массива от пользователя.
/*
string text = "AEIOUBCDFGHJKLMNPQRSTVWXYZ1234567890";


string[] CreateArr(int size)
{
    string[] array = new string[size];

    for(int i = 0; i < size; i++) 
    {
        int num = new Random().Next(1, 10); // Был text.Lenght вместо 10, но очень редко выпадали значения <= 3.
        for(int j = 0; j < num; j++)
        {
            array[i] += Convert.ToString(text[j]);
        }
    }
    
    return array;
}


string[] CreateNewArr(string[] array)
{
    string[] newArray = new string[array.Length];
    int counter = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[counter] = array[i];
            counter += 1;
        }
    }

    return newArray;
}



void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] showArr = CreateArr(size);
ShowArray(showArr);
ShowArray(CreateNewArr(showArr));
*/


// Данный вариант предусматривает ввод пользователем Размера и самих Строк.
/*
string[] CreateArr(int size)
{
    string[] array = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите строку: ");
        string text = Convert.ToString(Console.ReadLine());
        array[i] = text;
    }
    return array;
}



string[] CreateNewArr(string[] array)
{
    string[] newArray = new string[array.Length];
    int counter = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[counter] = array[i];
            counter += 1;
        }
    }

    return newArray;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] showArr = CreateArr(size);
CreateNewArr(showArr);
ShowArray(CreateNewArr(showArr));
*/