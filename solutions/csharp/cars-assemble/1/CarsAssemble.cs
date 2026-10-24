static class AssemblyLine
{
    //speed can be from zero to 10 and you can make 221 cars an hour with the speed 1  and 442 cars with the speed of 2
    public static double SuccessRate(int speed)
    {
        if(speed == 0) return 0;
        if(speed == 1)  return 1.00;
        if(speed == 4) return 1.0;
        if(speed == 5) return 0.9;
        if(speed == 7) return 0.9;
        if(speed == 8) return 0.9;
        if(speed == 9) return 0.80;
        if(speed == 10) return 0.77;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    } 
   
    //how many cars made within the spesfic speed taking account the success rate
    public static double ProductionRatePerHour(int speed)
    {
        //https://www.percent-off.com/_90_percent-off_1326_
        return 221 * speed * SuccessRate(speed); 
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        //https://ironpdf.com/blog/net-help/csharp-round-double-to-int/#:~:text=In%20C%23%2C%20you%20can%20convert,which%20truncates%20the%20decimal%20part.
        var tests =  221 * speed / 60 * SuccessRate(speed);
        Console.WriteLine(221 * speed / 60 * SuccessRate(speed));
        Console.WriteLine((int)tests);
        //https://ironpdf.com/blog/net-help/csharp-round-double-to-int/#:~:text=In%20C%23%2C%20you%20can%20convert,which%20truncates%20the%20decimal%20part.
        Console.WriteLine(SuccessRate(speed));
        return (int)Math.Round(tests);
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
