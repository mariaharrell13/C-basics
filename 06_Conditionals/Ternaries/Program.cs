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
