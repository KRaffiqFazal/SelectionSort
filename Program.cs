using System; //https://www.tutorialspoint.com/selection-sort-program-in-chash#:~:text=Selection%20Sort%20is%20a%20sorting,until%20the%20array%20is%20sorted.
public class Example
{
    static void Main(string[] args)
    {
        int[] arr = new int[5] { 3, 2, 5, 1, 4 };
        int n = 5;
        Console.WriteLine("Selection sort");
        Console.Write("Initial array is: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        int temp, smallest;
        for (int i = 0; i < n - 1; i++)
        {
            smallest = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[smallest])
                {
                    smallest = j;
                }
            }
            temp = arr[smallest];
            arr[smallest] = arr[i];
            arr[i] = temp;
        }
        Console.WriteLine();
        Console.Write("Sorted array is: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}