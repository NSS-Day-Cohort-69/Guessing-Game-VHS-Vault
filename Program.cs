

//write a readline that takes an integer between 1 and 100, if not we prompt again 
//with a while loop wrap in a function called get guess 

void Main()
{
    int secretNumber = 69;

    Console.WriteLine("Welcome to Guessing Game!!!!!!!!!!!!!!!!");
    int userGuess = GetGuess();

    

}

int GetGuess()
{
    int guess = 0;
    while (guess == 0)
    {
        Console.WriteLine("Please enter a number between 1 and 100");
        try
        {
            guess = int.Parse(Console.ReadLine().Trim());

        }
        catch
        {
            Console.WriteLine("NOT A NUMBER YALL");
            continue;
        }

        if (!(guess >= 1 && guess <= 100))
        {
            Console.WriteLine("BRUH directions....");
            guess = 0;
        }

    }
    return guess;

}

void SuccessEvaluation()
{
    
}

Main();