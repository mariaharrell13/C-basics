string instructorName = "Amanda";
string[] instructors = new string[] { "Michael", "Joshua", instructorName };
// [] = array
// List string
// $ = interpolation
// foreach(declaredIterator in enumerableCollection){body}

foreach (string name in instructors)
{
    Console.WriteLine($"Hello {name}");
}

foreach (char letter in instructorName){
    Console.WriteLine(letter);
}

//Challenge
int [] numbers = new int[] { 1, 5, 10, -4, 12, 0 }; // <declared a new group of integers

foreach (int number in numbers)   // iterating over the group for each loop
{
    if (number > 0)
    {
        Console.WriteLine($"{number} is a positive number."); // console stating whether the numbers are positive or negative
    }
    else if (number <0)
    {
        Console.WriteLine($"{number} is a negative number.");
    }
    else
    {
        Console.WriteLine($"{number} is a neutral number.");
    }
}