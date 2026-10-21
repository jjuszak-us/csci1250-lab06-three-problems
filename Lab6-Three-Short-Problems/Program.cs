/*
* Name: Joseph Juszak
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

// Random rng = new Random(4000);
// int choice = 0;



// //A simple menu offering the programs choices.
// printMenu();


// int choice = Convert.ToInt32(Console.ReadLine());

// if(choice == 1 || choice == 4)
// {
//     System.Console.WriteLine("=== Exercie 1: The Grade Checker ===");
//     System.Console.WriteLine("Please give me your grade value between 0 and 100 ");
//     int grade = Convert.ToInt32(Console.ReadLine());
//     if(grade <= 59)
//     {
//         System.Console.WriteLine($"{grade} is an F ");
//     }
//     if(grade <= 69 )
//     {
//         System.Console.WriteLine($"{grade} is a D ");
//     }
//     if(grade <= 79)
//     {
//         System.Console.WriteLine($"{grade} is an C ");
//     }
//     if(grade <= 89)
//     {
//         System.Console.WriteLine($"{grade} is a B ");
//     }
//     if(grade <= 100)
//     {
//         System.Console.WriteLine($"{grade} is an A ");
//     }
// }
// if(choice == 2 || choice == 4)
// {
    System.Console.WriteLine("=== Exercise 3: The Score Report ===");
    System.Console.WriteLine("This is a calculator for some statistics on your grades. You will need to enter 5 scores.");
    int[] scores = new int[5];

    for(int i = 0; i < scores.Length; i++)
    {
        System.Console.WriteLine($"Please enter the score for score {i+1}");
        scores[i] = Convert.ToInt32(Console.ReadLine());
    }

    int total = scores.Sum();
    double average = (Convert.ToDouble(total) / scores.Length);
    int max = scores.Max();
    int passing = 60;
    int count = 0;
    foreach(int score in scores)
    {
        if(score >= passing)
        {
            
            count ++;
        }
    }
    System.Console.WriteLine("=== Exercise 3: The Score Report ===");
    for(int i = 0; i < scores.Length; i++)
    {
        System.Console.WriteLine($"Score {i+1}: {scores[i]}");
    }
    System.Console.WriteLine($"Scores entered: {scores.Length}");
    System.Console.WriteLine($"Total: {total}");
    System.Console.WriteLine($"Average: {average}");
    System.Console.WriteLine($"Highest: {max}");
    System.Console.WriteLine($"Passing: {count} out of {scores.Length} ");
// }

// if(choice == 3 || choice == 4)
// {
//     System.Console.WriteLine("3");
// }
// else
// {
//     printMenu();
// }













// a method for printing the program menu
static void printMenu()
{
    System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
    System.Console.WriteLine("1. The Grade Checker ");
    System.Console.WriteLine("2. The Dice Table ");
    System.Console.WriteLine("3. The Score Report ");
    System.Console.WriteLine("4. All three ");
    System.Console.WriteLine("5. Quit ");
    System.Console.WriteLine("Please choose 1-5 ");
}