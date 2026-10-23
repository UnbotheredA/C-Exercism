static class AssemblyLine
{
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
    } 
   
    public static double ProductionRatePerHour(int speed)
    {
        return 221 * speed * SuccessRate(speed); 
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        var workingItems =  221 * speed / 60 * SuccessRate(speed);
        return (int)Math.Round(workingItems);
    }
}
