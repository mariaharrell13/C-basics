// Here we're using Write instead of WriteLine
Console.Write("Enter your age: ");
string response = System.Console.ReadLine();
int age = int.Parse(response);

// 1        // 2     // 3             // 4
string output = age >=18 ? "you can vote!" : "You're too young to vote.";

// 1 - Variable to hold returned value
// 2 - Boolean expression to be evaluated
// 3 - Value to be returned if 2 is true
// 4 - Value to be returned if 2 is false

Console.WriteLine(output);


//Challenge if else statement
Console.WriteLine("Are you too young to vote?");
string moreInfo = Console.ReadLine();

if (moreInfo == "yes")
{
    Console.WriteLine("You can vote when you turn 18 and register to vote!");
}
else if (moreInfo == "no")
{
    Console.WriteLine("Be sure to registar to vote!");
}
if (moreInfo == "Yes")
{
    Console.WriteLine("You can vote when you turn 18 and register to vote!");
}
else if (moreInfo == "No")
{
    Console.WriteLine("Be sure to registar to vote!");
}
else
{
    Console.WriteLine("Sorry, we don't understand. Please try again later.");
}