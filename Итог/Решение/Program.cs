Console.WriteLine("Введите длину массива: ");
int A = int.Parse(Console.ReadLine());
string[] arrayOne = new string[A];

void Fill(string[] a)
{
    int lenght = a.Length;
    int index = 0;
    while (index < lenght)
    {
        Console.WriteLine($"Введите значение массива с индексом {index}");
        a[index] = Console.ReadLine();
        index++;
    }
}

void Print(string[] b)
{
    int l = b.Length;
    int p = 0;
    while (l > p)
    {
        Console.WriteLine(b[p]);
        p++;
    }
}

int SearchLengthThreeElements(string[] array)
{
    string c = array[3];
    int elements = c.Length;
    return elements;
}
 
void SearchTwoArray(string[] arrayOne, string[]  arrayTwo, int с)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
    if(arrayOne[i].Length <= с)
        {
        arrayTwo[count] = arrayOne[i];
        count++;
        }
    }
}

void PrintTwoArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
} 


Fill(arrayOne);
System.Console.WriteLine(" ");
System.Console.WriteLine("Массив:");
Print(arrayOne);
int c = SearchLengthThreeElements(arrayOne);
Console.WriteLine("Длина третьего элемента Массива:");
Console.WriteLine(c);
string[] arrayTwo = new string[arrayOne.Length];

SearchTwoArray(arrayOne, arrayTwo, c);
Console.WriteLine("Новый массив выглядит вот так:");
PrintTwoArray(arrayTwo);