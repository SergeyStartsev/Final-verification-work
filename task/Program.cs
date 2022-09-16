Console.WriteLine("Введите значение длины массива: ");
int N = Convert.ToInt32(Console.ReadLine());
string[] array = new string[N];
int count = 0;
for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент : ");
    string str = Console.ReadLine();
    array[i] = str;
    if (array[i].Length <= 3)
        {
            count++;
        }    
}
string[] word = new string[count];
Console.WriteLine();
Console.Write("Начальный ");
PrintArray(array);
NevArray(array, word);
Console.Write("Итоговый ");
PrintArray(word);


void PrintArray(string[] array)
{
    Console.WriteLine("массив: [" + string.Join(", ", array) + "]");
    Console.WriteLine();
}


void NevArray(string[] arr, string[] word)
{
    int count = 0;    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            word[count] = arr[i];
            count++;
        }
        
    }
}