// See https://aka.ms/new-console-template for more information

/*
 * Convert 123456 seconds into days, hours, minutes and seconds, and print each.
 * Format and display as D.H:M:S.
 * Calculate the total amount of days it is and display it as a fraction, i.e. 1.23456 days.
 * Hint: You need the division and the remainder of the division to calculate days, hours, minutes and seconds.

Create a console project called E9Operators
Solve the mathematical problem using code and display the result as per the goal
Ask the user for amount of seconds
Simplify the time:
Calculate how many days, hours, minutes and seconds the time contains
Print each part of the time
Then print all components together in the format: D.H:M:S
Then print how many days this is as a fraction in total

 */

Console.WriteLine("E9Operators!");

askNumber:
Console.WriteLine("Give me a number in seconds (0 to exit):");
if (int.TryParse(Console.ReadLine(), out int secondsTotal))
{
    if (secondsTotal == 0)
        goto endProgram;

    double secondsTotalFloat = (double)secondsTotal;
    int minutesTotal = secondsTotal / 60;
    int hoursTotal = minutesTotal / 60;
    int daysTotal = hoursTotal / 24;

    //When divided by zero (lower numbers), it gives an exception error. Solution:
    secondsTotal = (minutesTotal == 0) ? secondsTotal : (secondsTotal % minutesTotal);
    minutesTotal = (hoursTotal == 0) ? minutesTotal : (minutesTotal % hoursTotal);
    hoursTotal = (daysTotal == 0) ? hoursTotal : (hoursTotal - (daysTotal * 24));


    Console.WriteLine($"Seconds: {secondsTotal}");
    Console.WriteLine($"Minutes: {minutesTotal}");
    Console.WriteLine($"Hours: {hoursTotal}");
    Console.WriteLine($"Days: {daysTotal}");
    Console.WriteLine($"{daysTotal}.{hoursTotal}:{minutesTotal}:{secondsTotal}");
    Console.WriteLine($"In total that's: {secondsTotalFloat / (60 * 60 * 24)} Days");

    goto askNumber;
}
else
{
    Console.WriteLine("Write a number (int) please!");
}

endProgram:
Console.WriteLine("Goodbye!");