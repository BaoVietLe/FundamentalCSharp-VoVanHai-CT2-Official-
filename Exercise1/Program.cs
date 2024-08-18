#region Plus (1)
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Transactions;

int DuLieuSo1;
    string EpKieuSo1;
    string EpKieuSo2;
    int DuLieuSo2;
    Console.WriteLine("Hello World!");
    Console.WriteLine("Please entry your first nmber which will be used to conduct a plus math");
    EpKieuSo1= Console.ReadLine();
    DuLieuSo1 = int.Parse(EpKieuSo1);
    Console.WriteLine("Please entry your second one");
    EpKieuSo2 = Console.ReadLine();
    DuLieuSo2 = int.Parse(EpKieuSo2);
    Console.WriteLine("Before conducting, please ensure that the two numbers you typed is {0},{1}? Is that right?",DuLieuSo1,DuLieuSo2);
Console.WriteLine("Processing...Please wait");
Console.WriteLine("The outcome of the plus math: {0} + {1} = {2}", DuLieuSo1, DuLieuSo2, DuLieuSo1 + DuLieuSo2);
#endregion
#region SwapValue (2)
Console.WriteLine("Hello! Welcome to the next part: Swatching Value");
Console.WriteLine("Before swatchinging, please ensure that the two numbers you typed in particular order: first number: {0}, second number: {1}? Is that right?", DuLieuSo1, DuLieuSo2);
(DuLieuSo1, DuLieuSo2) = (DuLieuSo2, DuLieuSo1);
Console.WriteLine("Now enjoy!");
Console.WriteLine("First number: {0}",DuLieuSo1);
Console.WriteLine("Second number: {0}", DuLieuSo2);
#endregion

#region MultiplyFloating (3)
float DuLieuSo3;
string EpKieuSo3;
string EpKieuSo4;
float DuLieuSo4;
Console.WriteLine("Now switching to the part of multiplying the float number");
Console.WriteLine("Please entry your first nmber which will be used to conduct a multiply math");
EpKieuSo3 = Console.ReadLine();
DuLieuSo3 = float.Parse(EpKieuSo3);
Console.WriteLine("Please entry your second one");
EpKieuSo4 = Console.ReadLine();
DuLieuSo4 = float.Parse(EpKieuSo4);
Console.WriteLine("Before conducting, please ensure that the two numbers you typed is {0},{1}? Is that right?", DuLieuSo3, DuLieuSo4);
Console.WriteLine("Processing...Please wait");
Console.WriteLine("The outcome of the plus math: {0} * {1} = {2}", DuLieuSo3, DuLieuSo4, DuLieuSo3 * DuLieuSo4);
#endregion
#region feettomet (4)
double DuLieuFeet;
double DuLieuMet;
string EpFeet;
Console.WriteLine("Entry your feet measure to convert");
    EpFeet = Console.ReadLine();
DuLieuFeet = double.Parse(EpFeet);
Console.WriteLine("{0} feets = {1} meters", DuLieuFeet,DuLieuMet=DuLieuFeet/3.281d);
#endregion

#region CelsiusFah (5)
        Console.Write("Enter the amount of Celsius: "); 
        int celsius1 = Convert.ToInt32(Console.ReadLine());
        int Fahrenheit = celsius1 * 18 / 10 + 32;
        int celsius2 = Fahrenheit - 32 /(18/10)/celsius1;
        Console.WriteLine("Fahrenheit = {0}",Fahrenheit);
        Console.WriteLine("Back to Celsius = {0}",celsius2);
#endregion

#region DataType (6)
Console.WriteLine("Size of int: {0} bytes", sizeof(int));
Console.WriteLine("Size of float: {0} bytes", sizeof(float));
Console.WriteLine("Size of double: {0} bytes", sizeof(char));
Console.WriteLine("Size of char: {0} bytes", sizeof(double));
#endregion

#region ASCIIValue (7)
char c;
Console.WriteLine("Enter a character: ");
c = Convert.ToChar(Console.ReadLine());  
byte ascii = (byte)c;
Console.WriteLine("ASCII value of {0} = {1}", c, ascii);
#endregion

#region AreaOfCircle (8)
double pie = 3.14;
int radius;
Console.WriteLine("Enter The Radius of Cicle:");
radius= int.Parse(Console.ReadLine());
Console.WriteLine("The radius of the circle is {0}" , radius);
float area = (float)(pie* radius * radius);
Console.WriteLine("The area of the given circle is {0}", area);
#endregion

#region AreaOfSquare (9)
Console.WriteLine("Enter the centimet of the square:");
int cent = int.Parse(Console.ReadLine());
Console.WriteLine("The area of square: {0}" ,cent*cent);
#endregion

#region DayToYears,Weeks,Day (10)
Console.WriteLine("Input your total number of days:");
int days = int.Parse(Console.ReadLine()); // Total number of days
// Converts days to years, weeks and days
int years = days/365; // Calculate years
int weeks = (days % 365)/7; // Calculate weeks
int days2 = days - ((years*365) + (weeks*7)); // Calculate remaining days
// Print the results
Console.WriteLine("Years: {0}", years);
Console.WriteLine("Weeks: {0}", weeks);
 Console.WriteLine("Days: {0}", days2);
#endregion