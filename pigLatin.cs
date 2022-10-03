// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
 Console.WriteLine("Type in a sentence to convert from English to pigLatin and back:");
 string userInput = Console.ReadLine ();
  string [] wordArray = userInput.Split(' ');
  string pigLatin = "";
  string newEnglish = "";


for(int i= 0; i< wordArray.Length; i++){
            string word = wordArray[i];
            if (i == (wordArray.Length -1)){
            pigLatin += word.Substring(1) + word[0] + "ay.";
            }else{
            pigLatin += word.Substring(1) + word[0] + "ay ";
            }
    }

string [] pigLatinArr = pigLatin.Split(' ');
for(int i= 0; i < pigLatinArr.Length; i++){
        string word = pigLatinArr[i];
        if (i == (pigLatinArr.Length -1)){
        newEnglish += word[word.Length -4] + word.Substring(0,word.Length -4 )  + ".";
        }else{
        newEnglish += word[word.Length -3] + word.Substring(0,word.Length -3) + " ";
        }
     }       
    Console.WriteLine($"{pigLatin}");
    Console.WriteLine($"{newEnglish}");  
    }
}