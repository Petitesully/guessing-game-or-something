Console.Clear();

Random random = new Random();

int correctGuess = random.Next(1,10);

Console.WriteLine("Welcome to our guessing game, choose a number between 1 and 10");

int guess = 0;

while(guess != correctGuess)
{
    Console.Write("Enter your guess");

    guess = Convert.ToInt32(Console.ReadLine());

    if(guess == correctGuess)
    {
        Console.WriteLine("Congrats!!! You Win!");
    }
    else if(guess < correctGuess)
    {
        Console.WriteLine("INCORRECT! Too Low");
    }
    else if( guess > correctGuess)
    {
        Console.WriteLine("INCORRECT! WAYYY TOO HIGH!");
    }
}
Console.WriteLine("You've won the game, GOOD JOB BUD");
