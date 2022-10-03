// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class secretNumber
{
    public static void Main(string[] args)
    {
int tries = 0;
Random randomNumber = new Random();
int secretNumber = randomNumber.Next(1,20);


int userInput = 0;
int prevNumber = 21;
while(userInput != secretNumber)
{
    Console.WriteLine("Guess the secret number from 1 to 20: ");
    userInput = Convert.ToInt32(Console.ReadLine());
  
    while(prevNumber != userInput){
         prevNumber = userInput ;
        if(userInput == 0){
            Console.WriteLine("Invalid Selection. Have another go.");
        }
        else if(userInput == secretNumber){
            tries++;
            Console.WriteLine($"You won in {tries} tries. The Secret number is {secretNumber}");
            break;
        }else if(userInput - secretNumber > 0 ){
            tries++;
            Console.WriteLine("Your guess is too large. Try again.", prevNumber);
        }else if(userInput - secretNumber < 0 ){
            tries++;
            Console.WriteLine("Your guess is too small. Try again.", prevNumber);
        }
    }

}   
 }
}