// See https://aka.ms/new-console-template for more information
Console.WriteLine("Check if a year is a leap year. Type year:");
var input = System.Console.ReadLine();

try {
    int year = Convert.ToInt32(input);
    var yayornay = leapYear.yayornay(year);
    Console.WriteLine(yayornay);
    }catch (Exception e) {
    Console.WriteLine("Error: " + e.Message);
}

