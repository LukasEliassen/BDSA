namespace MyApp.Tests;

public class UnitTest
{
    [Fact]
    public void Test1(){
        Console.WriteLine("omegalul");
        var leapYear = new leapYear();

        var isleapYear = leapYear.isLeapYear(2024);

        Assert.True(isleapYear);

        var leapYear100 = new leapYear();

        var isleapYear100 = leapYear.isLeapYear(1800);

        Assert.False(isleapYear100);

        var leapYear400 = new leapYear();

        var isleapYear400 = leapYear.isLeapYear(2000);

        Assert.True(isleapYear400);
    }
}