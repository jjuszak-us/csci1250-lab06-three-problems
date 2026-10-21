/*
* Name: Joseph Juszak
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

//A simple menu offering the programs choices.
System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. The Grade Checker ");
System.Console.WriteLine("2. The Dice Table ");
System.Console.WriteLine("3. The Score Report ");
System.Console.WriteLine("4. All three ");
System.Console.WriteLine("5. Quit ");
System.Console.WriteLine("Please choose 1-5 ");


int choice = Convert.ToInt32(Console.ReadLine());

if(choice == 1 || choice == 4)
{
    System.Console.WriteLine("=== Exercie 1: The Grade Checker ===");
    System.Console.WriteLine("Please give me your grade value between 0 and 100 ");
    int grade = Convert.ToInt32(Console.ReadLine());
    if(grade <= 59)
    {
        System.Console.WriteLine($"{grade} is an F ");
    }
    if(grade <= 69 )
    {
        System.Console.WriteLine($"{grade} is a D ");
    }
    if(grade <= 79)
    {
        System.Console.WriteLine($"{grade} is an C ");
    }
    if(grade <= 89)
    {
        System.Console.WriteLine($"{grade} is a B ");
    }
    if(grade <= 100)
    {
        System.Console.WriteLine($"{grade} is an A ");
    }
}
if(choice == 2 || choice == 4)
{
    System.Console.WriteLine("2");
}
if(choice == 3 || choice == 4)
{
    System.Console.WriteLine("3");
}
else
{
    System.Console.WriteLine("The choice you entered is invalid. Please choose a valid number. ");
    System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
    System.Console.WriteLine("1. The Grade Checker ");
    System.Console.WriteLine("2. The Dice Table ");
    System.Console.WriteLine("3. The Score Report ");
    System.Console.WriteLine("4. All three ");
    System.Console.WriteLine("5. Quit ");
}

