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

        for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(1, 100);
            }
// Print the array and max,min, average
            Console.WriteLine("Your array: " + string.Join(", ", array));
            Console.WriteLine("The max value is" + "max");
            Console.WriteLine("The min value is" + "min");
            Console.WriteLine("The average value is" + "average");
        }
    }
