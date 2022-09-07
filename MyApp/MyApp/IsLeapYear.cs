public static class leapYear{
    public static bool isLeapYear(int year){
        if(year<1582){
            throw new ArgumentException("year is before 1582");
        }
    if(year%400==0){
        return true;
    }
    if(year%100 == 0){
        return false;
    }
    if(year%4 == 0){
        return true;
    }
    return false;
    }
    public static string yayornay(int year){
        if(isLeapYear(year)){
            return "yay";
        } else {
            return "nay";
        }
    }
}