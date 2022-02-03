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