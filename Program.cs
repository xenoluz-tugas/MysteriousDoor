string secretCode = "somethingsomething";
string attempt = "";
int attemptCount = 0;


while (attempt != secretCode)
{
    if (attemptCount >= 3)
    {
        Console.WriteLine("Too many attempt, try again after next 60 minutes.");
        return;
    }
    
    Console.Write("Pass the secret code: ");
    attempt = Console.ReadLine();

    if (attempt != secretCode)
    {
        Console.WriteLine("The secret code is wrong! Try again..");
        
    }

    attemptCount++;

}

Console.WriteLine("The secret code is right! Enter the door? (Y/n)");