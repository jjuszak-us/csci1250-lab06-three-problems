/*
* Name: Joseph Juszak
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

Random rng = new Random(4000);
int choice = 0;

// do loop to keep the user reverting back to the main menu after program execution
do
{
//A simple menu offering the programs choices.
printMenu();

choice = Convert.ToInt32(Console.ReadLine());
//if statement to prevent invalid entries
if(choice > 5 || choice < 1);
    {
        System.Console.WriteLine("Please choose a valid number");
    }
//if statement for the grade checker
if(choice == 1 || choice == 4)
{
    System.Console.WriteLine("=== Exercie 1: The Grade Checker ===");
    System.Console.WriteLine("Please give me your grade value between 0 and 100 ");
    int grade = Convert.ToInt32(Console.ReadLine());
    if(grade <= 59)
    {
        System.Console.WriteLine($"{grade} is an F ");
    }
    else if(grade <= 69 )
    {
        System.Console.WriteLine($"{grade} is a D ");
    }
    else if(grade <= 79)
    {
        System.Console.WriteLine($"{grade} is a C ");
    }
    else if(grade <= 89)
    {
        System.Console.WriteLine($"{grade} is a B ");
    }
    else if(grade <= 100)
    {
        System.Console.WriteLine($"{grade} is an A ");
    }
}
//if statement for the dice game
if(choice == 2 || choice == 4)
{
    System.Console.WriteLine("=== Exercise 2: The Dice Table ===" );
    char diceUserChoice; 
    int rollcount = 0;
    int wincount = 0;
    do
    {
    rollcount++;
    int rand1 = rng.Next(1,7);
    int rand2 = rng.Next(1,7);
    int total = rand1 + rand2;

    if(rand1 == 1 && rand2 == 1)
    {
      System.Console.WriteLine($"Roll {rollcount}: {rand1} and {rand2}, total {total}. Snake Eyes. ");  
    }
    
    else if(rand1 == rand2 && rand1 != 1)
    {
      System.Console.WriteLine($"Roll {rollcount}: {rand1} and {rand2}, total {total}. Doubles! ");  
    }

    else if(rand1 + rand2 == 7 || rand1 + rand2 == 11)
    {
      System.Console.WriteLine($"Roll {rollcount}: {rand1} and {rand2}, total {total}. A winner. "); 
      wincount++; 
    }

    else
    {
    System.Console.WriteLine($"Roll {rollcount}: {rand1} and {rand2}, total {total} ");
    }

    System.Console.WriteLine("Roll again? (y/n)");
    diceUserChoice = Convert.ToChar(Console.ReadLine().Trim().ToLower());

    } while (diceUserChoice == 'y');
    System.Console.WriteLine($"You rolled {rollcount} time and won {wincount}");
}
//if statement for the score report
if(choice == 3 || choice == 4)
{
    System.Console.WriteLine("=== Exercise 3: The Score Report ===");
    System.Console.WriteLine("This is a calculator for some statistics on your grades. You will need to enter 5 scores.");
    int[] scores = new int[5];
    //for loop for grade inputs
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
    //foreach loop for counts
    foreach(int score in scores)
    {
        if(score >= passing)
        {
            count ++;
        }
    }
    System.Console.WriteLine("=== Exercise 3: The Score Report ===");
    //for loop to print out scores with incrementation
    for(int i = 0; i < scores.Length; i++)
    {
        System.Console.WriteLine($"Score {i+1}: {scores[i]}");
    }
    System.Console.WriteLine($"Scores entered: {scores.Length}");
    System.Console.WriteLine($"Total: {total}");
    System.Console.WriteLine($"Average: {average}");
    System.Console.WriteLine($"Highest: {max}");
    System.Console.WriteLine($"Passing: {count} out of {scores.Length} ");
}
}
while(choice != 5);
System.Console.WriteLine("Goodbye ");




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

