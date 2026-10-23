
public class Lasagna
{
    public int ExpectedMinutesInOven() => 40; 
    
    public int RemainingMinutesInOven(int minutesInOven)  => ExpectedMinutesInOven() - minutesInOven;
  
    public int PreparationTimeInMinutes(int layersOfLasagna) => layersOfLasagna * 2;

    public int ElapsedTimeInMinutes(int layersOfLasagna, int numOfMinutes) =>  PreparationTimeInMinutes(layersOfLasagna)  + numOfMinutes;
}

  