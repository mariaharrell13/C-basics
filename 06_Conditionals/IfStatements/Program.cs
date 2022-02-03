bool isSnowing = true;
bool isGoingOutside = true;

if (isSnowing)
{
    Console.WriteLine("It's snowing out!");
}

// Is snowing And is going outside
if (isSnowing && isGoingOutside)
{
    Console.WriteLine("Better bring and umbrella!");
}

// Not raining OR not going outside
if (!isSnowing || !isGoingOutside)
{
    Console.WriteLine("I do not need an umbrella.");
}

// Exclusively not raining OR going outside
if (isSnowing ^ isGoingOutside)
{
    Console.WriteLine("I will only go outside if it is not snowing.");
}

//If else example based on the one condition, isGoingOutside
if (isGoingOutside)
{
    Console.WriteLine("Make sure to dress for the weather!");
}
else
{
    Console.WriteLine("Sounds like a sweats kind of day.");
}

// IF ELSE IF Exercise
Console.WriteLine("How are you feeling today on a scale of 1-5?");
string feelingRating = Console.ReadLine();

if (feelingRating == "5")
{
    Console.WriteLine("That's great to hear!");
}
else if (feelingRating == "4")
{
    Console.WriteLine("Good stuff!");
}
else if (feelingRating == "3")
{
    Console.WriteLine("Hope things improve!");
}
else if (feelingRating == "2")
{
    Console.WriteLine("Oh. Sorry to hear that.");
}
else if (feelingRating == "1")
{
    Console.WriteLine("Dang. We hope your day gets better!");
}
else
{
    Console.WriteLine("Sorry, we don't understand. Please try again later.");
}