/* Write a program that asks the user to enter a number.
 * Compute the factorial of the number and print it on the console.
 Example: If the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1
          and display it as 5! = 120 */

Console.WriteLine("Please enter a number to get its factorial:");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = CalculateFactorial(number);
Console.WriteLine(number + "! = " + factorial);

int CalculateFactorial(int number)
{
    int factorial = 1;
    for (int i = number; i > 0; i--)
        factorial *= i;
    return factorial;
}