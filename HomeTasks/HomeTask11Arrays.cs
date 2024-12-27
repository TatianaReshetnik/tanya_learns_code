namespace HomeTasks;
// Create two arrays of 5 numbers each. Display the arrays on the console in two separate lines.
// Calculate the arithmetic mean of the elements of each array
// and indicate which of the arrays has a greater average value (or indicate that their arithmetic means are equal).

public class HomeTask11Arrays : IBaseHomeTask
{
    public void Run()
    {
        int[] array1 = new int [5] { 1, 2, 3, 4, 5 };
        int[] array2 = new int[5] { 6, 7, 8, 9, 10 };
        Console.WriteLine("Your array 1: " + string.Join(", ", array1));
        Console.WriteLine("Your array 2: " + string.Join(", ", array2));

        int sum1 = 0;
        for (int i = 0; i < array1.Length; i++) {
            sum1 += array1[i];
        }
        double avg1 = (double)sum1 / array1.Length;
        Console.WriteLine("Average of array 1 is " + avg1);

        int sum2 = 0;
        for (int i = 0; i < array2.Length; i++) {
            sum2 += array2[i];
        }
        double avg2 = (double)sum2 / array2.Length;
        Console.WriteLine("Average of array 2 is " + avg2);
        
        if (avg1 > avg2)
            Console.WriteLine("Average of array 1 is bigger than the array 2.");
        else if (avg1 < avg2) 
            Console.WriteLine("Average of array 2 is bigger than the array 1.");
        else if (avg2 == avg1)
            Console.WriteLine("Average of array 1 is equal to the array 2.");
    }
}