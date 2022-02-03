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