using System;

int num1 = 5;
int num2 = 10;
        
// Check if both num1 and num2 are greater than 0 using &&
bool bothPositive = (num1 > 0) && (num2 > 0);

Console.WriteLine($"Are both numbers positive? {bothPositive}");

// Are both numbers positive? True



bool isWindyDay = false;

// Use the NOT operator (!) to reverse the boolean value
bool isCloudyDay = !isWindyDay;

Console.WriteLine($"Is today a cloudy day? {isCloudyDay}");

// Is today a cloudy day? True




num1 = -5;
num2 = -10;
        
// Check if either num1 or num2 is greater than 0 using ||
bool eitherPositive = (num1 > 0) || (num2 > 0);

Console.WriteLine($"Is either number positive? {eitherPositive}");

// Is either number positive? True