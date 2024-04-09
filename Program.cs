//write a readline that takes an integer between 1 and 100, if not we prompt again
//with a while loop wrap in a function called get guess

int secretNumber = 69420;

void Main()
{
    Console.WriteLine("Welcome to Guessing Game!!!!!!!!!!!!!!!!");
    Console.WriteLine("Guess the number between 1 and 100");

    Random random = new Random();
    secretNumber = random.Next() % 100 + 1;
    Console.WriteLine($"{secretNumber}");
    int maxGuesses = SetDifficultyLevel();
    for (int i = 1; i <= maxGuesses; i++)
    {
        Console.WriteLine($"You have {maxGuesses - i + 1} {(maxGuesses - i + 1 == 1 ? "guess" : "guesses")} ");

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
    else if (guess > secretNumber)
    {
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.WriteLine("Hey dummy your guess was to high");
        return false;
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.WriteLine("Hey dummy your guess was to low");
        return false;
    }


}

//function called set DIfficulty tha prompts the user to pick a difficulty
//display menu options
// if statement to set the guesses variable based on the users choice
//return that integer

int SetDifficultyLevel()
{
    Console.WriteLine(@"Please enter THE NUMBER that corresponds with your preferred difficulty level:
    1. Easy
    2. Medium
    3. Hard");
    int userChoice = 0;
    int maxGuesses = 0;
    while (userChoice == 0)
    {
        try
        {
            userChoice = int.Parse(Console.ReadLine().Trim());
        }
        catch
        {
            Console.WriteLine("NOT A NUMBER YALL");
            continue;
        }
        if (!(userChoice >= 1 && userChoice <= 3))
        {
            Console.WriteLine("please choose a valid option");
            userChoice = 0;
        }

    }

    if (userChoice == 1)
    {
        maxGuesses = 8;
    }
    if (userChoice == 2)
    {
        maxGuesses = 6;
    }
    if (userChoice == 3)
    {
        maxGuesses = 4;
    }

    return maxGuesses;
}

Main();
