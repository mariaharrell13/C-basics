string name = Console.ReadLine();
switch (name)
{
    case "Pete":
        // Code that runs if the variable name has the value of "Pete"
        break;
    default:
        // Code that runs for every every other possible value for name 
        break;
}

Console.WriteLine("How are you feeling today on a scale of 1-5?");
string feelingRating = Console.ReadLine();

switch (feelingRating)
{
    case "5": // Checks to see if feelingRating has the value of "5"
        Console.WriteLine("That's great to hear!"); // Runs if the above case matches
        break; // Ends the code that runs if the above case is met
    case "4": 
        Console.WriteLine("Good Stuff!"); 
        break; 
    case "3": 
        Console.WriteLine("Hope things improve!"); 
        break; 
    case "2": 
        Console.WriteLine("Oh. Sorry to hear that!"); 
        break; 
    case "1": 
        Console.WriteLine("Good Stuff!"); 
        break; 
    default: // This is only used if non of the other cases are matches
        Console.WriteLine("Sorry, we don't understand. Please try again later.");
        break;
}



Console.WriteLine("What is your friends name?");
string named = Console.ReadLine();

switch (named)
{
    case "Joe": // Checks to see if feelingRating has the value of "5"
        Console.WriteLine("He's a good guy!"); // Runs if the above case matches
        break; // Ends the code that runs if the above case is met
    case "Dan": 
        Console.WriteLine("He's a bad guy!"); 
        break; 
    default: // This is only used if non of the other cases are matches
        Console.WriteLine("Sorry, we don't understand. Please try again later.");
        break;
}











//-- Switch Expressions
string username = Console.ReadLine();
string greeting = username switch
{
    "Pete" => "Hello Pete", // Value that returns if the variable name has the value of "Pete"
    _ => "Who are you?" // Return Value for every other possible value for name
};

Console.WriteLine("How were your feeling yesterday on a scale of 1-5?");
string ratingInput = Console.ReadLine();
int yesterdayRating = int.Parse(ratingInput);

string response = yesterdayRating switch
{
    1 => "Dang. We hope today is a better day.",
    2 => "Oh, sorry to hear that!",
    3 => "Hopefully things will get better this week.",
    4 => "Good stuff!",
    5 => "That's great to hear!",
    _ => "That's off the charts!"
};
Console.WriteLine(response);

//-- Challenge
int todayRating = int.Parse(feelingRating);
int ratingDifference = todayRating - yesterdayRating;

string output = ratingDifference switch
{
    4 => "You have improved a ton today, that's awesome!",
    3 => "You have improved a lot. Way to go!",
    2 => "You're a bit better today.",
    1 => "At least it's improvement!",
    0 => "More of the same.",
    -1 => "Well at least it could be worse?",
    -2 => "Uh oh!",
    -3 => "That's not good to hear.",
    -4 => "Sorry to hear you're not doing great today!",
    _ => "That's out of my range of understanding."
};
Console.WriteLine(output);