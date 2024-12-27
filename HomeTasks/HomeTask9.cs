namespace HomeTasks;
//Create an array of integers.
//Remove all occurrences of a specified number from the array.
//Let the number be entered from the console. If there is no such number, output corresponding messages.
//The result should be a new array without the specified number.
//Enter '7' as task number to start the app.
internal class HomeTask9 : IBaseHomeTask
{
    public void Run()
    {
        {
            int[] array = new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
                14, 15, 16, 17, 18, 19, 20
            };
            Console.WriteLine("Enter your number");
            int input = int.Parse(Console.ReadLine());
            List<int> myList = new List<int>(array); // converting to list because array is fixed
            int countRemoved = myList.RemoveAll(x => x == input); 
            
            // the predicate is a lambda expression: x => x == input.
            // x represents the current element being examined in the list.
            // x == input checks if the element x is equal to input. If true, that element is removed from the list.
            
            if (countRemoved > 0) {
                int[] newArray = myList.ToArray(); // converting to array
                Console.WriteLine("Updated array: " + string.Join(", ", newArray)); //just the way it should be according to print the array contents
            }
            else
                Console.WriteLine("Your number was not found in the array.");
        }
    }
}