using System;

void Main()
{
    Console.WriteLine("Guess the Secret Number?");
    Console.WriteLine(@"What Skill Level Do you want to play at?
    A. Easy: 8 guesses
    B. Medium: 6 guesses
    C. Hard: 4 guesses
    D. Cheater: Unlimited");
    string skillLevel = Console.ReadLine().ToLower();
    if (skillLevel == "a")
    {
        DifficultyLevel(8);
    }
    else if (skillLevel == "b")
    {
        DifficultyLevel(6);
    }
    else if (skillLevel == "c")
    {
        DifficultyLevel(4);
    }
    else if (skillLevel == "d")
    {
        DifficultyLevel(1000);
    }
    void DifficultyLevel(int skill)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        // Console.WriteLine(secretNumber);
        for (int i = 0; i < skill; i++)
        {
            Console.Write("Your guess:");
            string answer = Console.ReadLine();
            Console.WriteLine($"Guess #{i + 1}");
            if (int.Parse(answer) == secretNumber)
            {
                Console.WriteLine($"You were right! The secrect number is {secretNumber}!");
                return;
            }
            else if (int.Parse(answer) > secretNumber)
            {
                Console.WriteLine("Incorrect. Guess lower!");
            }
            else if (int.Parse(answer) < secretNumber)
            {
                Console.WriteLine("Incorrect. Guess higher!");
            }
        }
        Console.WriteLine("Too bad, so sad! You lose!");
    }
}

Main();
