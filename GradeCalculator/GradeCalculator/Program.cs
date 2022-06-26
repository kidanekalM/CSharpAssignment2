// See https://aka.ms/new-console-template for more information

float grade;
String choice;
int numberOfCourses = 0;
double sum = 0;
do
{
    do
    {
        Console.WriteLine("Enter The Grade");
        grade = float.Parse(Console.ReadLine());
        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Grade must be between 0 and 100");
        }
    }
    while (grade < 0 || grade > 100);

    numberOfCourses++;

    if (grade > 90)
    {
        Console.WriteLine("A");
        sum += 4;
    }
    else if (grade > 80)
    {
        Console.WriteLine("B");
        sum += 3;
    }
    else if (grade > 70)
    {
        Console.WriteLine("C");
        sum += 2;
    }
    else if (grade > 60)
    {
        Console.WriteLine("D+");
        sum += 1.5;
    }
    else if (grade > 50)
    {
        Console.WriteLine("D");
        sum += 1;
    }
    else
    {
        Console.WriteLine("F");
        sum += 0;
    }
    double gpa = sum / numberOfCourses;
    Console.WriteLine("\n Your GPA is " + gpa);

    do
    {
        Console.WriteLine("\n Do you want to add another grade Y/N? ");
        choice = Console.ReadLine();
        if (!(choice == "y" || choice == "Y" || choice == "N" || choice == "n"))
        {
            Console.WriteLine("Please enter a valid choice! " + choice);
            Console.Beep();
        }
    }
    while (choice != "y" && choice != "Y" && choice != "N" && choice != "n");
    if (choice == "N" || choice == "n")
    {
        Console.WriteLine("Good Bye! ");
    }
    else
    {
        Console.Clear();
    }
}
while (choice == "y" || choice == "Y");