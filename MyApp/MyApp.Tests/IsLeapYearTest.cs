namespace MyApp.Tests;

public class IsLeapYearTest
{
    [Fact]
    public void Test4(){

        var isleapYear = leapYear.isLeapYear(2024);

        Assert.True(isleapYear);
    }
    [Fact]
    public void Test100(){
        
        var isleapYear100 = leapYear.isLeapYear(1800);

        Assert.False(isleapYear100);
    }
    [Fact]
    public void Test400(){
        
        var isleapYear400 = leapYear.isLeapYear(2000);

        Assert.True(isleapYear400);
    }    
}