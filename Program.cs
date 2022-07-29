Console.Write("\nWelcome to the program\n");
menu();


void menu()
{
    Console.Write("\nWhat operation do you desire to do?\n");
    Console.WriteLine("a: Addition of two numbers");
    Console.WriteLine("b: Subtraction of two numbers");
    Console.WriteLine("c: Multiplication of two numbers");
    Console.WriteLine("d: Division of two numbers");
    Console.WriteLine("e: Exit the program\n");
    string selection = Console.ReadLine() ?? "";

    if (selection == "a")
    {
        addition();
    }
    else if (selection == "b")
    {
        subtraction();
    }
     else if (selection == "c")
    {
        multiplication();
    }
     else if (selection == "d")
    {
        division();
    }
     else if (selection == "e")
    {
        exit();
    }
    else
    {
        Console.WriteLine("Incorrect option, try again");
    }
    menu();
}

void addition()
{
    Console.Write("\nInsert the first  number to the addition:");
    int firstNumber = Int32.Parse (Console.ReadLine() ?? "0");

    Console.Write("Insert the second number to the addition:");
    int secondNumber = Int32.Parse (Console.ReadLine() ?? "0");
    
    Console.Write("Result:");
    int addResult = firstNumber + secondNumber;
    Console.Write(addResult + "\n");
}

void subtraction()
{
    Console.Write("\nInsert the first  number to the subtraction:");
    int firstNumber = Int32.Parse (Console.ReadLine() ?? "0");

    Console.Write("Insert the second number to the subtraction:");
    int secondNumber = Int32.Parse (Console.ReadLine() ?? "0");
    
    Console.Write("Result:");
    int addResult = firstNumber - secondNumber;
    Console.Write(addResult + "\n");
}

void multiplication()
{
    Console.Write("\nInsert the first  number to the multiplication:");
    int firstNumber = Int32.Parse (Console.ReadLine() ?? "0");

    Console.Write("Insert the second number to the multiplication:");
    int secondNumber = Int32.Parse (Console.ReadLine() ?? "0");
    
    Console.Write("Result:");
    int addResult = firstNumber * secondNumber;
    Console.Write(addResult + "\n");
}

void division()
{
    Console.Write("\nInsert the first  number to the division:");
    int firstNumber = Int32.Parse (Console.ReadLine() ?? "0");

    Console.Write("Insert the second number to the division:");
    int secondNumber = Int32.Parse (Console.ReadLine() ?? "0");
    
    Console.Write("Result:");
    int addResult = firstNumber / secondNumber;
    Console.Write(addResult + "\n");
}

void exit()
{
    Console.Write("\nProgram ended, thank you for the use.");
    Environment.Exit(0);

}