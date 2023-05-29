int[] arr = { 7, 8, 3, 6, 4, 1, 2, 3, 3, 8, 11, 35, 89, 75 };
void PrintArry(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++) 
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }





        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;



    }

}
PrintArry(arr);
SelectionSort(arr);

PrintArry(arr);