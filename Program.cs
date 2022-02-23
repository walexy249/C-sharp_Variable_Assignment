using System;
using System.Collections.Generic;
using System.IO;
class Solution {
 static void Main(String[] args) {
 int i = 4;
 double d = 4.0;
 string s = "Polyilaro ";


// Declare second integer, double, and String variables.

int intValue;
double doubleValue;
string stringValue;
 // Read and save an integer, double, and String to your variables.

Console.WriteLine("Enter a integer value");
 intValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a decimal value");
 doubleValue = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter a string value");
 stringValue = Console.ReadLine();


// Print the sum of both integer variables on a new line.
Console.WriteLine(i + intValue);

 // Print the sum of the double variables on a new line.
 Console.WriteLine(d  + doubleValue);

 // Concatenate and print the String variables on a new line
 // The 's' variable above should be printed first.
 Console.WriteLine(s + stringValue);
}
}

