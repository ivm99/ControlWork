string[] NewStringArrayInput(int size)
{
    string [] newStringArray = new string [size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i}-й элемент массива: ");
        newStringArray[i] = Console.ReadLine();
        //Console.WriteLine();
    }

    return newStringArray;
}

void PrintArray (string [] arrayToPrint)
{
    Console.Write("[ ");

    for (int i = 0; i < arrayToPrint.Length-1; i++)
    {
        Console.Write (arrayToPrint[i] + " ; ");
    }

    Console.Write (arrayToPrint[arrayToPrint.Length-1] + " ]");
    Console.WriteLine();
}

Console.Write("Введите число элементов массива:");
int size = Convert.ToInt32(Console.ReadLine());

string [] newStringArray = NewStringArrayInput(size);

Console.Write("Введенный массив: ");
PrintArray(newStringArray);


