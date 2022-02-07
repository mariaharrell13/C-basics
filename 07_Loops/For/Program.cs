// Creating an initial target
int number = 100;

//  1   // 2        //3     //4
for (int i = 0; i < number; i++)
{
    // 5
    Console.WriteLine(i);
}

// 1 - for keyword
//2 - Declaration and initialization of an iterator variable
// 3 - Boolean expression comapring the new iterator to the number variable
// 4 - Incrementing the iterator at the end of each loop
// 5 - Body of the loop, runs once per iteration after the boolean is evaluated as true 
// Challenge
Console.WriteLine ("What number do you want me to count to?");
string userInput = Console.ReadLine();

int target = int.Parse(userInput);

for (int i = 0; i <= target; i++)
{
    Console.WriteLine(i);
}



int numberTwo = 200;
for (int i = 1; i <= numberTwo; i++){
    numberTwo = numberTwo - i;
    Console.WriteLine(numberTwo);
    Console.WriteLine ($"1 is {i}");
}