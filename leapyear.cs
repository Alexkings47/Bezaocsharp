

using System;

public class secretNumber
{
    public static void Main(string[] args)
    {
int year = 2022;
int count =20;
while (count > 0){
 if( (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0 && year % 100 == 0 )){
    Console.WriteLine(year);
    year++;
    count--;
}   
else{
    year++;
}
}
 }
}