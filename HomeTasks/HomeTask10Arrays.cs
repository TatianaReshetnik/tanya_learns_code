namespace HomeTasks;
//Create and fill an array with random numbers, then output the maximum, minimum, and average values.
//Use the Random() method for generating random numbers. Allow the user to create an array of arbitrary size.
//Let the size of the array be entered from the console.

internal class HomeTask10Arrays : IBaseHomeTask
{
    public void Run()
    {
        Random rand = new Random();
        Console.Write("How many elements do you want in your array? ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        for (int i = 0; i < length; i++) {
            array[i] = rand.Next(1, 100);
        }

        int max = array[0];
        for (int i = 1; i < array.Length; i++) {
            if (array[i] > max) {
                max = array[i];
            }
        }

        int min = array[0];
        for (int i = 1; i < array.Length; i++) {
            if (array[i] < min) {
                min = array[i];
            }
        }

        // 5. Find sum, then average
        int sum = 0;
        for (int i = 0; i < array.Length; i++) {
            sum += array[i];
        }
        // Use (double) to avoid integer division
        double avg = (double)sum / array.Length;


// Print the array and max,min, average
        Console.WriteLine("Your array: " + string.Join(", ", array));
        Console.WriteLine("The max value is " + max);
        Console.WriteLine("The min value is " + min);
        Console.WriteLine("The average is " + avg);

    }
}