// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); // main function to display greeting

//write a readline that takes an integer between 1 and 100, if not we prompt again 
//with a while loop wrap in a function called get guess 

void Main()
{
    Console.WriteLine("Hello! Please pick a number between 1 and 100:");
    int userGuess = GetGuess();

    Console.WriteLine("You chose userGuess");

}

int GetGuess()
{
    int guess = 0;
    while (guess == 0)
    {
        Console.WriteLine("Please enter a number bewtween 1 and 100");
        try
        {
            guess = int.Parse(Console.ReadLine().Trim());

        }
        catch
        {
            Console.WriteLine("NOT A NUMBER YALL");
        }

        if (!(guess >= 1 && guess <= 100))
        {
            Console.WriteLine("BRUH directions....");
            guess = 0;
        }

    }
    return guess;

}