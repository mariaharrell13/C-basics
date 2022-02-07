// Challenge 1
int ageOfMaria = 27;
string color = "blue";
DateTime today = DateTime.Now;
bool isHappy = true;

//Challenge 2
int ageOfJon = 28;
Console.WriteLine(ageOfJon-ageOfMaria);

//Challenge 3
Console.WriteLine("What is your favorite food?");
String userinput = Console.ReadLine();
Console.WriteLine(userinput+" will be on the menu!");

//Challenge 4
Console.WriteLine("Are you wearing clothes?");
string answer = Console.ReadLine();

switch (answer.ToUpper())
{
    case "YES": // Checks to see if feelingRating has the value of "5"
        Console.WriteLine("It's getting hot in here..."); // Runs if the above case matches
        break; // Ends the code that runs if the above case is met
    case "NO": 
        Console.WriteLine("Go put some clothes on!"); 
        break; 
    default: // This is only used if non of the other cases are matches
        Console.WriteLine("Sorry, we don't understand. Please try again later.");
        break;
}

//Challenge 5!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
Console.WriteLine("On a scale of 1-5, how much do you like your outfit?");
int ratingInput = int.Parse(Console.ReadLine());

string response = ratingInput switch
{
    1 => "dang that sucks.",
    2 => "yeh, I was too busy to care this morning too.",
    3 => "I feel that.",
    4 => "I really like it, what do you think is missing?",
    5 => "I love it too!",
    _ => "does not compute!"
};
Console.WriteLine(response);

//Challenge 6
Console.WriteLine("Where would you like to eat? \n 1. McDonalds \n 2. Burger King \n 3. Wendy's \n 4. Chick-fil-a");
int restaurantInput = int.Parse(Console.ReadLine());

string foodResponse = restaurantInput switch
{
    1 => "I'm lovin it.",
    2 => "Have it your way.",
    3 => "You know when it's real.",
    4 => "Eat Mor Chikin",
    _ => "does not compute!"
};
Console.WriteLine(foodResponse);

//Challenge 7
Console.WriteLine("Are you happy? (y/n)");
string isHappyResponse = Console.ReadLine ();

if (isHappyResponse == "y") 
{
    Console.WriteLine("That's great!");
}
else if (isHappyResponse == "n")
{
    Console.WriteLine("I hope that frown turns upside down!");
}
else 
{
    Console.WriteLine("Not a valid response");
}
