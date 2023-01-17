string[] student = { "Wilfredo Pacheco", "Justin Jones", "Earle Fox", "Ethan Thomas", "Mourad Alfadil", "Belle Baxley", "Jason Garrison", "Cam Dixon", "Josh Strathres" };
string[] hometown = { "Canton", "Columbus", "Saline", "Urbana", "Detroit", "Haleiwa", "Chelsea", "South Lyon", "Oxford" };
string[] food = { "Quesadilla", "Baja Blast", "Pizza", "Hot Wings", "Fried Rice", "French Fries", "Chewing Tobacco", "Coney Dogs", "Pizza" };

Console.WriteLine("Welcome! Which student would you like to learn more about? Enter a number 1-9:");
bool restart = true;
do
{
    int studentCount = 1;
    foreach (string s in student)
    {
        Console.WriteLine($"{studentCount} {s}");
        studentCount++;
    }
    bool restart1 = true;
    int info = 0;
    while (restart1)
    {
        info = (int.Parse(Console.ReadLine()) - 1);
        if (info > -1 && info < 9)
        {
            restart1 = false;
        }
        else
        {
            restart1 = true;
            Console.Write("Incorrect number entered. Please enter another number: ");
        }
    }
    
    Console.Write($"Student {info + 1} is {student[info]}. What would you like to know? Enter hometown/favorite food or both: ");
    bool restart2 = true;
    while (restart2)
    {
        string moreInfo = Console.ReadLine().ToLower();
        if (moreInfo == "hometown" || moreInfo == "home" || moreInfo == "h")
        {
            Console.WriteLine($"{student[info]} is from {hometown[info]}.");
            break;
        }
        else if (moreInfo == "favorite food" || moreInfo == "food" || moreInfo == "f")
        {
            Console.WriteLine($"{student[info]}'s favorite food is {food[info]}.");
            break;
        }
        else if (moreInfo == "both")
        {
            Console.WriteLine($"{student[info]} is from {hometown[info]} and their favorite food is {food[info]}.");
            break;
        }
        else
        {
            Console.Write("That category does not exist. Please try again. Enter hometown/favorite food: ");
            restart2 = true;
        }
    }
    Console.Write("Would you like to learn about another student? Enter y/n: ");
    string input = Console.ReadLine().ToLower();
    if (input == "yes" || input == "y")
    {
        restart = true;
    }
    else
    {
        restart = false;
    }
} while (restart);
Console.WriteLine("Thank you and goodbye!");