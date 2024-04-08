//write a readline that takes an integer between 1 and 100, if not we prompt again
//with a while loop wrap in a function called get guess

int secretNumber = 69;

void Main()
{
    Console.WriteLine("Welcome to Guessing Game!!!!!!!!!!!!!!!!");

    for (int i = 0; i < 4; i++)
    {
        if (PlayGame()) break;
    }
}

bool PlayGame()
{
    int userGuess = GetGuess();
    return DisplayMessageForSecretNumber(userGuess);
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
