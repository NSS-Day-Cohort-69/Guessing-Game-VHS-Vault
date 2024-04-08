//write a readline that takes an integer between 1 and 100, if not we prompt again
//with a while loop wrap in a function called get guess

int secretNumber = 69;

void Main()
{
    Console.WriteLine("Welcome to Guessing Game!!!!!!!!!!!!!!!!");
    Console.WriteLine("Guess the number between 1 and 100");

    for (int i = 1; i <= 4; i++)
    {
        int userGuess = GetGuess(i);
        if (DisplayMessageForSecretNumber(userGuess))
        {
            break;
        }
    }
}

int GetGuess(int numberOfGuesses)
{
    int guess = 0;
    while (guess == 0)
    {
        Console.Write($"Guess {numberOfGuesses}: ");
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

bool DisplayMessageForSecretNumber(int guess)
{
    if (secretNumber == guess)
    {
        Console.Beep();
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.WriteLine(
            "you did it! good job! you knew what the number was!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"
        );
        return true;
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.WriteLine("oh my god how did you not know. you are so dumb");
        return false;
    }
}

Main();
