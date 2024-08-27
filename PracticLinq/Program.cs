using System;
using System.Collections.Generic;
using System.Linq;

// List created
var randomNumbers = new List<int>();
var random = new Random();


// Generating random numbers between -30 and +30 and assigning them to the list
for (int i = 0; i < 10; i++)
{
    randomNumbers.Add(random.Next(-30,30));  
}


// Printing even numbers 
var evenNumbers = randomNumbers.Where(n => n % 2 == 0).ToList();
Console.WriteLine("Cift Sayilar: ");
Console.WriteLine(string.Join(", ", evenNumbers));

Console.WriteLine("--------------------------------------------------------------------------");


// Printing odd numbers
var oddNumbers = randomNumbers.Where(n => n % 2 != 0).ToList();
Console.WriteLine("Tek Sayilar: ");
Console.WriteLine(string.Join(", ", oddNumbers));

Console.WriteLine("--------------------------------------------------------------------------");


// Printing negative numbers
var negativeNumber = randomNumbers.Where(n => n < 0).ToList();
Console.WriteLine("Negatif Sayilar: ");
Console.WriteLine(string.Join(", ", negativeNumber));

Console.WriteLine("--------------------------------------------------------------------------");


// Printing positive numbers
var positiveNumber = randomNumbers.Where(n => n > 0).ToList();
Console.WriteLine("Pozitif Sayilar: ");
Console.WriteLine(string.Join(", ", positiveNumber));

Console.WriteLine("--------------------------------------------------------------------------");


// Printing numbers greater than 15 and less than 22
var numberBetween15And22 = randomNumbers.Where(n => n > 15 && n < 22).ToList();
Console.WriteLine("15'den buyuk 22'den kucuk sayilar : ");
Console.WriteLine(string.Join(", ", numberBetween15And22));
Console.WriteLine("--------------------------------------------------------------------------");


// The square of each number in the list
var squaredNumber = randomNumbers.Select(n =>  n * n).ToList();
Console.WriteLine("Sayilarin  Karesi: ");
Console.WriteLine(string.Join(", ", squaredNumber));