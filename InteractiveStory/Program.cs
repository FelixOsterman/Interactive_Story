Console.WriteLine("Where are you from? ");
string name = Console.ReadLine();

if (name == "Sweden")
{
    Console.WriteLine("Good");
}
else if (name == "Norge" || name == "Finland")
{
    Console.WriteLine("Okay");

    Console.WriteLine("What do you feel about Sweden? ");
    string name2 = Console.ReadLine();

    if (name2 == "Like")
    {
        Console.WriteLine("Good");
    }
    else if (name2 == "Bad")
    {
        Console.WriteLine("Die");
    }
    else
    {
        Console.WriteLine("Uuh");
    }
}
else
{
    Console.WriteLine("...");

    Console.WriteLine("Are you shore? ");
    string name3 = Console.ReadLine();

    if (name3 == "Yes")
    {
        Console.WriteLine("Okay");
    }
    else if (name3 == "No")
    {
        Console.WriteLine("You can retake the questiens");
    }
    else
    {
        Console.WriteLine("Uuh");
    }
}

Console.ReadLine();
