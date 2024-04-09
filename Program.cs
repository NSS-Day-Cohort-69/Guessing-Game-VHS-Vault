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
    for (int i = 1; i != maxGuesses + 1; i++)
    {
        Console.WriteLine(
            maxGuesses == -1
                ? "You have infinite guesses."
                : $"You have {maxGuesses - i + 1} {(maxGuesses - i + 1 == 1 ? "guess" : "guesses")} "
        );

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
        guess = GetIntChoice();

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
        Console.WriteLine("Hey dummy your guess was too high");
        return false;
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.WriteLine("Hey dummy your guess was too low");
        return false;
    }
}

int GetIntChoice()
{
    int userChoice = 0;
    try
    {
        userChoice = int.Parse(Console.ReadLine().Trim());
    }
    catch
    {
        Console.WriteLine("NOT A NUMBER YALL");
    }
    return userChoice;
}

//function called set DIfficulty tha prompts the user to pick a difficulty
//display menu options
// if statement to set the guesses variable based on the users choice
//return that integer

int SetDifficultyLevel()
{
    Console.WriteLine(
        @"Please enter THE NUMBER that corresponds with your preferred difficulty level:
    1. Easy
    2. Medium
    3. Hard
    4. Cheater"
    );

    int userChoice = 0;
    int maxGuesses = 0;
    while (userChoice == 0)
    {
        userChoice = GetIntChoice();
        if (!(userChoice >= 1 && userChoice <= 4))
        {
            Console.WriteLine("please choose a valid option");
            userChoice = 0;
        }
    }

    switch (userChoice)
    {
        case 1:
            maxGuesses = 8;
            break;
        case 2:
            maxGuesses = 6;
            break;
        case 3:
            maxGuesses = 4;
            break;
        case 4:
            maxGuesses = -1;
            break;
    }

    return maxGuesses;
}

Main();
