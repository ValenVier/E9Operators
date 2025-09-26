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
Console.WriteLine("Give me a number in seconds:");

if (int.TryParse(Console.ReadLine(), out int secondsTotal))
{
    double secondsTotalFloat = (double)secondsTotal;
    int minutesTotal = secondsTotal / 60;
    int hoursTotal = minutesTotal / 60;
    int daysTotal = hoursTotal / 24;

    Console.WriteLine($"Seconds: {secondsTotal % minutesTotal}");
    Console.WriteLine($"Minutes: {minutesTotal % hoursTotal}");
    Console.WriteLine($"Hours: {hoursTotal - (daysTotal * 24)}");
    Console.WriteLine($"Days: {daysTotal}");
    Console.WriteLine(
        $"{daysTotal}.{hoursTotal - (daysTotal * 24)}:{minutesTotal % hoursTotal}:{secondsTotal % minutesTotal}");
    Console.WriteLine($"In total that's: {secondsTotalFloat / (60 * 60 * 24)} Days");
}
else
{
    Console.WriteLine("Write a number (int) please!");
}