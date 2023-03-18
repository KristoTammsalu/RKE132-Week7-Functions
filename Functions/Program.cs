Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();


if(userChoice == "in")
{
    PrintHello();
}
else
{
    printGoodBye();
}





static void PrintHello() //function/ method
{
    Console.WriteLine("Hello world!");
}

static void printGoodBye()
{
    Console.WriteLine("See you later, alligator.");
}
